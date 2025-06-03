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

namespace Login_App
{
    /// <summary>
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class Page1 : UserControl
    {
        public static string _username;
        public static string _password;
        public Page1()
        {
            InitializeComponent();
        }

        private void Login(object sender, RoutedEventArgs e)
        {
            _username = username.Text;
            _password = password.Password;

            Window window = Window.GetWindow(this);
            window.Content = new Page2();
        }


        private void password_PasswordChanged(object sender, RoutedEventArgs e)
        {
                LOGIN.IsEnabled = !string.IsNullOrEmpty(password.Password);
        }
        private void username_TextChanged(object sender, TextChangedEventArgs e)
        {
            password.IsEnabled = !string.IsNullOrEmpty(username.Text);
        }
    }
}
