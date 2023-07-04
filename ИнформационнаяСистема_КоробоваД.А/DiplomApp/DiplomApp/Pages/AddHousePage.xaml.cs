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
    /// Логика взаимодействия для AddHousePage.xaml
    /// </summary>
    public partial class AddHousePage : Page
    {
        House contextHouse;
        public AddHousePage(House house)
        {
            InitializeComponent();
            contextHouse = house;
            DataContext= contextHouse;
        }

        private void BSaveHouse_Click(object sender, RoutedEventArgs e)
        {
            if(contextHouse.Name == null)
            {
                MessageBox.Show("Введите  имя");
                return;
            }
            if(contextHouse.ID ==0)
            {
                App.DB.House.Add(contextHouse);
            }
            App.DB.SaveChanges();
            NavigationService.GoBack();
        }

        private void BBackFromRedH_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
