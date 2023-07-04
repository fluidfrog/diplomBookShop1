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
    /// Логика взаимодействия для AddCityOfDeliveryPage.xaml
    /// </summary>
    public partial class AddCityOfDeliveryPage : Page
    {
        Adress contextAdress;
        public AddCityOfDeliveryPage(Adress adress)
        {
            InitializeComponent();
            contextAdress = adress;
            DataContext = contextAdress;
        }

        private void BSaveCity_Click(object sender, RoutedEventArgs e)
        {
            if(contextAdress.City == null)
            {
                MessageBox.Show("Введите город");
                return;
            }

            if(contextAdress.ID == 0)
            {
                App.DB.Adress.Add(contextAdress);
            }
            App.DB.SaveChanges();
            NavigationService.GoBack();
        }

        private void BBackFromRedCity_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
