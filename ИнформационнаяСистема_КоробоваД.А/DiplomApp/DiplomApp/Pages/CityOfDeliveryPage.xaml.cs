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
    /// Логика взаимодействия для CityOfDeliveryPage.xaml
    /// </summary>
    public partial class CityOfDeliveryPage : Page
    {
        public CityOfDeliveryPage()
        {
            InitializeComponent();
            DGCity.ItemsSource = App.DB.Adress.ToList();
        }

        private void BAddCity_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddCityOfDeliveryPage(new Adress()));
        }

        private void BRedCity_Click(object sender, RoutedEventArgs e)
        {
            var selectedCity = DGCity.SelectedItem as Adress;
            if(selectedCity != null)
            {
                NavigationService.Navigate(new AddCityOfDeliveryPage(selectedCity));
            }
        }

        private void BDeleteCity_Click(object sender, RoutedEventArgs e)
        {
            var selectedCity = DGCity.SelectedItem as Adress;
            if (selectedCity != null)
            {
                App.DB.Adress.Remove(selectedCity);
            }
            App.DB.SaveChanges();
        }
    }
}
