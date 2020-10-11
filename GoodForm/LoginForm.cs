using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mYShop
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            loginField.Text = "Введите логин";
            loginField.ForeColor = Color.Gray;

        }

        // обработчик кнопки выключения
        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // обработчик цвета выделения
        private void Close_MouseEnter(object sender, EventArgs e)
        {
            Close.ForeColor = Color.DarkGreen;
        }

        // обработчик цвета выделения
        private void Close_MouseLeave(object sender, EventArgs e)
        {
            Close.ForeColor = Color.White;
        }

        Point lastPoint;

        // обработчик перемещения формы
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        // обработчик перемещения формы
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        // обработчик перемещения формы
        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        // обработчик перемещения формы
        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        // обработчик нажатия клавиши вход
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if ((loginField.Text != "") && (loginField.Text != "Введите логин"))
            {
                if (passField.Text != "")
                {
                    Application.UseWaitCursor = true;

                    // запрос к серверу на вход текущего пользователя
                    Functions functions = new Functions();
                    functions.LoginCleint(loginField.Text, passField.Text, this);

                } else MessageBox.Show("Введите пароль!");

            } else MessageBox.Show("Введите логин!");
        }

        // обработчик замещения текста при вводе логина
        private void loginField_Enter(object sender, EventArgs e)
        {
            if (loginField.Text == "Введите логин")
            {
                loginField.Text = "";
                loginField.ForeColor = Color.Black;
            }
        }

        // обработчик замещения текста при вводе логина
        private void loginField_Leave(object sender, EventArgs e)
        {
            if (loginField.Text == "")
            {
                loginField.Text = "Введите логин";
                loginField.ForeColor = Color.Gray;
            }
        }

        // обработчик нажатия label для регистрации
        private void RegisterLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
        }

        // обработчик наводки на label регистрации
        private void RegisterLabel_MouseEnter(object sender, EventArgs e)
        {
            RegisterLabel.ForeColor = Color.DarkGreen;
        }

        // обработчик наводки на label регистрации
        private void RegisterLabel_MouseLeave(object sender, EventArgs e)
        {
            RegisterLabel.ForeColor = Color.White;
        }

        // обработчик нажатия на label свертки окна
        private void RollLabel_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // обработчик наводки на label свертки окна
        private void RollLabel_MouseEnter(object sender, EventArgs e)
        {
            RollLabel.ForeColor = Color.DarkGreen;
        }

        // обработчик наводки на label свертки окна
        private void RollLabel_MouseLeave(object sender, EventArgs e)
        {
            RollLabel.ForeColor = Color.White;
        }

        private void pictureBoxPass_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;

            if (passField.UseSystemPasswordChar)
            {
                passField.UseSystemPasswordChar = false;
                pictureBox.Image = Properties.Resources.eye_visible as Bitmap;
            }
            else
            {
                passField.UseSystemPasswordChar = true;
                pictureBox.Image = Properties.Resources.not_visible as Bitmap;
            }
        }
    }
}
