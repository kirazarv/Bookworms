using bookwormsWpf.View;
using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace bookwormsWpf
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    
    ///создание класа MainWindow от родительского класса Window
    public partial class MainWindow : Window
    {
        int balance;
        public MainWindow()
        {
            InitializeComponent();
            this.Left = 400;
            this.Top = 200;
            //создание объекта подключения к БД
            try
            {
                App.DB = new Entity.BookwormsEntities();
            }
            catch
            {
                MessageBox.Show("Ошибка связи с БД");
                App.Current.Shutdown();
            }
        }

        private void butCatalogue_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("The сatalogue is currently in development ");
            View.Catalogue catalogue= new View.Catalogue();
            this.Hide();
            catalogue.ShowDialog();
            this.ShowDialog();
        }

        private void butNav_Click(object sender, RoutedEventArgs e)
        {
            //закрыть все окна, кроме главного
            foreach (Window window in App.Current.Windows)
            {
                if (!(window is MainWindow))	
                    window.Close();             
            }
            //теперь закрыть главное
            this.Close();
        }

        private void butAdmin_Click(object sender, RoutedEventArgs e)
        {
            //папка View. классНовОкна Authorise  объектНовОкна authorise = конструктор класса окна(без параметров)
            //для создания объекта класса выделяется память с помощью операции new для класса

            View.Authorise authorise = new View.Authorise();

            //прячем окно Main
            this.Hide();
            //открываем окно Authorise модально
            authorise.ShowDialog();

            //чтобы главное окно открылось снова после выхода из окна Authorise
            this.ShowDialog();

        }

        /// <summary>
        /// butOrder_Click для события перехода в окно CartWindow
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butOrder_Click(object sender, RoutedEventArgs e)
        {
            Random randint=new Random();
            balance=randint.Next(1500,11000);
            //передаем значение balance в окно CartWindow в параметрах конструктора окна CartWindow
            View.CartWindow cartwindow= new View.CartWindow(balance);
            this.Hide();
            cartwindow.ShowDialog();
            //чтобы главное окно открылось снова после выхода из окна CartWindow
            this.ShowDialog();
        }
    }
}
