using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using Microsoft.Win32;
using System.IO;

namespace DiplomApp.Pages
{
    /// <summary>
    /// Логика взаимодействия для GenrePage.xaml
    /// </summary>
    public partial class GenrePage : Page
    {
        public void Refersh()
        {
            DGGenre.ItemsSource = App.DB.Genre.ToList();
        }
        public GenrePage(Genre genre)
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddGenrePage(new Genre()));
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {   
            var selectedGenre = DGGenre.SelectedItem as Genre;
            if(selectedGenre != null)
            {
                NavigationService.Navigate(new AddGenrePage(selectedGenre));
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var selectedGenre = DGGenre.SelectedItem as Genre;
            if(selectedGenre != null)
            {
                App.DB.Genre.Remove(selectedGenre);
            }
            App.DB.SaveChanges();
            Refersh();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            Refersh();
        }

        private void DGGenre_Scroll(object sender, System.Windows.Controls.Primitives.ScrollEventArgs e)
        {

        }
    }
}
