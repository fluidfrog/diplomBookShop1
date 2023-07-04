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
    /// Логика взаимодействия для AuthorPage.xaml
    /// </summary>
    public partial class AuthorPage : Page
    {
        public AuthorPage()
        {
            InitializeComponent();
            DGAuthor.ItemsSource = App.DB.Author.ToList();
        }

        private void BRedAuthor_Click(object sender, RoutedEventArgs e)
        {
            var selectedAuthor = DGAuthor.SelectedItem as Author;
            if(selectedAuthor != null)
            {
                NavigationService.Navigate(new AddAuthorPage(selectedAuthor));
            }
        }

        private void BAddAuthor_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddAuthorPage(new Author()));
        }

        private void BDeleteAuthor_Click(object sender, RoutedEventArgs e)
        {
            var selectedAuthor = DGAuthor.SelectedItem as Author;
            if(selectedAuthor != null)
            {
                App.DB.Author.Remove(selectedAuthor);
            }
            App.DB.SaveChanges();
            Refresh();
        }

        private void Refresh()
        {
            DGAuthor.ItemsSource = App.DB.Author.ToList();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            Refresh();
        }
    }
}
