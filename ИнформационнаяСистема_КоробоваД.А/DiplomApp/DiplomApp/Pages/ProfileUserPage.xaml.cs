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
    /// Логика взаимодействия для ProfileUserPage.xaml
    /// </summary>
    public partial class ProfileUserPage : Page
    {
        public ProfileUserPage()
        {
            InitializeComponent();
            ProfileFrame.Navigate(new UserPageView());
        }

        private void BMakeAnOrder_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new KatalogPage());
        }

        private void BLogOut_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult LogOutUser = MessageBox.Show("Вы действительно хотите выйти?","Выйти",MessageBoxButton.YesNo);
            if(LogOutUser == MessageBoxResult.Yes) 
            {
                Environment.Exit(0);
            }
        }

        private void BMyProfile_Click(object sender, RoutedEventArgs e)
        {
            ProfileFrame.Navigate(new UserPageView());
        }

        private void BMyHistory_Click(object sender, RoutedEventArgs e)
        {
            ProfileFrame.Navigate(new MyHistoryPage());
        }
    }
}
