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
    /// Логика взаимодействия для AdminRegPage.xaml
    /// </summary>
    public partial class AdminRegPage : Page
    {
        public AdminRegPage()
        {
            InitializeComponent();
            DGUsers.ItemsSource = App.DB.User.ToList();
        }

        private void BDeleteUser_Click(object sender, RoutedEventArgs e)
        {
            var selectedUser =DGUsers.SelectedItem as User;
            if(selectedUser!= null )
            {
                App.DB.User.Remove(selectedUser);
                App.DB.SaveChanges();
            }
        }

        private void BUsersOrders_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new OrdersPage());
        }

        private void BAllOrders_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AllOrdersPage());
        }
    }
}
