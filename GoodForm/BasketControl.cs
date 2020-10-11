using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Text.RegularExpressions;
using System.Globalization;
using System.Threading;

namespace mYShop
{
    public partial class BasketControl : UserControl
    {
        public int str;
        int[] s_id, s_kol;
        Button refreshB;
        RadioButton cashPayRB;
        RadioButton nonCashPayRB;
        BasketProductControl[] products;

        public BasketControl()
        {
            InitializeComponent();

            refreshB = new Button
            {
                Font = new Font("Century Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 204),
                BackColor = Color.Goldenrod,
                FlatStyle = FlatStyle.Flat,
                ForeColor = Color.White,
                TabIndex = 1,
                UseVisualStyleBackColor = false,
                Location = new Point(400, 1),
                Name = "refresh_basket",
                Text = "Обновить"
            };
            refreshB.Click += new EventHandler(this.RefreshButtonClick);

            nonCashPayRB = new RadioButton
            {
                Location = new Point(490, 1),
                Name = "non_cash_pay",
                Text = "Безналичный"
            };


            cashPayRB = new RadioButton
            {
                Location = new Point(600, 1),
                Name = "cash_pay",
                Text = "Наличный"
            };

            Controls.Add(refreshB);
            Controls.Add(nonCashPayRB);
            Controls.Add(cashPayRB);

            ReloadBasket();
        }

        public void ReloadBasket()
        {
            //Если уже выведены товары в корзине то перед новым обновлением нужно предыдущие отчистить
            if (products != null)
                foreach (BasketProductControl product in products)
                    Controls.Remove(product);

            Functions functions = new Functions();
            functions.LoadBasket();

            if (functions.str != "" & functions.connect)
            {
                string[] str2 = functions.str.Remove(functions.str.Length - 1).Split('\n'); // делит строку заданным символом получаем массив id и Count (string)
                
                str = str2.Length;  //Длина массива, кол-во id и Count

                s_id = new int[str];   	//получаем массив id (int)
                s_kol = new int[str];   //получаем массив Count (int)

                products = new BasketProductControl[str];

                AutoScroll = false;
                for (int i = 0; i < str; i++)
                {
                    s_id[i] = Convert.ToInt32(str2[i].Substring(0, str2[i].IndexOf(" ")));
                    s_kol[i] = Convert.ToInt32(str2[i].Substring(1, str2[i].Length - 1));
                    functions.LoadProducts(s_id[i]);
                    Display(functions, i, s_id[i], s_kol[i]);
                }
                AutoScroll = true;
            }
            /*else
                if (!firstStart & Order)
                    MessageBox.Show("Корзина пуста");*/
        }

        public void Display(Functions functions, int i, int id, int kol)
        {
            //MessageBox.Show(functions.Adress);
            
            int stepY = 60;

            products[i] = new BasketProductControl
            {
                ID = id,
                Title = functions.ProductName,
                Count = kol,
                Price = decimal.Parse(functions.Price),
                Location = new Point(24, 28 + stepY * i),
                Name = "ProductPanel " + id.ToString()
            };
            products[i].productBuy.Click += new EventHandler(this.BuyButton_Click);
            Controls.Add(products[i]);
        }

        private void RefreshButtonClick(object sender, EventArgs e)
        {
            (Application.OpenForms["MainForm"] as MainForm).basketControl1.ReloadBasket();
        }

        private void BuyButton_Click(object sender, EventArgs e)
        {
            BasketProductControl product = (sender as Control).Parent as BasketProductControl;
            //MessageBox.Show("Нажата кнопка в продукте " + product.Name + ".");

            //MessageBox.Show("Количество: " + product.Count);

            if (cashPayRB.Checked)
            {
                Functions functions = new Functions();
                functions.AddOrder(product.ID, (uint)product.Count, "Наличный");
                (Application.OpenForms["MainForm"] as MainForm).basketControl1.ReloadBasket();
            }
            else if (nonCashPayRB.Checked)
            {
                Functions functions = new Functions();
                functions.AddOrder(product.ID, (uint)product.Count, "Безналичный");
                (Application.OpenForms["MainForm"] as MainForm).basketControl1.ReloadBasket();
            }
            else
            {
                MessageBox.Show("Выберите тип оплаты!");
            }
        }
    }
}