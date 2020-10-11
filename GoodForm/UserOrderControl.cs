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
    public partial class UserOrderControl : UserControl
    {
        public UserOrderControl()
        {
            InitializeComponent();
        }

        public int IdLable { get; set; }

        public string Id { get { return id.Text; } set { id.Text = value; } }

        public string NameSurname { get { return UserName.Text; } set { UserName.Text = value; } }

        public string NumOrder { get { return NumberOrder.Text; } set { NumberOrder.Text = value; } }

        public string CountProd { get { return Count.Text; } set { Count.Text = value; } }

        public string DateOrd { get { return DateOrder.Text; } set { DateOrder.Text = value; } }

        public string TypeOfPay { get { return TypeOfPayment.Text; } set { TypeOfPayment.Text = value; } }

        private void DeleteOrder_Click(object sender, EventArgs e)
        {
            UserOrderControl order = (sender as Control).Parent as UserOrderControl;
            Functions functions = new Functions();

            functions.DeleteOrder(order.IdLable);
            (Application.OpenForms["MainForm"] as MainForm).ordersControl1.ReloadOrders();
        }
    }
}
