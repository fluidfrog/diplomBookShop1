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
using Microsoft.Win32;
using System.IO;

namespace DiplomApp.Pages
{
    /// <summary>
    /// Логика взаимодействия для AddGenrePage.xaml
    /// </summary>
    public partial class AddGenrePage : Page
    {
        Genre contextGenre;
        public AddGenrePage(Genre genre)
        {
            InitializeComponent();
            contextGenre= genre;
            DataContext= contextGenre;
        }

        private void BGenreSave_Click(object sender, RoutedEventArgs e)
        {
            if (contextGenre.Name == null)
            {
                MessageBox.Show("Введите название жанра");
                return;
            }

            if (contextGenre.ID == 0)
            {
                App.DB.Genre.Add(contextGenre);
            }
            App.DB.SaveChanges();
            NavigationService.GoBack();
        }

        private void BBackFromRedG_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
