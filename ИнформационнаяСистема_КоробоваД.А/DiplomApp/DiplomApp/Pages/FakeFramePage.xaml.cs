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

namespace DiplomApp.Pages
{
    /// <summary>
    /// Логика взаимодействия для FakeFramePage.xaml
    /// </summary>
    public partial class FakeFramePage : Page
    {
        public FakeFramePage()
        {
            InitializeComponent();
            FakeFrame.NavigationService.Navigate(new ProfileUserPage());
        }

        private void BBookList_Click(object sender, RoutedEventArgs e)
        {
            FakeFrame.NavigationService.Navigate(new KatalogPage());
        }

        private void BOrder_Click(object sender, RoutedEventArgs e)
        {
            FakeFrame.Navigate(new OrderPage());
        }

        private void BProfile_Click(object sender, RoutedEventArgs e)
        {
            FakeFrame.NavigationService.Navigate(new ProfileUserPage());
        }
    }
}
