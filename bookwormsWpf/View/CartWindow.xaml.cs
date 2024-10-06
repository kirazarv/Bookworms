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
using System.Windows.Shapes;

namespace bookwormsWpf.View
{
    /// <summary>
    /// Логика взаимодействия для CartWindow.xaml
    /// </summary>
    public partial class CartWindow : Window
    {
        int balanceinCartWindow;
        //делаем totalprice public-величиной, чтобы окно-потомок(окно Order) могло видеть эту величину.
        public int totalprice;
        public int remainingBalance;
        public CartWindow(int balance)
        {
            InitializeComponent();
            this.Left = 400;
            this.Top = 200;
            this.balanceinCartWindow=balance;
            balanceTB.Text = $"The balance on the card: {balanceinCartWindow} roubles ";
        }

        private void fromCarttoMain_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void fromCarttoOrder_Click(object sender, RoutedEventArgs e)
        {
            Random randint= new Random();
            totalprice = randint.Next(1500, 11000);
            remainingBalance = balanceinCartWindow - totalprice;
            View.Order order= new View.Order();
            //указываем что родителем-владельцем окна owner является текущее окно CartWindow
            order.Owner= this;
            this.Hide();
            order.ShowDialog();
            //возвращаемся в окно CartWindow после закрытия дочернего окна Order
            this.ShowDialog();
        }
    }
}
