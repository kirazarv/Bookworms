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
    /// Логика взаимодействия для WindowAdmin.xaml
    /// </summary>
   
    ///создание класа WindowAdmin от родительского класса Window
    public partial class WindowAdmin : Window
    {
        public WindowAdmin()
        {
            InitializeComponent();
            this.Left = 400;
            this.Top = 200;
        }

        private void butNavtoMain_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
