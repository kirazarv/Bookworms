using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows;

namespace bookwormsWpf
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        //объявление объекта БД
        public static Entity.BookwormsEntities DB;
        //public static string Login { get; private set; }
        //public static string Password { get; private set; }
        
        public static void LogPass()
        {

            //App app = new App();
            //App.Login = "admin1";
            //App.Password = "1234";
        }
        
    }
   
}
