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
using DiplomApp.Models;
using DiplomApp.Pages;

namespace DiplomApp.Pages
{
    /// <summary>
    /// Логика взаимодействия для KatalogPage.xaml
    /// </summary>
    public partial class KatalogPage : Page
    {
        public KatalogPage()
        {
            InitializeComponent();
            LVGenre.ItemsSource = App.DB.Genre.ToList();
            LVBooksByGenre.ItemsSource = App.DB.Book.ToList();
        }

        private void LVBooksByGenre_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

            var selectedBook = LVBooksByGenre.SelectedItem as Book;
            if(selectedBook != null)
            {
                NavigationService.Navigate(new OneBookPage(selectedBook));
            }
        }

        private void LVGenre_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var selectedGenre = LVGenre.SelectedItem as Genre;
            if(selectedGenre != null)
            {
                LVBooksByGenre.ItemsSource = App.DB.Book.Where(x => x.GenreID == selectedGenre.ID).ToList();
            }
        }
    }
}
