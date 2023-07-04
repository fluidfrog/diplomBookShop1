using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
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

namespace DiplomApp.Pages
{
    /// <summary>
    /// Логика взаимодействия для RegPage.xaml
    /// </summary>
    public partial class RegPage : Page
    {
        public RegPage()
        {
            InitializeComponent();;
        }

        private void BReg_Click(object sender, RoutedEventArgs e)
        {
            User contextUser = new User();
            DataContext = contextUser;
            string login = TBPhone.Text.Trim();
            string password = TBPass.Text.Trim();

            if (login.Length < 11)
            {
                TBPhone.ToolTip = "Неверный формат номера";
                TBPhone.Background = Brushes.LavenderBlush;
                return;
            } 
            else 
            {
                TBPhone.ToolTip = "";
                TBPhone.Background = Brushes.White;
                TBPass.Text = "";
                TBPass.Background = Brushes.White;
            }

            if (password.Length < 5)
            {
                TBPass.ToolTip = "Пароль должен быть не меньше 5 символов";
                TBPass.Background = Brushes.LavenderBlush;
                return;
            }
            else
            {
                TBPhone.ToolTip = "";
                TBPhone.Background = Brushes.White;
                TBPass.ToolTip = "";
                TBPass.Background = Brushes.White;
            }
            
            if(contextUser.ID == 0)
            {
                var Number = App.DB.User.FirstOrDefault(x => x.PhoneNumber == contextUser.PhoneNumber);
                if(Number != null)
                {
                    MessageBox.Show("Такой пользователь уже есть");
                    return;
                }
                contextUser.RightID = 2;
                App.DB.User.Add(contextUser);
                App.DB.SaveChanges();
                App.LoggedUser = contextUser;
                NavigationService.Navigate(new FakeFramePage());
            }   
        }

        private void BLogIn_Click(object sender, RoutedEventArgs e)
        {
                var phone = App.DB.User.FirstOrDefault(x => x.PhoneNumber == TBPhone.Text);
                var pass = App.DB.User.FirstOrDefault(x => x.Password == TBPass.Text);
                if (phone != null)
                {
                    if(pass == null)
                    {
                        MessageBox.Show("Неверные данные");
                        return;
                    }
                    var user = App.DB.User.FirstOrDefault(x => x.PhoneNumber == TBPhone.Text && x.Password == TBPass.Text);
                    App.LoggedUser = user;
                    if (phone.RightID == 3)
                        NavigationService.Navigate(new MasterPage());
                    if(phone.RightID == 2)
                        NavigationService.Navigate(new FakeFramePage());
                }
                
        }
    }
}
