using DiplomApp.Models;
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
    /// Логика взаимодействия для AddAuthorPage.xaml
    /// </summary>
    public partial class AddAuthorPage : Page
    {
        Author contextAuthor;
        public AddAuthorPage(Author author)
        {
            InitializeComponent();
            contextAuthor = author;
            DataContext = contextAuthor;
        }

        private void BSaveAuthor_Click(object sender, RoutedEventArgs e)
        {
            if (contextAuthor.Name == null)
            {
                MessageBox.Show("Введите имя");
                return;
            }
            if (contextAuthor.ID == 0)
            {
                App.DB.Author.Add(contextAuthor);
            }
            App.DB.SaveChanges();
            NavigationService.GoBack();
        }

        private void BBackFromRedA_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
