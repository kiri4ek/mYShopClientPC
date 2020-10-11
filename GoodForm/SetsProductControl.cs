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
    public partial class SetsProductControl : UserControl
    {
        public int ID { get; set; }

        public string Title { get { return productName.Text; } set { productName.Text = value; } }

        public string Description { get { return descriptionLabel.Text; } set { descriptionLabel.Text = value; } }

        public string Price { get { return productPrice.Text; } set { productPrice.Text = value.ToString() + " ₽"; } }

        public string Picture { get { return productPicture.ImageLocation; } set { productPicture.ImageLocation = value; } }

        public SetsProductControl()
        {
            InitializeComponent();
        }
    }
}
