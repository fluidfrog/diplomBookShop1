using System;
using System.Collections.Generic;
using System.IO;
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
using Microsoft.Win32;
using DiplomApp.Pages;

namespace DiplomApp.Pages
{
    /// <summary>
    /// Логика взаимодействия для ChangeBookPage.xaml
    /// </summary>
    public partial class ChangeBookPage : Page
    {
        Book contextBook;
        public ChangeBookPage(Book book)
        {
            InitializeComponent();
            contextBook = book;
            DataContext = contextBook;
            CBGenre.ItemsSource = App.DB.Genre.ToList();
            DGFindAuthor.ItemsSource = App.DB.Author.ToList();
            DGHouseForBook.ItemsSource = App.DB.House.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var image = (sender as Button).DataContext as Book;
            var dialog = new OpenFileDialog();
            if (dialog.ShowDialog().GetValueOrDefault())
            {
                image.Image = File.ReadAllBytes(dialog.FileName);
                App.DB.SaveChanges();
                BookImage.Source = new BitmapImage(new Uri(dialog.FileName));
            }
        }

        private void BBookSave_Click(object sender, RoutedEventArgs e)
        {
            string Error = null;

            if( contextBook.Name == null)
            {
                Error += "Введите название книги\n";
            }

            if (contextBook.Image == null)
            {
                Error += "Добавьте обложку\n";
            }

            if (contextBook.Genre == null)
            {
                Error += "Выберите жанр\n";
            }

            if (contextBook.Year == null)
            {
                Error += "Укажите год издания\n";
            }

            if (contextBook.Price.ToString() == null)
            {
                Error += "Укажите цену\n";
            }

            if (contextBook.Amount.ToString() == null)
            {
                Error += "Укажите количество книг на складе\n";
            }

            if(contextBook.AuthorID.ToString() == null)
            {
                Error += "Выберите автора\n";
            }

            if(contextBook.HouseID.ToString() == null)
            {
                Error += "Выберите издательство\n";
            }

            if(contextBook.Description == null)
            {
                Error += "Добавьте описание книги\n";
            }

            if (contextBook.PageAmount == null)
            {
                Error += "Укажите количество страниц\n" + "Добавьте описание книги\n" + "Выберите автора\n" + "Выберите издательство\n";
            }

            if (contextBook.Weight.ToString() == null)
            {
                Error += "Укажите вес книги\n";
            }

            if (Error != null)
            {
                MessageBox.Show(Error);
                return;
            }
            
            if(contextBook.ID == 0)
            {
                App.DB.Book.Add(contextBook);
            }
            App.DB.SaveChanges();
            NavigationService.GoBack();
        }

        private void BBackFromRedB_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        public void BSelecetAuthorForBook_Click(object sender, RoutedEventArgs e)
        {
            var selectedAuthor = DGFindAuthor.SelectedItem as Author;
            contextBook.AuthorID = selectedAuthor.ID;
        }

        public void BSelectHouseForBook_Click(object sender, RoutedEventArgs e)
        {
            var selectedHouse = DGHouseForBook.SelectedItem as House;
            contextBook.HouseID = selectedHouse.ID;
        }
    }
}
