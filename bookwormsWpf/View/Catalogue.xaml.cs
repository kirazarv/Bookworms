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
    /// Логика взаимодействия для Catalogue.xaml
    /// </summary>
    public partial class Catalogue : Window
    {
        List<Entity.Item> items;//объявление списка items на глобал ур чтобы любой обработчик событий имел доступ к нему
        List<Entity.Genre> genres;
        public Catalogue()
        {
            InitializeComponent();
            this.Left = 400;
            this.Top = 200;
            ShowItem();
            cbSort.SelectedIndex = 0;
            //заполнить список жанров
            List<Entity.Genre> genres = App.DB.Genre.ToList();
            cbGenre.ItemsSource = genres;
            Entity.Genre allGenres = new Entity.Genre();//создать новый объект-жанр
            allGenres.GenreId = 0;
            allGenres.GenreName = "все жанры";
            genres.Insert(0, allGenres);
            cbGenre.ItemsSource = genres;
            cbGenre.DisplayMemberPath = "GenreName";
            cbGenre.SelectedValuePath = "GenreId";

            cbGenre.SelectedIndex = 0;
        }

        //метод для получения и сортировки данных
        private void ShowItem()
        {
            //список всех книг из БД 
            List<Entity.Item> items = App.DB.Item.ToList();//объявление и заполнение списка из базы
                                                           //перенос списка всех книг в list view
                                                           //lvItems.ItemsSource = items;

           

            //сортировка по цене
            if (cbSort.SelectedIndex == 1)
            {
                items = items.OrderBy(price => price.ItemCost).ToList();
            }
            if (cbSort.SelectedIndex == 2)
            {
                items = items.OrderByDescending(price => price.ItemCost).ToList();
            }

            //фильтрация по жанрам
            if(cbGenre.SelectedIndex>0)
            {
                items = items.Where(i => i.ItemGenre==(int)cbGenre.SelectedValue).ToList();
            }
          
            //поиск по названию
            string searchName=tbSearch.Text.ToLower();
            items = items.Where(i => i.ItemName.ToLower().Contains(searchName)).ToList();

            //dgItem.Items.Clear();
            //перенос списка всех книг в data grid
            dgItem.ItemsSource = items;
           
        }
        private void fromCataloguetoMain_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void cbSort_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ShowItem();
        }

        private void cbGenre_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ShowItem();
        }

        private void tbSearch_SelectionChanged(object sender, RoutedEventArgs e)
        {
            ShowItem();
        }


        ////выбор строки в таблице 
        //private void lvItems_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        //{
        //    MessageBox.Show("Id книги " + ((Entity.Item)lvItems.SelectedItem).ItemId);
        //}
    }
}
