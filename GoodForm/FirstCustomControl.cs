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
    public partial class FirstCustomControl : UserControl
    {
        public int start = 14, str;
        string[] str2;
        int[] s;
        private Control m;

        public FirstCustomControl()
        {
            InitializeComponent();
            Interlayer();
        }

        protected void Interlayer()
        {
            double chance1 = 0, chance2 = 0.5;
            string Type = "Стандарт";

            Functions functions = new Functions();
            functions.KolProductsChance(chance1, chance2, Type);

            if (functions.str != "" & functions.connect)
            {
                string str1;

                str1 = functions.str.Substring(0, functions.str.Length - 1);

                str2 = str1.Split(' ');// делит строку заданным символом получаем массив id (string)

                str = str2.Length;  //Длина массива кол-во id

                s = new int[str];   //получаем массив id (int)

                AutoScroll = false;
                for (int i = 0; i < str; i++)
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
            AutoScroll = false;


            Label[] label1 = new Label[str];
            Label[] label2 = new Label[str];
            Label[] label3 = new Label[str];
            Label[] label4 = new Label[str];
            Button[] button1 = new Button[str];
            PictureBox[] pictures = new PictureBox[str];


            label1[i] = new Label
            {
                AutoSize = true,
                Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(204))),
                ForeColor = Color.Goldenrod,
                Location = new Point(19, start),
                Name = "label0 " + id.ToString(),
                Size = new Size(43, 18),
                TabIndex = 1,
                Text = "Only"
            };
            Controls.Add(label1[i]);

            label2[i] = new Label
            {
                AutoSize = true,
                Font = new Font("Elephant", 71.99999F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0))),
                ForeColor = Color.Goldenrod,
                Location = new Point(23, start + 10),
                Name = "label0 " + id.ToString(),
                Size = new Size(295, 123),
                TabIndex = 2,
                Text = functions.Price
            };
            Controls.Add(label2[i]);

            label3[i] = new Label
            {
                AutoSize = true,
                Font = new Font("Century Gothic", 26.25F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(204))),
                Location = new Point(38, start + 126),
                Name = "label0 " + id.ToString(),
                Size = new Size(202, 41),
                TabIndex = 3,
                Text = functions.ProductName
            };
            Controls.Add(label3[i]);

            label4[i] = new Label
            {
                AutoSize = true,
                Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204))),
                Location = new Point(19, start + 180),
                Name = "label0 " + id.ToString(),
                Size = new Size(373, 68),
                TabIndex = 4,
                Text = functions.DescriptionGoods
            };
            Controls.Add(label4[i]);

            button1[i] = new Button
            {
                Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204))),
                BackColor = Color.Goldenrod,
                FlatStyle = FlatStyle.Flat,
                ForeColor = Color.White,
                Location = new Point(45, start + 268),
                Name = "button0 " + id.ToString(),
                Size = new Size(304, 29),
                TabIndex = 5,
                Text = "Добавить в корзину",
                UseVisualStyleBackColor = false
            };
            button1[i].FlatAppearance.BorderSize = 0;
            button1[i].Click += new EventHandler(this.button1_Click);
            Controls.Add(button1[i]);


            pictures[i] = new PictureBox
            {
                Location = new Point(390, start + 5),
                Name = "pictureBox0 " + id.ToString(),
                Size = new Size(217, 180),
                SizeMode = PictureBoxSizeMode.Zoom,
                TabIndex = 6,
                TabStop = false
            };
            Controls.Add(pictures[i]);
            pictures[i].Load(functions.URL_Photo);

            start += 335;

            if (i + 1 == str)
                AutoScroll = true;
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
