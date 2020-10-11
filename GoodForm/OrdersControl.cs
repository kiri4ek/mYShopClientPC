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
using mYShop;

namespace mYShop
{
    public partial class OrdersControl : UserControl
    {
        UserOrderControl[] orders;
        Button refreshButtonOrders;
        Label labId;
        Label labName;
        Label labNumOrder;
        Label labCount;
        Label labDate;
        Label labTypePay;
        string[] strId, strName, strNumber, strNamePr, strCount, strDateOrders, strTypePay;


        public OrdersControl()
        {
            InitializeComponent();

            labId = new Label
            {
                AutoSize = true,
                Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(204))),
                ForeColor = Color.Goldenrod,
                Location = new Point(19, 30),
                Size = new Size(43, 18),
                TabIndex = 1,
                Text = "Id"
            };

            labName = new Label
            {
                AutoSize = true,
                Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(204))),
                ForeColor = Color.Goldenrod,
                Location = new Point(100, 30),
                Size = new Size(43, 18),
                TabIndex = 1,
                Text = "ФИО"
            };

            labNumOrder = new Label
            {
                AutoSize = true,
                Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(204))),
                ForeColor = Color.Goldenrod,
                Location = new Point(260, 30),
                Size = new Size(43, 18),
                TabIndex = 1,
                Text = "№ заказа"
            };

            labCount = new Label
            {
                AutoSize = true,
                Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(204))),
                ForeColor = Color.Goldenrod,
                Location = new Point(350, 30),
                Size = new Size(43, 18),
                TabIndex = 1,
                Text = "Кол-во"
            };

            labDate = new Label
            {
                AutoSize = true,
                Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(204))),
                ForeColor = Color.Goldenrod,
                Location = new Point(435, 30),
                Size = new Size(43, 18),
                TabIndex = 1,
                Text = "Дата заказа"
            };

            labTypePay = new Label
            {
                AutoSize = true,
                Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(204))),
                ForeColor = Color.Goldenrod,
                Location = new Point(580, 30),
                Size = new Size(43, 18),
                TabIndex = 1,
                Text = "Тип оплаты"
            };

            refreshButtonOrders = new Button
            {
                Font = new Font("Century Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 204),
                BackColor = Color.Goldenrod,
                FlatStyle = FlatStyle.Flat,
                ForeColor = Color.White,
                TabIndex = 1,
                UseVisualStyleBackColor = false,
                Location = new Point(630, 1),
                Name = "refresh_basket",
                Text = "Обновить"
            };
            refreshButtonOrders.Click += new EventHandler(this.RefreshButtonClick);

            Controls.Add(labId);
            Controls.Add(labName);
            Controls.Add(labNumOrder);
            Controls.Add(labCount);
            Controls.Add(labDate);
            Controls.Add(labTypePay);
            Controls.Add(refreshButtonOrders);

            if (Holder.id_client < 0)
                ReloadOrders();
        }

        public void ReloadOrders()
        {
            if (orders != null)
                foreach (UserOrderControl order in orders)
                    Controls.Remove(order);

            Functions functions = new Functions();
            functions.LoadOrders();

            if (functions.str != "" & functions.connect)
            {
                strId = functions.idOrders.Remove(functions.idOrders.Length - 1).Split(' '); // делит строку заданным символом получаем массив id и Count (string)

                strName = functions.NameSurnameUsers.Remove(functions.NameSurnameUsers.Length - 1).Split('$'); // делит строку заданным символом получаем массив id и Count (string)

                strNumber = functions.NumerOrders.Remove(functions.NumerOrders.Length - 1).Split(' '); // делит строку заданным символом получаем массив id и Count (string)

                strNamePr = functions.NameProducts.Remove(functions.NameProducts.Length - 1).Split('$'); // делит строку заданным символом получаем массив id и Count (string)

                strCount = functions.CountProducts.Remove(functions.CountProducts.Length - 1).Split(' '); // делит строку заданным символом получаем массив id и Count (string)

                strDateOrders = functions.DateOrders.Remove(functions.DateOrders.Length - 1).Split('$'); // делит строку заданным символом получаем массив id и Count (string)

                strTypePay = functions.TypeOfPayments.Remove(functions.TypeOfPayments.Length - 1).Split(' '); // делит строку заданным символом получаем массив id и Count (string)

                orders = new UserOrderControl[strName.Length];

                AutoScroll = false;
                for (int i = 0; i < strName.Length; i++)
                {
                    Display(i, strId[i], strName[i], strNumber[i], strNamePr[i], strCount[i], strDateOrders[i], strTypePay[i]);
                }
                AutoScroll = true;

                //string s0 = str2[1].Substring(1, str2[1].Length - 1); 
                //str = str2.Length;  //Длина массива, кол-во id и Count

                //s_id = new int[str];   	//получаем массив id (int)
                //s_kol = new int[str];   //получаем массив Count (int)
            }
            /*else
                if (!firstStart & Order)
                    MessageBox.Show("Корзина пуста");*/
        }

        public void Display(int i, string id, string NameSurname, string NumerOrders, string NameProducts, string CountOrders, string DateOrders, string TypeOfPayments)
        {
            int stepY = 30;

            orders[i] = new UserOrderControl
            {
                IdLable = Convert.ToInt32(id),
                Id = Convert.ToString(i + 1),
                NameSurname = NameSurname,
                NumOrder = NumerOrders,
                CountProd = CountOrders,
                TypeOfPay = TypeOfPayments,
                DateOrd = DateOrders,
                Location = new Point(24, 55 + stepY * i),
                Name = "ProductPanel " + id.ToString()
            };
            //orders[i].productBuy.Click += new EventHandler(this.BuyButton_Click);
            Controls.Add(orders[i]);
        }

        private void RefreshButtonClick(object sender, EventArgs e)
        {
            (Application.OpenForms["MainForm"] as MainForm).ordersControl1.ReloadOrders();
        }
    }
}
