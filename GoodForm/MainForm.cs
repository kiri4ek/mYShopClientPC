using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mYShop
{
    public partial class MainForm : Form
    {
        
        public MainForm()
        {
            InitializeComponent();
            SidePanel.Height = GlobalButton.Height;
            SidePanel.Top = GlobalButton.Top;
            firstCustomControl1.BringToFront();
            Holder.click = false;
            if (Holder.id_client < 0)
                OrdersButton.Visible = true;
        }

        private void GlobalButton_Click(object sender, EventArgs e)
        {
            SidePanel.Height = GlobalButton.Height;
            SidePanel.Top = GlobalButton.Top;
            firstCustomControl1.BringToFront();
        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            SidePanel.Height = MenuButton.Height;
            SidePanel.Top = MenuButton.Top;
            menuControl1.BringToFront();
        }

        private void SetsButton_Click(object sender, EventArgs e)
        {
            SidePanel.Height = SetsButton.Height;
            SidePanel.Top = SetsButton.Top;
            setsControl1.BringToFront();
        }

        private void DiscountButton_Click(object sender, EventArgs e)
        {
            SidePanel.Height = DiscountButton.Height;
            SidePanel.Top = DiscountButton.Top;
            discountControl1.BringToFront();
        }

        private void FoodbasketButton_Click(object sender, EventArgs e)
        {
            SidePanel.Height = FoodbasketButton.Height;
            SidePanel.Top = FoodbasketButton.Top;
            basketControl1.BringToFront();
            if (Holder.click)
            {
                basketControl1.ReloadBasket();
                Holder.click = false;
            }

        }

        public void OrdersButton_Click(object sender, EventArgs e)
        {
            SidePanel.Height = OrdersButton.Height;
            SidePanel.Top = OrdersButton.Top;
            ordersControl1.BringToFront();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        Point lastPoint;
        private void MenuPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void MenuPanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void HeadPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void HeadPanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void DrawPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void DrawPanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void firstCustomControl1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void firstCustomControl1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void label2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void label2_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            settingsControl1.BringToFront();
        }

        private void InstagramButton_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.instagram.com/kirik4ek/");
        }

        private void VKButton_Click(object sender, EventArgs e)
        {
            Process.Start("https://vk.com/korotchenko12");
        }

        private void OutLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void OutLogin_MouseEnter(object sender, EventArgs e)
        {
            OutLogin.ForeColor = Color.Red;
        }

        private void OutLogin_MouseLeave(object sender, EventArgs e)
        {
            OutLogin.ForeColor = Color.White;
        }

        private void RollButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }

    public static class Holder
    {
        public static int id_client { get; set; }
        public static bool click { get; set; }
    }
}
