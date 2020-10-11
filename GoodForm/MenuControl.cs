using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;

namespace mYShop
{
    public partial class MenuControl : UserControl
    {
        public int str, k = 0, p = 0;
        string str1;
        int[] s;
        private Control m;
        protected Panel[] panels;

        public MenuControl()
        {
            InitializeComponent();
            Interlayer();
        }

        protected void Interlayer()
        {
            //double chance1 = 0.5, chance2 = 1;
            //string Type = "Стандарт";

            Functions functions = new Functions();
            functions.KolProducts();

            if (functions.str != "")
            {
                str1 = functions.str.Substring(0, functions.str.Length - 1);

                string[] str2 = str1.Split(' ');// делит строку заданным символом
                str = str2.Length;
                s = new int[str2.Length];

                panels = new Panel[str];

                AutoScroll = false;
                for (int i = 0; i < str2.Length; i++)
                {
                    s[i] = Convert.ToInt32(str2[i]);
                    functions.LoadProducts(s[i]);
                    Display(functions, i, s[i]);
                }
                AutoScroll = true;
            }
            else
                MessageBox.Show("В базе данных нет товара!");
        }

        protected void Display(Functions functions, int i, int id)
        {
            //MessageBox.Show(functions.Adress);


            Panel[] panel1 = new Panel[str];
            

            int stepX = 233, stepY = 330;

            if ((k + 1) % 4 == 0)
            {
                k = 0;
                p++;
            }

            Label label1 = new Label
            {
                AutoSize = true,
                Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204),
                Location = new Point(9, 16),
                Name = "ProductName " + id.ToString(),
                Size = new Size(85, 25),
                TabIndex = 0,
                Text = functions.ProductName
            };

            Label label2 = new Label
            {
                AutoSize = true,
                Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 204),
                Location = new Point(9, 200),
                Name = "DescriptionGoodsshort " + id.ToString(),
                Size = new Size(122, 17),
                TabIndex = 2,
                Text = functions.DescriptionGoodsshort
            };

            Label label3 = new Label
            {
                AutoSize = true,
                Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204),
                Location = new Point(9, 248),
                Name = "Price " + id.ToString(),
                Size = new Size(61, 25),
                TabIndex = 4,
                Text = functions.Price + "₽"
            };

            Button button1 = new Button
            {
                BackColor = Color.Goldenrod,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 204),
                ForeColor = Color.White,
                Location = new Point(98, 247),
                Name = "BuyButton " + id.ToString(),
                Size = new Size(99, 26),
                TabIndex = 6,
                Text = "В корзину",
                UseVisualStyleBackColor = false
            };
            button1.FlatAppearance.BorderSize = 0;
            button1.Click += new EventHandler(this.button1_Click);

            PictureBox pictures = new PictureBox
            {
                Location = new Point(3, 44),
                Name = "pictureBox " + id.ToString(),
                Size = new Size(194, 155),
                TabIndex = 1,
                TabStop = false
            };

            pictures.Load(functions.URL_Photo);

            panels[i] = new Panel
            {
                BackColor = Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))),
                Location = new Point(24 + stepX * k, 23 + stepY * p),
                Name = "ProductPanel " + id.ToString(),
                Size = new Size(200, 276),
                TabIndex = 0
            };


            panels[i].Controls.Add(label1);
            panels[i].Controls.Add(label2);
            panels[i].Controls.Add(button1);
            panels[i].Controls.Add(label3);
            panels[i].Controls.Add(pictures);

            Controls.Add(panels[i]);

            k++;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            m = (Control)sender;
            //MessageBox.Show("Кнопка " + m.Name + " есть!");
            int id = Convert.ToInt32(m.Name.Substring(m.Name.IndexOf(" ")));
            Functions functions = new Functions();
            functions.AddBasketProduct(id, 1);
            if (functions.basketOut == "1")
                (Application.OpenForms["MainForm"] as MainForm).basketControl1.ReloadBasket();
            
        }
    }
}
