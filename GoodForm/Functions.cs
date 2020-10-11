using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mYShop
{
    public class Functions
    {
        public string basketOut, KolinBasket, str, ProductName, DescriptionGoods, DescriptionGoodsshort, Price, Kol, URL_Photo, Data_item, Chance_to_buy, Adress;
        public string First_Name, Surname, Login, Password;
        public string idOrders, NameSurnameUsers, NumerOrders, NameProducts, CountProducts, DateOrders, TypeOfPayments;
        public bool connect, edit;

        public async void RegisterClient (string Name, string Surname, string Login, string Pass, RegisterForm register)
        {
            try
            {

                HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://xoxol1898.000webhostapp.com/index2.php");

                // устанавливаем тип содержимого - параметр ContentType
                request.ContentType = "application/x-www-form-urlencoded";

                // для отправки используется метод Post
                request.Method = "POST";

                // время ожидания ответа от сервера
                //request.Timeout = 8000;

                // данные для отправки
                string data = "host=localhost&user=id12516608_admin&pas=moloko123&database=id12516608_baseshop&type=registration&firstName=" + Name + "&Surname=" + Surname + "&loginReg=" + Login + "&passwordReg=" + Pass;

                String result = String.Empty;

                // преобразуем данные в массив байтов
                byte[] byteArray = System.Text.Encoding.UTF8.GetBytes(data);

                // Устанавливаем заголовок Content-Length запроса - свойство ContentLength
                request.ContentLength = byteArray.Length;


                //записываем данные в поток запроса
                using (Stream dataStream = request.GetRequestStream())
                {
                    dataStream.Write(byteArray, 0, byteArray.Length);
                }

                using (HttpWebResponse response = await request.GetResponseAsync() as HttpWebResponse)
                {
                    using (Stream stream = response.GetResponseStream())
                    {
                        using (StreamReader reader = new StreamReader(stream))
                        {
                            string html = reader.ReadToEnd();
                            result = Regex.Replace(html, "<[^>]+>", "\n");

                            string vivod1 = result.Substring(106);
                            string output = vivod1.Substring(0, vivod1.IndexOf("\n"));
                            MessageBox.Show(output);
                        }
                    }

                    String podtv = result.Substring(result.Length - 1);
                    if (podtv == "1")
                    {
                        register.Hide();
                        LoginForm loginForm = new LoginForm();
                        loginForm.Show();

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Отсутствует подключение к серверу, проверьте подключение к интернету", "Подключение к сети", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
        }

        public async void LoginCleint (string Login, string Pass, LoginForm loginForm)
        {
            try
            {

                HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://xoxol1898.000webhostapp.com/index2.php");

                // устанавливаем тип содержимого - параметр ContentType
                request.ContentType = "application/x-www-form-urlencoded";

                // для отправки используется метод Post
                request.Method = "POST";

                // время ожидания ответа от сервера
                //request.Timeout = 8000;

                // данные для отправки
                string data = "host=localhost&user=id12516608_admin&pas=moloko123&database=id12516608_baseshop&type=login&login=" + Login + "&password=" + Pass;

                String result = String.Empty;

                // преобразуем данные в массив байтов
                byte[] byteArray = System.Text.Encoding.UTF8.GetBytes(data);

                // Устанавливаем заголовок Content-Length запроса - свойство ContentLength
                request.ContentLength = byteArray.Length;


                //записываем данные в поток запроса
                using (Stream dataStream = request.GetRequestStream())
                {
                    dataStream.Write(byteArray, 0, byteArray.Length);
                }

                using (HttpWebResponse response = await request.GetResponseAsync() as HttpWebResponse)
                {
                    using (Stream stream = response.GetResponseStream())
                    {
                        using (StreamReader reader = new StreamReader(stream))
                        {
                            string html = reader.ReadToEnd(), vivod1, vivod2, output, podtv;
                            result = Regex.Replace(html, "<[^>]+>", "\n");

                            vivod1 = result.Substring(106);
                            output = vivod1.Substring(0, vivod1.IndexOf("\n"));

                            vivod2 = vivod1.Substring(output.Length + 1);
                            podtv = vivod2.Substring(0, vivod2.IndexOf("\n"));

                            if (podtv == "1")
                            {
                                vivod1 = vivod2.Substring(podtv.Length + 1);
                                Holder.id_client = Convert.ToInt32(vivod1.Substring(0, vivod1.IndexOf("\n")));

                                MessageBox.Show(output);
                                loginForm.Hide();
                                MainForm mainForm = new MainForm();
                                mainForm.Show();
                                Application.UseWaitCursor = false;
                            }
                            else
                            {
                                MessageBox.Show(output);
                                Application.UseWaitCursor = false;
                            }

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Application.UseWaitCursor = false;
                MessageBox.Show("Отсутствует подключение к серверу, проверьте подключение к интернету", "Подключение к сети", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
        }

        public void LoadProducts(int id)
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://xoxol1898.000webhostapp.com/index2.php");

                // устанавливаем тип содержимого - параметр ContentType
                request.ContentType = "application/x-www-form-urlencoded";

                // для отправки используется метод Post
                request.Method = "POST";

                // время ожидания ответа от сервера
                //request.Timeout = 8000;

                // данные для отправки
                string data = "host=localhost&user=id12516608_admin&pas=moloko123&database=id12516608_baseshop&type=LoadProduct&id=" + id;

                String result = String.Empty;

                // преобразуем данные в массив байтов
                byte[] byteArray = System.Text.Encoding.UTF8.GetBytes(data);

                // Устанавливаем заголовок Content-Length запроса - свойство ContentLength
                request.ContentLength = byteArray.Length;


                //записываем данные в поток запроса
                using (Stream dataStream = request.GetRequestStream())
                {
                    dataStream.Write(byteArray, 0, byteArray.Length);
                }

                using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
                {
                    using (Stream stream = response.GetResponseStream())
                    {
                        using (StreamReader reader = new StreamReader(stream))
                        {
                            string html, vivod1, vivod2;
                            int start = 106;

                            connect = true;

                            html = reader.ReadToEnd();
                            result = Regex.Replace(html, "<[^>]+>", "\n");
                            //MessageBox.Show(result);

                            vivod1 = result.Substring(start);
                            ProductName = vivod1.Substring(0, vivod1.IndexOf("\n"));
                            //MessageBox.Show(ProductName);

                            vivod2 = vivod1.Substring(ProductName.Length + 1);
                            DescriptionGoods = vivod2.Substring(0, vivod2.IndexOf("$"));
                            //MessageBox.Show(DescriptionGoods);

                            vivod1 = vivod2.Substring(DescriptionGoods.Length + 2);
                            DescriptionGoodsshort = vivod1.Substring(0, vivod1.IndexOf("$"));

                            vivod2 = vivod1.Substring(DescriptionGoodsshort.Length + 2);
                            Price = vivod2.Substring(0, vivod2.IndexOf("\n"));
                            //MessageBox.Show(Price);

                            vivod1 = vivod2.Substring(Price.Length + 1);
                            Kol = vivod1.Substring(0, vivod1.IndexOf("\n"));
                            //MessageBox.Show(Kol);

                            vivod2 = vivod1.Substring(Kol.Length + 1);
                            URL_Photo = vivod2.Substring(0, vivod2.IndexOf("\n"));
                            //MessageBox.Show(URL_Photo);

                            vivod1 = vivod2.Substring(URL_Photo.Length + 1);
                            Data_item = vivod1.Substring(0, vivod1.IndexOf("\n"));
                            //MessageBox.Show(Data_item);

                            vivod2 = vivod1.Substring(Data_item.Length + 1);
                            Chance_to_buy = vivod2.Substring(0, vivod2.IndexOf("\n"));
                            //MessageBox.Show(Chance_to_buy);

                            vivod1 = vivod2.Substring(Chance_to_buy.Length + 1);
                            Adress = vivod1.Substring(0, vivod1.IndexOf("\n"));
                            //MessageBox.Show(Adress);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Отсутствует подключение к серверу, проверьте подключение к интернету", "Подключение к сети", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                connect = false;
            }
        }

        public void KolProductsChance(double chance1, double chance2, string type)
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://xoxol1898.000webhostapp.com/index2.php");


                // устанавливаем тип содержимого - параметр ContentType
                request.ContentType = "application/x-www-form-urlencoded";

                // для отправки используется метод Post
                request.Method = "POST";

                // время ожидания ответа от сервера
                //request.Timeout = 8000;

                CultureInfo temp_culture = Thread.CurrentThread.CurrentCulture;
                Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-US");

                // данные для отправки
                string data = "host=localhost&user=id12516608_admin&pas=moloko123&database=id12516608_baseshop&type=KolProductChance&chance1=" + chance1 + "&chance2=" + chance2 + "&type_product=" + type;
                Thread.CurrentThread.CurrentCulture = temp_culture;

                String result = String.Empty;

                // преобразуем данные в массив байтов
                byte[] byteArray = Encoding.UTF8.GetBytes(data);

                // Устанавливаем заголовок Content-Length запроса - свойство ContentLength
                request.ContentLength = byteArray.Length;

                //записываем данные в поток запроса
                using (Stream dataStream = request.GetRequestStream())
                {
                    dataStream.Write(byteArray, 0, byteArray.Length);
                }

                using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
                {
                    using (Stream stream = response.GetResponseStream())
                    {
                        using (StreamReader reader = new StreamReader(stream))
                        {
                            string html;
                            int start = 106;

                            connect = true;

                            html = reader.ReadToEnd();
                            result = Regex.Replace(html, "<[^>]+>", "\n");
                            //MessageBox.Show(result);

                            str = result.Substring(start);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Отсутствует подключение к серверу, проверьте подключение к интернету", "Подключение к сети", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                connect = false;
            }
        }

        public void AddBasketProduct(int id_Product, uint kol)
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://xoxol1898.000webhostapp.com/index2.php");


                // устанавливаем тип содержимого - параметр ContentType
                request.ContentType = "application/x-www-form-urlencoded";

                // для отправки используется метод Post
                request.Method = "POST";

                // время ожидания ответа от сервера
                //request.Timeout = 6000;

                CultureInfo temp_culture = Thread.CurrentThread.CurrentCulture;
                Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-US");
                // данные для отправки
                string data = "host=localhost&user=id12516608_admin&pas=moloko123&database=id12516608_baseshop&type=AddBasketProduct&id_client=" + Holder.id_client + "&id_product=" + id_Product + "&kol_product=" + kol;
                Thread.CurrentThread.CurrentCulture = temp_culture;

                String result = String.Empty;

                // преобразуем данные в массив байтов
                byte[] byteArray = Encoding.UTF8.GetBytes(data);

                // Устанавливаем заголовок Content-Length запроса - свойство ContentLength
                request.ContentLength = byteArray.Length;

                //записываем данные в поток запроса
                using (Stream dataStream = request.GetRequestStream())
                {
                    dataStream.Write(byteArray, 0, byteArray.Length);
                }

                using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
                {
                    using (Stream stream = response.GetResponseStream())
                    {
                        using (StreamReader reader = new StreamReader(stream))
                        {
                            string html;
                            int start = 106;

                            connect = true;

                            html = reader.ReadToEnd();
                            result = Regex.Replace(html, "<[^>]+>", "\n");
                            string vivod = result.Substring(start);
                            basketOut = vivod.Substring(vivod.Length - 1);
                            vivod = vivod.Substring(0, vivod.Length - 1);


                            MessageBox.Show(vivod);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Отсутствует подключение к серверу, проверьте подключение к интернету", "Подключение к сети", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                connect = false;
            }
        }

        public void UpdateBasketProduct(int id_Product, uint kol)
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://xoxol1898.000webhostapp.com/index2.php");

                // устанавливаем тип содержимого - параметр ContentType
                request.ContentType = "application/x-www-form-urlencoded";

                // для отправки используется метод Post
                request.Method = "POST";

                // время ожидания ответа от сервера
                //request.Timeout = 6000;

                CultureInfo temp_culture = Thread.CurrentThread.CurrentCulture;
                Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-US");

                // данные для отправки
                string data = "host=localhost&user=id12516608_admin&pas=moloko123&database=id12516608_baseshop&type=UpdateBasketProduct&id_client=" + Holder.id_client + "&id_product=" + id_Product + "&kol_product=" + kol;
                Thread.CurrentThread.CurrentCulture = temp_culture;

                String result = String.Empty;

                // преобразуем данные в массив байтов
                byte[] byteArray = Encoding.UTF8.GetBytes(data);

                // Устанавливаем заголовок Content-Length запроса - свойство ContentLength
                request.ContentLength = byteArray.Length;

                //записываем данные в поток запроса
                using (Stream dataStream = request.GetRequestStream())
                {
                    dataStream.Write(byteArray, 0, byteArray.Length);
                }

                using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
                {
                    using (Stream stream = response.GetResponseStream())
                    {
                        using (StreamReader reader = new StreamReader(stream))
                        {
                            string html;
                            int start = 106;

                            connect = true;

                            html = reader.ReadToEnd();
                            result = Regex.Replace(html, "<[^>]+>", "\n");
                            string vivod = result.Substring(start);

                            //MessageBox.Show(vivod);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Отсутствует подключение к серверу, проверьте подключение к интернету", "Подключение к сети", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                connect = false;
            }
        }

        public void DeleteBasketProduct(int id_Product)
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://xoxol1898.000webhostapp.com/index2.php");


                // устанавливаем тип содержимого - параметр ContentType
                request.ContentType = "application/x-www-form-urlencoded";

                // для отправки используется метод Post
                request.Method = "POST";

                // время ожидания ответа от сервера
                //request.Timeout = 6000;

                CultureInfo temp_culture = Thread.CurrentThread.CurrentCulture;
                Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-US");

                // данные для отправки
                string data = "host=localhost&user=id12516608_admin&pas=moloko123&database=id12516608_baseshop&type=DeleteBasketProduct&id_client=" + Holder.id_client + "&id_product=" + id_Product;
                Thread.CurrentThread.CurrentCulture = temp_culture;

                String result = String.Empty;

                // преобразуем данные в массив байтов
                byte[] byteArray = Encoding.UTF8.GetBytes(data);

                // Устанавливаем заголовок Content-Length запроса - свойство ContentLength
                request.ContentLength = byteArray.Length;

                //записываем данные в поток запроса
                using (Stream dataStream = request.GetRequestStream())
                {
                    dataStream.Write(byteArray, 0, byteArray.Length);
                }

                using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
                {
                    using (Stream stream = response.GetResponseStream())
                    {
                        using (StreamReader reader = new StreamReader(stream))
                        {
                            string html;
                            int start = 106;

                            connect = true;

                            html = reader.ReadToEnd();
                            result = Regex.Replace(html, "<[^>]+>", "\n");
                            string vivod = result.Substring(start);

                            //MessageBox.Show(vivod);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Отсутствует подключение к серверу, проверьте подключение к интернету", "Подключение к сети", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                connect = false;
            }
        }

        public void AddOrder(int id_Product, uint kol, string Type_of_payment)
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://xoxol1898.000webhostapp.com/index2.php");

                // устанавливаем тип содержимого - параметр ContentType
                request.ContentType = "application/x-www-form-urlencoded";

                // для отправки используется метод Post
                request.Method = "POST";

                // время ожидания ответа от сервера
                //request.Timeout = 6000;

                CultureInfo temp_culture = Thread.CurrentThread.CurrentCulture;
                Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-US");
                // данные для отправки
                string data = "host=localhost&user=id12516608_admin&pas=moloko123&database=id12516608_baseshop&type=AddOrder&id_client=" + Holder.id_client + "&id_product=" + id_Product + "&kol_product=" + kol + "&type_of_payment=" + Type_of_payment;
                Thread.CurrentThread.CurrentCulture = temp_culture;

                String result = String.Empty;

                // преобразуем данные в массив байтов
                byte[] byteArray = Encoding.UTF8.GetBytes(data);

                // Устанавливаем заголовок Content-Length запроса - свойство ContentLength
                request.ContentLength = byteArray.Length;

                //записываем данные в поток запроса
                using (Stream dataStream = request.GetRequestStream())
                {
                    dataStream.Write(byteArray, 0, byteArray.Length);
                }

                using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
                {
                    using (Stream stream = response.GetResponseStream())
                    {
                        using (StreamReader reader = new StreamReader(stream))
                        {
                            string html;
                            int start = 106;

                            connect = true;

                            html = reader.ReadToEnd();
                            result = Regex.Replace(html, "<[^>]+>", "\n");
                            string vivod = result.Substring(start);

                            MessageBox.Show(vivod);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Отсутствует подключение к серверу, проверьте подключение к интернету", "Подключение к сети", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                connect = false;
            }
        }

        public void LoadBasket()
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://xoxol1898.000webhostapp.com/index2.php");

                // устанавливаем тип содержимого - параметр ContentType
                request.ContentType = "application/x-www-form-urlencoded";

                // для отправки используется метод Post
                request.Method = "POST";

                // время ожидания ответа от сервера
                //request.Timeout = 6000;

                CultureInfo temp_culture = Thread.CurrentThread.CurrentCulture;
                Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-US");
                // данные для отправки
                string data = "host=localhost&user=id12516608_admin&pas=moloko123&database=id12516608_baseshop&type=LoadBasket&id_client=" + Holder.id_client;
                Thread.CurrentThread.CurrentCulture = temp_culture;

                String result = String.Empty;

                // преобразуем данные в массив байтов
                byte[] byteArray = Encoding.UTF8.GetBytes(data);

                // Устанавливаем заголовок Content-Length запроса - свойство ContentLength
                request.ContentLength = byteArray.Length;

                //записываем данные в поток запроса
                using (Stream dataStream = request.GetRequestStream())
                {
                    dataStream.Write(byteArray, 0, byteArray.Length);
                }

                using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
                {
                    using (Stream stream = response.GetResponseStream())
                    {
                        using (StreamReader reader = new StreamReader(stream))
                        {
                            string html;
                            int start = 106;

                            connect = true;

                            html = reader.ReadToEnd();
                            result = Regex.Replace(html, "<[^>]+>", "\n");
                            string vivod = result.Substring(start);

                            //MessageBox.Show(vivod);

                            str = result.Substring(start);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Отсутствует подключение к серверу, проверьте подключение к интернету", "Подключение к сети", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                connect = false;
            }
        }

        public void InfoClient()
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://xoxol1898.000webhostapp.com/index2.php");


                // устанавливаем тип содержимого - параметр ContentType
                request.ContentType = "application/x-www-form-urlencoded";

                // для отправки используется метод Post
                request.Method = "POST";

                // время ожидания ответа от сервера
                //request.Timeout = 6000;

                CultureInfo temp_culture = Thread.CurrentThread.CurrentCulture;
                Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-US");
                // данные для отправки
                string data = "host=localhost&user=id12516608_admin&pas=moloko123&database=id12516608_baseshop&type=InfoClient&id_client=" + Holder.id_client;
                Thread.CurrentThread.CurrentCulture = temp_culture;

                String result = String.Empty;

                // преобразуем данные в массив байтов
                byte[] byteArray = Encoding.UTF8.GetBytes(data);

                // Устанавливаем заголовок Content-Length запроса - свойство ContentLength
                request.ContentLength = byteArray.Length;

                //записываем данные в поток запроса
                using (Stream dataStream = request.GetRequestStream())
                {
                    dataStream.Write(byteArray, 0, byteArray.Length);
                }

                using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
                {
                    using (Stream stream = response.GetResponseStream())
                    {
                        using (StreamReader reader = new StreamReader(stream))
                        {
                            string html, vivod1, vivod2;
                            int start = 106;

                            connect = true;

                            html = reader.ReadToEnd();
                            result = Regex.Replace(html, "<[^>]+>", "\n");

                            //MessageBox.Show(result);

                            vivod1 = result.Substring(start);
                            First_Name = vivod1.Substring(0, vivod1.IndexOf("\n"));

                            vivod2 = vivod1.Substring(First_Name.Length + 1);
                            Surname = vivod2.Substring(0, vivod2.IndexOf("\n"));

                            vivod1 = vivod2.Substring(Surname.Length + 1);
                            Login = vivod1.Substring(0, vivod1.IndexOf("\n"));

                            vivod2 = vivod1.Substring(Login.Length + 1);
                            Password = vivod2.Substring(0, vivod2.IndexOf("\n"));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Отсутствует подключение к серверу, проверьте подключение к интернету", "Подключение к сети", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                connect = false;
            }
        }

        public void EditClient(string Name, string Surname, string Login, string Password)
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://xoxol1898.000webhostapp.com/index2.php");

                // устанавливаем тип содержимого - параметр ContentType
                request.ContentType = "application/x-www-form-urlencoded";

                // для отправки используется метод Post
                request.Method = "POST";

                // время ожидания ответа от сервера
                //request.Timeout = 6000;

                CultureInfo temp_culture = Thread.CurrentThread.CurrentCulture;
                Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-US");
                // данные для отправки
                string data = "host=localhost&user=id12516608_admin&pas=moloko123&database=id12516608_baseshop&type=EditClient&id_client=" + Holder.id_client + "&name=" + Name + "&surname=" + Surname + "&login=" + Login + "&password=" + Password;
                Thread.CurrentThread.CurrentCulture = temp_culture;

                String result = String.Empty;

                // преобразуем данные в массив байтов
                byte[] byteArray = Encoding.UTF8.GetBytes(data);

                // Устанавливаем заголовок Content-Length запроса - свойство ContentLength
                request.ContentLength = byteArray.Length;

                //записываем данные в поток запроса
                using (Stream dataStream = request.GetRequestStream())
                {
                    dataStream.Write(byteArray, 0, byteArray.Length);
                }

                using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
                {
                    using (Stream stream = response.GetResponseStream())
                    {
                        using (StreamReader reader = new StreamReader(stream))
                        {
                            string html, vivod;
                            int start = 106;

                            connect = true;

                            html = reader.ReadToEnd();
                            result = Regex.Replace(html, "<[^>]+>", "\n");

                            vivod = result.Substring(start);
                            if (vivod == "Invalid query0: Duplicate entry '" + Login + "' for key 'Login_client'")
                            {
                                MessageBox.Show("Извините, но такой Email уже занят");
                                edit = false;
                            }
                            else
                            {
                                MessageBox.Show(vivod);
                                edit = true;
                            }

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Отсутствует подключение к серверу, проверьте подключение к интернету", "Подключение к сети", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                connect = false;
            }
        }

        public void LoadOrders()
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://xoxol1898.000webhostapp.com/index2.php");

                // устанавливаем тип содержимого - параметр ContentType
                request.ContentType = "application/x-www-form-urlencoded";

                // для отправки используется метод Post
                request.Method = "POST";

                // время ожидания ответа от сервера
                //request.Timeout = 7000;

                CultureInfo temp_culture = Thread.CurrentThread.CurrentCulture;
                Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-US");
                // данные для отправки
                string data = "host=localhost&user=id12516608_admin&pas=moloko123&database=id12516608_baseshop&type=LoadOrders&id_client=" + Holder.id_client;
                Thread.CurrentThread.CurrentCulture = temp_culture;

                String result = String.Empty;

                // преобразуем данные в массив байтов
                byte[] byteArray = Encoding.UTF8.GetBytes(data);

                // Устанавливаем заголовок Content-Length запроса - свойство ContentLength
                request.ContentLength = byteArray.Length;

                //записываем данные в поток запроса
                using (Stream dataStream = request.GetRequestStream())
                {
                    dataStream.Write(byteArray, 0, byteArray.Length);
                }

                using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
                {
                    using (Stream stream = response.GetResponseStream())
                    {
                        using (StreamReader reader = new StreamReader(stream))
                        {
                            string html, vivod1, vivod2;
                            int start = 106;

                            connect = true;

                            html = reader.ReadToEnd();
                            result = Regex.Replace(html, "<[^>]+>", "\n");
                            string vivod = result.Substring(start);

                            //MessageBox.Show(vivod);

                            str = result.Substring(start);

                            vivod2 = result.Substring(start);
                            idOrders = vivod2.Substring(0, vivod2.IndexOf("\n"));
                            //MessageBox.Show(idOrders);

                            vivod1 = vivod2.Substring(idOrders.Length + 1);
                            NameSurnameUsers = vivod1.Substring(0, vivod1.IndexOf("\n"));
                            //MessageBox.Show(NameSurnameUsers);

                            vivod2 = vivod1.Substring(NameSurnameUsers.Length + 1);
                            NumerOrders = vivod2.Substring(0, vivod2.IndexOf("\n"));
                            //MessageBox.Show(NumerOrders);

                            vivod1 = vivod2.Substring(NumerOrders.Length + 1);
                            NameProducts = vivod1.Substring(0, vivod1.IndexOf("\n"));
                            //MessageBox.Show(NameProducts);

                            vivod2 = vivod1.Substring(NameProducts.Length + 1);
                            CountProducts = vivod2.Substring(0, vivod2.IndexOf("\n"));
                            //MessageBox.Show(CountOrders);

                            vivod1 = vivod2.Substring(CountProducts.Length + 1);
                            DateOrders = vivod1.Substring(0, vivod1.IndexOf("\n"));
                            //MessageBox.Show(TypeOfPayments);

                            vivod2 = vivod1.Substring(DateOrders.Length + 1);
                            TypeOfPayments = vivod2.Substring(0, vivod2.IndexOf("\n"));
                            //MessageBox.Show(TypeOfPayments);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Отсутствует подключение к серверу, проверьте подключение к интернету", "Подключение к сети", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                connect = false;
            }
        }

        public void DeleteOrder(int idOrder)
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://xoxol1898.000webhostapp.com/index2.php");

                // устанавливаем тип содержимого - параметр ContentType
                request.ContentType = "application/x-www-form-urlencoded";

                // для отправки используется метод Post
                request.Method = "POST";

                // время ожидания ответа от сервера
                //request.Timeout = 6000;

                CultureInfo temp_culture = Thread.CurrentThread.CurrentCulture;
                Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-US");
                // данные для отправки
                string data = "host=localhost&user=id12516608_admin&pas=moloko123&database=id12516608_baseshop&type=DeleteOrder&id_client=" + Holder.id_client + "&id_order=" + idOrder;
                Thread.CurrentThread.CurrentCulture = temp_culture;

                String result = String.Empty;

                // преобразуем данные в массив байтов
                byte[] byteArray = Encoding.UTF8.GetBytes(data);

                // Устанавливаем заголовок Content-Length запроса - свойство ContentLength
                request.ContentLength = byteArray.Length;

                //записываем данные в поток запроса
                using (Stream dataStream = request.GetRequestStream())
                {
                    dataStream.Write(byteArray, 0, byteArray.Length);
                }

                using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
                {
                    using (Stream stream = response.GetResponseStream())
                    {
                        using (StreamReader reader = new StreamReader(stream))
                        {
                            string html, vivod;
                            int start = 106;

                            connect = true;

                            html = reader.ReadToEnd();
                            result = Regex.Replace(html, "<[^>]+>", "\n");

                            vivod = result.Substring(start);
                            //MessageBox.Show(vivod);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Отсутствует подключение к серверу, проверьте подключение к интернету", "Подключение к сети", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                connect = false;
            }
        }

        public async Task LoadProductsAsync(int id)
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://xoxol1898.000webhostapp.com/index2.php");

                // устанавливаем тип содержимого - параметр ContentType
                request.ContentType = "application/x-www-form-urlencoded";

                // для отправки используется метод Post
                request.Method = "POST";

                // время ожидания ответа от сервера
                //request.Timeout = 8000;

                // данные для отправки
                string data = "host=localhost&user=id12516608_admin&pas=moloko123&database=id12516608_baseshop&type=LoadProduct&id=" + id;

                String result = String.Empty;

                // преобразуем данные в массив байтов
                byte[] byteArray = System.Text.Encoding.UTF8.GetBytes(data);

                // Устанавливаем заголовок Content-Length запроса - свойство ContentLength
                request.ContentLength = byteArray.Length;


                //записываем данные в поток запроса
                using (Stream dataStream = request.GetRequestStream())
                {
                    dataStream.Write(byteArray, 0, byteArray.Length);
                }

                using (HttpWebResponse response = await request.GetResponseAsync() as HttpWebResponse)
                {
                    using (Stream stream = response.GetResponseStream())
                    {
                        using (StreamReader reader = new StreamReader(stream))
                        {
                            string html, vivod1, vivod2;
                            int start = 106;

                            connect = true;

                            html = reader.ReadToEnd();
                            result = Regex.Replace(html, "<[^>]+>", "\n");
                            //MessageBox.Show(result);

                            vivod1 = result.Substring(start);
                            ProductName = vivod1.Substring(0, vivod1.IndexOf("\n"));
                            //MessageBox.Show(ProductName);

                            vivod2 = vivod1.Substring(ProductName.Length + 1);
                            DescriptionGoods = vivod2.Substring(0, vivod2.IndexOf("$"));
                            //MessageBox.Show(DescriptionGoods);

                            vivod1 = vivod2.Substring(DescriptionGoods.Length + 2);
                            DescriptionGoodsshort = vivod1.Substring(0, vivod1.IndexOf("$"));

                            vivod2 = vivod1.Substring(DescriptionGoodsshort.Length + 2);
                            Price = vivod2.Substring(0, vivod2.IndexOf("\n"));
                            //MessageBox.Show(Price);

                            vivod1 = vivod2.Substring(Price.Length + 1);
                            Kol = vivod1.Substring(0, vivod1.IndexOf("\n"));
                            //MessageBox.Show(Kol);

                            vivod2 = vivod1.Substring(Kol.Length + 1);
                            URL_Photo = vivod2.Substring(0, vivod2.IndexOf("\n"));
                            //MessageBox.Show(URL_Photo);

                            vivod1 = vivod2.Substring(URL_Photo.Length + 1);
                            Data_item = vivod1.Substring(0, vivod1.IndexOf("\n"));
                            //MessageBox.Show(Data_item);

                            vivod2 = vivod1.Substring(Data_item.Length + 1);
                            Chance_to_buy = vivod2.Substring(0, vivod2.IndexOf("\n"));
                            //MessageBox.Show(Chance_to_buy);

                            vivod1 = vivod2.Substring(Chance_to_buy.Length + 1);
                            Adress = vivod1.Substring(0, vivod1.IndexOf("\n"));
                            //MessageBox.Show(Adress);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Отсутствует подключение к серверу, проверьте подключение к интернету", "Подключение к сети", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                connect = false;
            }
        }

        public void KolProducts()
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://xoxol1898.000webhostapp.com/index2.php");

                // устанавливаем тип содержимого - параметр ContentType
                request.ContentType = "application/x-www-form-urlencoded";

                // для отправки используется метод Post
                request.Method = "POST";

                // время ожидания ответа от сервера
                //request.Timeout = 8000;

                // данные для отправки
                string data = "host=localhost&user=id12516608_admin&pas=moloko123&database=id12516608_baseshop&type=KolProduct";

                String result = String.Empty;

                // преобразуем данные в массив байтов
                byte[] byteArray = System.Text.Encoding.UTF8.GetBytes(data);

                // Устанавливаем заголовок Content-Length запроса - свойство ContentLength
                request.ContentLength = byteArray.Length;

                //записываем данные в поток запроса
                using (Stream dataStream = request.GetRequestStream())
                {
                    dataStream.Write(byteArray, 0, byteArray.Length);
                }

                using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
                {
                    using (Stream stream = response.GetResponseStream())
                    {
                        using (StreamReader reader = new StreamReader(stream))
                        {
                            string html;
                            int start = 106;

                            connect = true;

                            html = reader.ReadToEnd();
                            result = Regex.Replace(html, "<[^>]+>", "\n");
                            //MessageBox.Show(result);

                            str = result.Substring(start);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Отсутствует подключение к серверу, проверьте подключение к интернету", "Подключение к сети", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                connect = false;
            }
        }

    }
}
