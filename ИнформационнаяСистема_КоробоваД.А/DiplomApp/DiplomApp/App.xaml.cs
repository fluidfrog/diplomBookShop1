using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using DiplomApp.Models;

namespace DiplomApp
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static BookAppEntities DB = new BookAppEntities();
        public static User LoggedUser;
        List<Order> orders= new List<Order>();
    }
}
