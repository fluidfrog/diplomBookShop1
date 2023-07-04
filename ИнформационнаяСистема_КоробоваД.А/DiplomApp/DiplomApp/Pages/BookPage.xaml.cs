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
    /// Логика взаимодействия для BookPage.xaml
    /// </summary>
    public partial class BookPage : Page
    {
        public BookPage()
        {
            InitializeComponent();
            DGBooks.ItemsSource = App.DB.Book.ToList();
        }

        private void BAddBook_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ChangeBookPage(new Book()));
        }

        private void BChangeBook_Click(object sender, RoutedEventArgs e)
        {
            var selectedItem = DGBooks.SelectedItem as Book;
            if (selectedItem != null)
            {
                NavigationService.Navigate(new ChangeBookPage(selectedItem));
            }
        }

        private void BDeleteBook_Click(object sender, RoutedEventArgs e)
        {
            var selectedItem = DGBooks.SelectedItem as Book;
            if (selectedItem != null)
            {
                App.DB.Book.Remove(selectedItem);
            }
            App.DB.SaveChanges();
            DGBooks.ItemsSource = App.DB.Book.ToList();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            Refresh();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            DGBooks.ItemsSource = App.DB.Book.ToList();
        }
        private void Refresh()
        {
            var filtred = App.DB.Book.ToList();
            if (string.IsNullOrWhiteSpace(TBSearchForBookForRed.Text)==false)
            {
                filtred = filtred.Where(x => x.Name.ToLower().Contains(TBSearchForBookForRed.Text.ToLower()) 
                || x.Price.ToString() == TBSearchForBookForRed.Text
                || x.Year.ToString() == TBSearchForBookForRed.Text
                || x.Author.Name.ToLower().Contains(TBSearchForBookForRed.Text.ToLower())
                || x.House.Name.ToLower().Contains(TBSearchForBookForRed.Text.ToLower())
                || x.Genre.Name.ToLower().Contains(TBSearchForBookForRed.Text.ToLower())
                || x.Description.ToLower().Contains(TBSearchForBookForRed.Text.ToLower())).ToList();
                DGBooks.ItemsSource = filtred;
            }
        }
    }
}
