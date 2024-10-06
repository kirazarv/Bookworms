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
    /// Логика взаимодействия для Order.xaml
    /// </summary>
    public partial class Order : Window
    {
        public Order()
        {
           
            InitializeComponent();
           
        }
        
        //как перейти из 3го окна в главное? 
        private void fromOrdertoMain_Click(object sender, RoutedEventArgs e)
        {

            // закрыть все окна, кроме главного//ПРОБЛЕМА-не переходит в главное,но в главном окне есть
            // функция this.ShowDialog которая закрывает главное окно после выхода из окна CartWindow
            //foreach (Window window in App.Current.Windows)
            //{
            //    if (!(window is MainWindow))
            //        window.Close();
            //}
            ///2способ закрыть окно владельца???
            //this.Close();
            //CartWindow cartWindow = (CartWindow)this.Owner;
            //cartWindow.Close();
            ////3способ закрыть окно CartWindow при закрытии которого происходит возврат в 
            ///глав окно через функцию в гл окне this.ShowDialog
            //foreach (Window window in App.Current.Windows)
            //{
            //    if (window is CartWindow)
            //            window.Close();
            //}
            
        }

            private void backtoCart_Click(object sender, RoutedEventArgs e)
            {
            this.Close();
            }

      
       
        /// <summary>
        /// владельца указываем в событии Window_Loaded
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.Left = 400;
            this.Top = 200;
            //передаем  ссылку на родительское окно с указанием что оно владелец текущего окна
            CartWindow cartWindow = (CartWindow)this.Owner;
            //отображаем цену и остаток на счете, полученные от окна-владельца
            totalpriceTB.Text = $"Total cost of the purhcase: {cartWindow.totalprice}";
            remainigBalanceTB.Text = $"Current balance on your card: {cartWindow.remainingBalance}";
        }
    }
}
