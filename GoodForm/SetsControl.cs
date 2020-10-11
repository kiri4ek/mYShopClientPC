using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mYShop
{
    public partial class SetsControl : UserControl
    {
        public int str;
        int[] s_id;
        SetsProductControl[] products;

        public SetsControl()
        {
            InitializeComponent();

            ReloadSets();
        }

        public void ReloadSets()
        {
            double chance1 = 0.3, chance2 = 0.7;
            string Type = "Сет";

            if (products != null)
                foreach (SetsProductControl product in products)
                    Controls.Remove(product);

            

            Functions functions = new Functions();
            functions.KolProductsChance(chance1, chance2, Type);

            if (functions.str != "" & functions.connect)
            {
                string[] str2 = functions.str.Remove(functions.str.Length - 1).Split(' '); // делит строку заданным символом получаем массив id и Count (string)
                //string s0 = str2[1].Substring(1, str2[1].Length - 1); 
                str = str2.Length;  //Длина массива, кол-во id и Count

                s_id = new int[str];   //получаем массив id (int)

                products = new SetsProductControl[str];

                AutoScroll = false;
                for (int i = 0; i < str; i++)
                {
                    s_id[i] = Convert.ToInt32(str2[i]);
                    functions.LoadProducts(s_id[i]);
                    Display(functions, i, s_id[i]);
                }
                AutoScroll = true;
            }
        }

        public void Display(Functions functions, int i, int id)
        {
            //MessageBox.Show(functions.Adress);

            int stepY = 220;

            products[i] = new SetsProductControl
            {
                ID = id,
                Title = functions.ProductName,
                Description = functions.DescriptionGoods,
                Price = Convert.ToString(functions.Price),
                Picture = functions.URL_Photo,
                Location = new Point(24, 28 + stepY * i),
                Name = "ProductPanel " + id.ToString()
            };
            products[i].productBuy.Click += new EventHandler(this.BuyButton_Click);
            Controls.Add(products[i]);
        }

        private void BuyButton_Click(object sender, EventArgs e)
        {
            SetsProductControl product = (sender as Control).Parent as SetsProductControl;
            //MessageBox.Show("Кнопка " + m.Name + " есть!");
            Functions functions = new Functions();
            functions.AddBasketProduct(product.ID, 1);
            if (functions.basketOut == "1")
                (Application.OpenForms["MainForm"] as MainForm).basketControl1.ReloadBasket();
        }
    }
}
