using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Media.TextFormatting;
using System.Windows.Shapes;

namespace bookwormsWpf.View
{
    /// <summary>
    /// Логика взаимодействия для Authorise.xaml
    /// </summary>
    public partial class Authorise : Window
    {
        int count = 3;
        //string logininTB;
        //string passwordinPb;
        public Authorise()
        {
            InitializeComponent();
            this.Left = 400;
            this.Top = 200;
        }


        private void fromAuthorisetoMain_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void loginTextbox_TextChanged(object sender, TextChangedEventArgs e)
        {
            //введенное пользователем значение логина сохраняем в переменную logininTB
            //logininTB = loginTextbox.Text;
        }

        private void passwordPb_PasswordChanged(object sender, RoutedEventArgs e)
        {
           
        }


        private void loginButton_Click(object sender, RoutedEventArgs e)
        {
            string login = loginTextbox.Text;
            string password = passwordPb.Password;

            //получить всех пользователей
            List<Entity.User> users = App.DB.User.ToList();
            //фильтрация списка
            Entity.User userSearch = null;//пока локальной перем-й userSearch присвоим 0
            foreach (Entity.User item in users) 
            { 
            if(item.UserLogin == login && item.UserPassword==password) 
                {
                userSearch= item;
                    break;
                }
            }

            /*//фильтрация методом Where
            Entity.User userSearch=users.Where(u=>u.UserLogin == login && u.UserPassword==password).FirstOrDefault();*/

            /*//фильтрация sql-запросами
            string sql = $"SELECT*FROM[User] WHERE[User].UserLogin='{login}'AND[User].UserPassword='{password}'";
            Entity.User userSearch=App.DB.User.SqlQuery(sql).ToList().FirstOrDefault();*/

            /*//фильтрация операторами LINQ
            Entity.User userSearch =(from u in App.DB.User where u.UserLogin==login && 
                                                u.UserPassword==password select u).FirstOrDefault();*/
            

            if (userSearch != null)
            {
                MessageBox.Show("Вы успешно зашли как админ");
                View.WindowAdmin windowAdmin = new View.WindowAdmin();
                this.Close();
                windowAdmin.ShowDialog();
            }
            else
            {
                count--;
                if(count == 0)
                {
                    MessageBox.Show("Все попытки исчерпаны");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Неудачная попытка входа. \r\n У Вас осталось " + count + " попыток");
                }
            }

            //верный код для проверки пароля с помощью считывания из файла
            /*string path = Environment.CurrentDirectory + @"\adminLogin.txt";
            logininTB = loginTextbox.Text;
            passwordinPb = passwordPb.Password;
            string[] arrLP;
            using (StreamReader sr = new StreamReader(path))
            {
                string text = sr.ReadToEnd();
                //сохранить каждое слово текста в массив
                arrLP = text.Split(new string[] { ":" }, StringSplitOptions.RemoveEmptyEntries);
                //Console.WriteLine(arrLP[0] + arrLP[1]);
                if (arrLP[0] == logininTB && arrLP[1] == passwordinPb)
                {
                    View.WindowAdmin windowAdmin = new View.WindowAdmin();
                    this.Close();
                    windowAdmin.ShowDialog();
                }
                else
                {
                    MessageBox.Show("You have entered a wrong login or password");
                }

            }*/

            //получить всех пользователей???       

            //App.LogPass() (ref App.xaml.css line 21)
            //App.LogPass();
            //if (loginTextbox.Text==App.Login && passwordPb.Password==App.Password)
            //{
            //    View.WindowAdmin windowAdmin = new View.WindowAdmin();
            //    this.Close();
            //    windowAdmin.ShowDialog();
            //}
            //else
            //{
            //    MessageBox.Show("You have entered a wrong login or password");
            //}
        }
    }
}
