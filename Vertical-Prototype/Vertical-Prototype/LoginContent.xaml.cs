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

namespace Vertical_Prototype
{
    /// <summary>
    /// Interaction logic for LoginContent.xaml
    /// </summary>
    public partial class LoginContent : UserControl
    {

        public InitRecipes Init { get; set; }
        public LoginContent(InitRecipes init)
        {
            InitializeComponent();
            wrongpasswordtips.Visibility = Visibility.Hidden;
            this.Init = init;
        }

        private void loginContent_signUpButton_Click(object sender, RoutedEventArgs e)
        {
            
            Switcher.SwitchTopPanel(new SignUpHeader());
            Switcher.SwitchContentPanel(new SignUpContent(this.Init));
        }

        private void loginContent_signUpButton_Click1(object sender, RoutedEventArgs e)
        {
            string loginUsername = loginContent_usernameField.Text;
            string loginpassword = loginContent_passwordField.Password.ToString();

            if (loginUsername != globalvariable.currentLoginUsername || loginpassword != globalvariable.currentLoginUserPassword)
            {
                wrongpasswordtips.Visibility = Visibility.Visible;
            }
            else
            {
                globalvariable.loginstatus = 1;
                globalvariable.currentLoginUsername = loginUsername;
                globalvariable.currentLoginUserPassword = loginpassword;
                Switcher.SwitchTopPanel(new SignInHeader());
                Switcher.SwitchContentPanel(new SignInContent(this.Init));
            }

            
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
