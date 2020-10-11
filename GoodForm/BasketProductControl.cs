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
    public partial class BasketProductControl : UserControl
    {
        private decimal price = 0;
        public int ID { get; set; }
        public string Title { get { return productName.Text; } set { productName.Text = value; } }
        public decimal Count
        {
            get { return (uint)productCount.Value ; }
            set
            {
                productCount.Value = value;
                productPrice.Text = (value * price).ToString() + " ₽";
            }
        }
        public decimal Price
        {
            get { return price; }
            set
            {
                price = value;
                productPrice.Text = (Count * value).ToString() + " ₽";
            }
        }
        public decimal TotalPrice { get { return decimal.Parse(productPrice.Text); } }

        private void UpdateTotalPrice(object sender, EventArgs e)
        {
            BasketProductControl product = (sender as Control).Parent as BasketProductControl;
            Functions functions = new Functions();

            functions.UpdateBasketProduct(product.ID, (uint)product.Count);
            productPrice.Text = (Count * price).ToString() + " ₽";
        }


        private void DeleteProduct_Click(object sender, EventArgs e)
        {
            BasketProductControl product = (sender as Control).Parent as BasketProductControl;
            Functions functions = new Functions();

            functions.DeleteBasketProduct(product.ID);
            (Application.OpenForms["MainForm"] as MainForm).basketControl1.ReloadBasket();
        }

        public BasketProductControl()
        {
            InitializeComponent();
        }

        private void DeleteProduct_MouseEnter(object sender, EventArgs e)
        {
            DeleteProduct.ForeColor = Color.Red;
        }

        private void DeleteProduct_MouseLeave(object sender, EventArgs e)
        {
            DeleteProduct.ForeColor = Color.White;
        }
    }
}