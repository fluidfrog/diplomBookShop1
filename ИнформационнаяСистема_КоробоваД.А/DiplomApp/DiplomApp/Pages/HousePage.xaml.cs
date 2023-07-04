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
    /// Логика взаимодействия для HousePage.xaml
    /// </summary>
    public partial class HousePage : Page
    {
        public HousePage()
        {
            InitializeComponent();
            DGHouse.ItemsSource = App.DB.House.ToList();
        }

        private void BAddHouse_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddHousePage(new House()));
        }

        private void BRedHouse_Click(object sender, RoutedEventArgs e)
        {
            var selectedHouse = DGHouse.SelectedItem as House;
            if (selectedHouse != null)
            {
                NavigationService.Navigate(new AddHousePage(selectedHouse));
            }
        }

        private void BDeleteHouse_Click(object sender, RoutedEventArgs e)
        {
            var selecteHouse = DGHouse.SelectedItem as House;
            if (selecteHouse != null)
            {
                App.DB.House.Remove(selecteHouse);
            }
            App.DB.SaveChanges();
            Refresh();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            Refresh();
        }

        private void Refresh()
        {
            DGHouse.ItemsSource = App.DB.House.ToList();
            var filtred = App.DB.House.ToList();
            if (string.IsNullOrWhiteSpace(TBSearchForHouse.Text) == false)
            {
                filtred = filtred.Where(x => x.Name.ToLower().Contains(TBSearchForHouse.Text.ToLower())).ToList();
                DGHouse.ItemsSource = filtred;
            }
        }

        private void TBSearchForHouse_TextChanged(object sender, TextChangedEventArgs e)
        {
            Refresh();
        }
    }
}
