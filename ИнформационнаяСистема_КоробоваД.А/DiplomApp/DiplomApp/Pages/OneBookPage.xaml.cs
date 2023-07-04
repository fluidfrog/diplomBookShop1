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
    /// Логика взаимодействия для OneBookPage.xaml
    /// </summary>
    public partial class OneBookPage : Page
    {
        Order contextOrder;
        Book contextBook;
        public OneBookPage(Book book)
        {
            InitializeComponent();
            contextBook = book;
            DataContext = contextBook;
        }

        private void BBackFromOneBook_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void BAddBookInOrder_Click(object sender, RoutedEventArgs e)
        {
            if(contextBook.Amount == 0)
            {
                MessageBox.Show("Книги пока нет в начичии");
                return;
            }

            contextOrder = new Order{ BookID = contextBook.ID, UserID = App.LoggedUser.ID, StatusID = 1, DateOfOrder = DateTime.Now, AdressID = 1 };
            App.DB.Order.Add(contextOrder);
            App.DB.SaveChanges();
            MessageBox.Show("Книга добавлена в вашу корзину");
        }
    }
}
