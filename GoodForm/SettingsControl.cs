using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace mYShop
{
    public partial class SettingsControl : UserControl
    {
        TextBox First_Name_Text, Surname_Text, Login_Text, Password_Text;
        Label First_Name_Lable, Surname_Lable, Login_Lable, Password_Lable;
        Button Save;
        string Now_name, Now_surname, Now_login, Now_pass;

        public SettingsControl()
        {
            InitializeComponent();
            OutputInfoClient();
        }

        public void OutputInfoClient()
        {
            int start_lable_x = 20 + 200, start_text_x = 170 + 200;
            Functions functions = new Functions();
            functions.InfoClient();
            Now_name = functions.First_Name;
            Now_surname = functions.Surname;
            Now_login = functions.Login;
            Now_pass = functions.Password;


            First_Name_Lable = new Label
            {
                AutoSize = true,
                Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204),
                ForeColor = Color.Goldenrod,
                Location = new Point(start_lable_x, 50),
                Name = "First_Name_Lable",
                Text = "Имя:"
            };

            Surname_Lable = new Label
            {
                AutoSize = true,
                Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204),
                ForeColor = Color.Goldenrod,
                Location = new Point(start_lable_x, 100),
                Name = "Surname_Lable",
                Text = "Фамилия:"
            };

            Login_Lable = new Label
            {
                AutoSize = true,
                Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204),
                ForeColor = Color.Goldenrod,
                Location = new Point(start_lable_x, 150),
                Name = "Login_Lable",
                Text = "Логин(email):"
            };

            Password_Lable = new Label
            {
                AutoSize = true,
                Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204),
                ForeColor = Color.Goldenrod,
                Location = new Point(start_lable_x, 200),
                Name = "Password_Lable",
                Text = "Пароль:"
            };


            First_Name_Text = new TextBox
            {
                Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204),
                Location = new Point(start_text_x, 50),
                Size = new Size(250, 20),
                Name = "First_Name",
                Text = functions.First_Name,
                MaxLength = 20
            };

            Surname_Text = new TextBox
            {
                Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204),
                Location = new Point(start_text_x, 100),
                Size = new Size(250, 20),
                Name = "Surname",
                Text = functions.Surname,
                MaxLength = 20
            };

            Login_Text = new TextBox
            {
                Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204),
                Location = new Point(start_text_x, 150),
                Size = new Size(250, 20),
                Name = "Login",
                Text = functions.Login,
                MaxLength = 70
            };

            Password_Text = new TextBox
            {
                Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204),
                Location = new Point(start_text_x, 200),
                Size = new Size(250, 20),
                Name = "Password",
                Text = functions.Password,
                MaxLength = 30
            };



            Save = new Button
            {
                Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204),
                BackColor = Color.Goldenrod,
                FlatStyle = FlatStyle.Flat,
                ForeColor = Color.White,
                Location = new Point(270, 280),
                Name = "SaveInfo",
                Size = new Size(304, 40),
                TabIndex = 5,
                Text = "Сохранить",
                UseVisualStyleBackColor = false
            };
            Save.Click += new EventHandler(this.SaveClick);

            Controls.Add(First_Name_Lable);
            Controls.Add(Surname_Lable);
            Controls.Add(Login_Lable);
            Controls.Add(Password_Lable);

            Controls.Add(First_Name_Text);
            Controls.Add(Surname_Text);
            Controls.Add(Login_Text);
            Controls.Add(Password_Text);

            Controls.Add(Save);
        }

        private void SaveClick(object sender, EventArgs e)
        {
            string patternName = @"^([А-Я]{1}[а-яё]{1,23}|[A-Z]{1}[a-z]{1,23})$";
            string patternSurname = patternName;
            string patternLogin = @"^([a-z0-9_-]+\.)*[a-z0-9_-]+@[a-z0-9_-]+(\.[a-z0-9_-]+)*\.[a-z]{2,6}$";

            Regex regexName = new Regex(patternName);
            MatchCollection matchesName = regexName.Matches(First_Name_Text.Text);

            if ((First_Name_Text.Text != "") && (matchesName.Count > 0))
            {
                Regex regexSurname = new Regex(patternSurname);
                MatchCollection matchesSurname = regexSurname.Matches(Surname_Text.Text);

                if ((Surname_Text.Text != "") && (matchesSurname.Count > 0))
                {
                    Regex regexLogin = new Regex(patternLogin);
                    MatchCollection matchesLogin = regexLogin.Matches(Login_Text.Text);

                    if ((Login_Text.Text != "") && (matchesLogin.Count > 0))
                    {

                        if ((Password_Text.Text != "") && (Password_Text.TextLength >= 8))
                        {
                            if (First_Name_Text.Text != Now_name || Surname_Text.Text != Now_surname || Login_Text.Text != Now_login || Password_Text.Text != Now_pass)
                            {
                                Functions functions = new Functions();
                                functions.EditClient(First_Name_Text.Text, Surname_Text.Text, Login_Text.Text, Password_Text.Text);
                                //(Application.OpenForms["MainForm"] as MainForm).settingsControl1.OutputInfoClient();
                                if (functions.connect & functions.edit)
                                {
                                    Now_name = First_Name_Text.Text;
                                    Now_surname = Surname_Text.Text;
                                    Now_login = Login_Text.Text;
                                    Now_pass = Password_Text.Text;
                                }
                            }
                            else
                                MessageBox.Show("Все осталось без изменений");

                        } else if (Password_Text.Text == "")
                        {
                            MessageBox.Show("Введите пароль!");
                        }
                        else if (Password_Text.TextLength < 8)
                        {
                            MessageBox.Show("Длина пароля должна составлять не менее 8 символов!");
                        }

                    } else if (Login_Text.Text == "")
                    {
                        MessageBox.Show("Введите email!");
                    }
                    else if (matchesLogin.Count == 0)
                    {
                        MessageBox.Show("Некорректный формат email! Принимается формат типа: ****@mail.ru");
                    }

                } else if (Surname_Text.Text == "")
                {
                    MessageBox.Show("Введите Фамилию!");
                }
                else if (matchesSurname.Count == 0)
                {
                    MessageBox.Show("Некорректный формат Фамилии! Принимаются начиная с большой буквы Рус/Англ");
                }

            } else if (First_Name_Text.Text == "")
            {
                MessageBox.Show("Введите Имя!");
            }
            else if (matchesName.Count == 0)
            {
                MessageBox.Show("Некорректный формат Имени! Принимаются начиная с большой буквы Рус/Англ");
            }
        }
    }
}
