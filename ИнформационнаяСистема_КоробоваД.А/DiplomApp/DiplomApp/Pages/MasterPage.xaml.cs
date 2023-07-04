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
using DiplomApp.Pages;
using DiplomApp.Models;

namespace DiplomApp.Pages
{
    /// <summary>
    /// Логика взаимодействия для MasterPage.xaml
    /// </summary>
    public partial class MasterPage : Page
    {
        public MasterPage()
        {
            InitializeComponent();
            MasterFraem.Navigate(new BookPage());
        }

        private void BMAddGenre_Click(object sender, RoutedEventArgs e)
        {
            MasterFraem.NavigationService.Navigate(new GenrePage(new Genre()));
        }

        private void BMAddAdmin_Click(object sender, RoutedEventArgs e)
        {
            MasterFraem.NavigationService.Navigate(new AdminRegPage());
        }

        private void BMAddBook_Click(object sender, RoutedEventArgs e)
        {
            MasterFraem.NavigationService.Navigate(new BookPage());
        }

        private void BAddHouse_Click(object sender, RoutedEventArgs e)
        {
            MasterFraem.NavigationService.Navigate(new HousePage());
        }

        private void BAddAuthor_Click(object sender, RoutedEventArgs e)
        {
            MasterFraem.NavigationService.Navigate(new AuthorPage());
        }

        private void BAddCity_Click(object sender, RoutedEventArgs e)
        {
            MasterFraem.NavigationService.Navigate(new CityOfDeliveryPage());
        }
    }
}
