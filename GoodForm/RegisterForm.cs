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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();

            // инициализация ввода имени
            initName();

            userNameField.Text = "Введите Имя";
            userNameField.ForeColor = Color.Gray;

            userSurnameField.Text = "Введите Фамилию";
            userSurnameField.ForeColor = Color.Gray;

            loginField.Text = "Введите email";
            loginField.ForeColor = Color.Gray;
        }

        private void initName()
        {
            AutoCompleteStringCollection source = new AutoCompleteStringCollection() 
            { 
                // межские имена
                "Абрам",
                "Аваз",
                "Август",
                "Авдей",
                "Автандил",
                "Адам",
                "Адис",
                "Адольф",
                "Адриан",
                "Азарий",
                "Аким",
                "Алан",
                "Александр",
                "Алексей",
                "Альберт",
                "Альфред",
                "Амадей",
                "Амадеус",
                "Амаяк",
                "Анатолий",
                "Ангел",
                "Андоим",
                "Андрей",
                "Аникита",
                "Антон",
                "Ануфрий",
                "Арам",
                "Арий",
                "Аристарх",
                "Аркадий",
                "Арно",
                "Арнольд",
                "Арон",
                "Арсен",
                "Арсений",
                "Артем",
                "Артемий",
                "Артур",
                "Архип",
                "Аскольд",
                "Афанасий",
                "Ахмет",
                "Ашот",
                "Бежен",
                "Бенедикт",
                "Берек",
                "Бернар",
                "Богдан",
                "Боголюб",
                "Болеслав",
                "Бонифаций",
                "Борис",
                "Борислав",
                "Боян",
                "Бронислав",
                "Бруно",
                "Вадим",
                "Валентин",
                "Валерий",
                "Вальтер",
                "Василий",
                "Велизар",
                "Венедикт",
                "Вениамин",
                "Виктор",
                "Вилен",
                "Вилли",
                "Вильгельм",
                "Виссарион",
                "Виталий",
                "Витаутас",
                "Витольд",
                "Владимир",
                "Владислав",
                "Владлен",
                "Володар",
                "Вольдемар",
                "Всеволод",
                "Вячеслав",
                "Гавриил",
                "Гарри",
                "Гастон",
                "Геннадий",
                "Генрих",
                "Георгий",
                "Геральд",
                "Герасим",
                "Герман",
                "Глеб",
                "Гордей",
                "Гордон",
                "Градимир",
                "Григорий",
                "Гурий",
                "Давид",
                "Даниил",
                "Демид",
                "Демьян",
                "Денис",
                "Джордан",
                "Дмитрий",
                "Дональд",
                "Донат",
                "Донатос",
                "Дорофей",
                "Евгений",
                "Евграф",
                "Евдоким",
                "Евстафий",
                "Егор",
                "Елизар",
                "Елисей",
                "Емельян",
                "Ермолай",
                "Ерофей",
                "Ефим",
                "Ефимий",
                "Ефрем",
                "Жан",
                "Ждан",
                "Жорж",
                "Захар",
                "Захария",
                "Зигмунд",
                "Зиновий",
                "Ибрагим",
                "Иван",
                "Игнат",
                "Игорь",
                "Измаил",
                "Израиль",
                "Илиан",
                "Илларион",
                "Илья",
                "Иннокентий",
                "Ион",
                "Ионос",
                "Иосиф",
                "Ираклий",
                "Иржи",
                "Исай",
                "Казимир",
                "Карен",
                "Карл",
                "Ким",
                "Кирилл",
                "Клавдий",
                "Клемент",
                "Клим",
                "Клод",
                "Кондрат",
                "Конкордий",
                "Константин",
                "Кузьма",
                "Лазарь",
                "Лев",
                "Леван",
                "Леонард",
                "Леонид",
                "Леонтий",
                "Леопольд",
                "Лука",
                "Любомир",
                "Людвиг",
                "Люсьен",
                "Мадлен",
                "Май",
                "Макар",
                "Максим",
                "Максимилиан",
                "Мануил",
                "Марат",
                "Мариан",
                "Марк",
                "Мартин",
                "Матвей",
                "Мераб",
                "Мечеслав",
                "Милан",
                "Мирон",
                "Мирослав",
                "Михаил",
                "Мичлов",
                "Модест",
                "Моисей",
                "Мурат",
                "Муслим",
                "Назар",
                "Назарий",
                "Натан",
                "Наум",
                "Никита",
                "Никифор",
                "Николай",
                "Никон",
                "Нисон",
                "Нифонт",
                "Олан",
                "Олег",
                "Олесь",
                "Онисим",
                "Орест",
                "Осип",
                "Оскар",
                "Павел",
                "Парамон",
                "Петр",
                "Платон",
                "Порфирий",
                "Прохор",
                "Равиль",
                "Радий",
                "Радомир",
                "Раис",
                "Раймонд",
                "Ратмир",
                "Рафаил",
                "Рафик",
                "Рашид",
                "Рем",
                "Ренольд",
                "Ринат",
                "Рифат",
                "Ричард",
                "Роберт",
                "Родион",
                "Ролан",
                "Роман",
                "Ростислав",
                "Рубен",
                "Рудольф",
                "Руслан",
                "Рустам",
                "Савва",
                "Савел",
                "Самсон",
                "Святослав",
                "Севастьян",
                "Северин",
                "Семен",
                "Серафим",
                "Сергей",
                "Сократ",
                "Соломон",
                "Спартак",
                "Стакрат",
                "Станислав",
                "Степан",
                "Стивен",
                "Стоян",
                "Таис",
                "Талик",
                "Тамаз",
                "Тарас",
                "Тельман",
                "Теодор",
                "Терентий",
                "Тибор",
                "Тигран",
                "Тигрий",
                "Тимофей",
                "Тимур",
                "Тит",
                "Тихон",
                "Трифон",
                "Трофим",
                "Ульманас",
                "Устин",
                "Фаддей",
                "Федор",
                "Феликс",
                "Феодосий",
                "Фидель",
                "Филимон",
                "Филипп",
                "Флорентий",
                "Фома",
                "Франц",
                "Фридрих",
                "Харитон",
                "Христиан",
                "Христос",
                "Христофор",
                "Эдвард",
                "Эдуард",
                "Эльдар",
                "Эмиль",
                "Эммануил",
                "Эраст",
                "Эрик",
                "Эрнест",
                "Юлиан",
                "Юрий",
                "Юхим",
                "Яким",
                "Яков",
                "Ян",
                "Яромир",
                "Ярослав",
                "Ясон",

                //женские имена
                "Августа",
                "Аврора",
                "Агата",
                "Агнесса",
                "Агния",
                "Ада",
                "Адель",
                "Аза",
                "Азиза",
                "Аида",
                "Алана",
                "Алевтина",
                "Александра",
                "Алико",
                "Алина",
                "Алиса",
                "Алла",
                "Альберта",
                "Альбина",
                "Альжбета",
                "Амелия",
                "Амина",
                "Анастасия",
                "Ангелина",
                "Анжела",
                "Анисья",
                "Анита",
                "Анна",
                "Антонина",
                "Анфиса",
                "Анэля",
                "Ариадна",
                "Арина",
                "Архелия",
                "Астра",
                "Ася, уменьш. от Аста",
                "Аурелия",
                "Беатриса, Беата",
                "Белла",
                "Береслава",
                "Берта",
                "Биргит",
                "Богдана",
                "Божена",
                "Борислава",
                "Бронислава",
                "Валентина",
                "Валерия",
                "Ванда",
                "Варвара",
                "Василиса",
                "Венера",
                "Вера",
                "Вероника",
                "Веселина",
                "Веста",
                "Вета",
                "Вида",
                "Виктория",
                "Вилора",
                "Виолетта",
                "Виргиния",
                "Виталина",
                "Владислава",
                "Галина",
                "Гаянэ",
                "Гелена",
                "Гелла",
                "Генриетта",
                "Георгина",
                "Гера",
                "Гертруда",
                "Глафира",
                "Глория",
                "Гражина",
                "Грета",
                "Гюзель",
                "Дайна",
                "Дана",
                "Даниэла",
                "Данута",
                "Дарина",
                "Дарья",
                "Дебора",
                "Джемма",
                "Джулия",
                "Джульетта",
                "Диана",
                "Дина",
                "Динара",
                "Диодора",
                "Дионисия",
                "Доля",
                "Доминика",
                "Ева",
                "Евгения",
                "Евдокия",
                "Екатерина",
                "Елена",
                "Елизавета",
                "Жанна",
                "Зара",
                "Земфира",
                "Зинаида",
                "Злата",
                "Зоя",
                "Иветта",
                "Ивона",
                "Изабелла",
                "Изольда",
                "Илзе",
                "Инара",
                "Инга",
                "Инесса",
                "Инна",
                "Иоанна",
                "Иоланта",
                "Ираида",
                "Ирина",
                "Ольга",
                "Сабина",
                "Санта",
                "Сарра",
                "Светлана",
                "Северина",
                "Серафима",
                "Сильва",
                "Сима",
                "Симона",
                "Снежана",
                "Софья",
                "Станислава",
                "Стелла",
                "Стефания",
                "Сусанна",
                "Таира",
                "Таисия",
                "Тала",
                "Тамара",
                "Татьяна",
                "Тереза",
                "Томила",
                "Ульяна",
                "Устина",
                "Фаиза",
                "Фаина",
                "Фаня, Фанни",
                "Фая",
                "Фелиция",
                "Флора",
                "Франсуаза",
                "Фрида",
                "Хильда",
                "Христина",
                "Христя",
                "Цветана",
                "Чеслава",
                "Эдда",
                "Эдита",
                "Элеонора",
                "Элина",
                "Элла",
                "Эллада",
                "Элоиза",
                "Эльвира",
                "Эльга",
                "Эльза",
                "Эльмира",
                "Эмилия",
                "Эмма",
                "Эрика",
                "Эсмеральда",
                "Юзефа",
                "Юлия",
                "Юна",
                "Юнона",
                "Юстина",
                "Ядвига",
                "Яна, Янина",
                "Янита",
                "Янка",
                "Ярослава"
            };

            userNameField.AutoCompleteCustomSource = source;
            userNameField.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            userNameField.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        // обработчик кнопки выключения
        private void CloseReg_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // обработчик цвета выделения
        private void CloseReg_MouseEnter(object sender, EventArgs e)
        {
            CloseReg.ForeColor = Color.DarkGreen;
        }

        // обработчик цвета выделения
        private void CloseReg_MouseLeave(object sender, EventArgs e)
        {
            CloseReg.ForeColor = Color.White;
        }

        Point lastPoint;

        // обработчик перемещения формы
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
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

        // обработчик замещения текста при вводе имени
        private void userNameField_Enter(object sender, EventArgs e)
        {
            if (userNameField.Text == "Введите Имя")
            {
                userNameField.Text = "";
                userNameField.ForeColor = Color.Black;
            }
        }

        // обработчик замещения текста при вводе имени
        private void userNameField_Leave(object sender, EventArgs e)
        {
            if (userNameField.Text == "")
            {
                userNameField.Text = "Введите Имя";
                userNameField.ForeColor = Color.Gray;
            }
        }

        // обработчик замещения текста при вводе фамилии
        private void userSurnameField_Enter(object sender, EventArgs e)
        {
            if (userSurnameField.Text == "Введите Фамилию")
            {
                userSurnameField.Text = "";
                userSurnameField.ForeColor = Color.Black;
            }
        }

        // обработчик замещения текста при вводе фамилии
        private void userSurnameField_Leave(object sender, EventArgs e)
        {
            if (userSurnameField.Text == "")
            {
                userSurnameField.Text = "Введите Фамилию";
                userSurnameField.ForeColor = Color.Gray;
            }
        }

        // обработчик замещения текста при вводе Email
        private void loginField_Enter(object sender, EventArgs e)
        {
            if (loginField.Text == "Введите email")
            {
                loginField.Text = "";
                loginField.ForeColor = Color.Black;
            }
        }

        // обработчик замещения текста при вводе Email
        private void loginField_Leave(object sender, EventArgs e)
        {
            if (loginField.Text == "")
            {
                loginField.Text = "Введите email";
                loginField.ForeColor = Color.Gray;
            }
        }

        // обработчик нажатия клавиши регистраиции
        private void buttonRegister_Click(object sender, EventArgs e)
        {
            // регулярные выражения для всех полей
            string patternName = @"^([А-Я]{1}[а-яё]{1,23}|[A-Z]{1}[a-z]{1,23})$";
            string patternSurname = patternName;
            string patternLogin = @"^([a-z0-9_-]+\.)*[a-z0-9_-]+@[a-z0-9_-]+(\.[a-z0-9_-]+)*\.[a-z]{2,6}$";

            Regex regexName = new Regex(patternName);
            MatchCollection matchesName = regexName.Matches(userNameField.Text);

            // проверки на регулярки и на пустоты
            if ((userNameField.Text != "") && (userNameField.Text != "Введите Имя") && (matchesName.Count > 0))
            {

                Regex regexSurname = new Regex(patternSurname);
                MatchCollection matchesSurname = regexSurname.Matches(userSurnameField.Text);

                if ((userSurnameField.Text != "") && (userSurnameField.Text != "Введите Фамилию") && (matchesSurname.Count > 0))
                {
                    Regex regexLogin = new Regex(patternLogin);
                    MatchCollection matchesLogin = regexLogin.Matches(loginField.Text);

                    if ((loginField.Text != "") && (loginField.Text != "Введите email") && (matchesLogin.Count > 0))
                    {
                        if ((passField.Text != "") && (passField.TextLength >= 8))
                        {
                            // запрос к серверу на регистрацию нового пользователя
                            Functions functions = new Functions();
                            functions.RegisterClient(userNameField.Text, userSurnameField.Text, loginField.Text, passField.Text, this);

                        } else if (passField.Text == "")
                        {
                            MessageBox.Show("Введите пароль!");
                        }
                        else if (passField.TextLength < 8)
                        {
                            MessageBox.Show("Длина пароля должна составлять не менее 8 символов!");
                        }


                    } else if (loginField.Text == "" || loginField.Text == "Введите email")
                    {
                        MessageBox.Show("Введите email!");
                    }
                    else if (matchesLogin.Count == 0)
                    {
                        MessageBox.Show("Некорректный формат email! Принимается формат типа: ****@mail.ru");
                    } 


                } else if (userSurnameField.Text == "" || userSurnameField.Text == "Введите Фамилию")
                {
                    MessageBox.Show("Введите Фамилию!");
                }
                else if (matchesSurname.Count == 0)
                {
                    MessageBox.Show("Некорректный формат Фамилии! Принимаются начиная с большой буквы Рус/Англ");
                }


            } else if (userNameField.Text == "" || userNameField.Text == "Введите Имя") 
            {
                MessageBox.Show("Введите Имя!");
            } 
            else if (matchesName.Count == 0)
            {
                MessageBox.Show("Некорректный формат Имени! Принимаются начиная с большой буквы Рус/Англ");
            }

        }

        // обработчик нажатия label для авторизации
        private void RegisterLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        // обработчик наводки на label авторизации
        private void RegisterLabel_MouseEnter(object sender, EventArgs e)
        {
            RegisterLabel.ForeColor = Color.DarkGreen;
        }

        // обработчик наводки на label авторизации
        private void RegisterLabel_MouseLeave(object sender, EventArgs e)
        {
            RegisterLabel.ForeColor = Color.White;
        }

        // обработчик нажатия на label свертки окна
        private void RollLabelReg_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // обработчик наводки на label свертки окна
        private void RollLabelReg_MouseEnter(object sender, EventArgs e)
        {
            RollLabelReg.ForeColor = Color.DarkGreen;
        }

        // обработчик наводки на label свертки окна
        private void RollLabelReg_MouseLeave(object sender, EventArgs e)
        {
            RollLabelReg.ForeColor = Color.White;
        }
    }
}
