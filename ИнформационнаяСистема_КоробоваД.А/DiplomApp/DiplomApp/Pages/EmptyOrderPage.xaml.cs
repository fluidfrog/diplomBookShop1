﻿using System;
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

namespace DiplomApp.Pages
{
    /// <summary>
    /// Логика взаимодействия для EmptyOrderPage.xaml
    /// </summary>
    public partial class EmptyOrderPage : Page
    {
        public EmptyOrderPage()
        {
            InitializeComponent();
        }

        private void BEmptyOrder_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new KatalogPage());
        }
    }
}
