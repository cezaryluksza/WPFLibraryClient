using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using WPFClient.LibraryServiceReference;
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
using System.Windows.Shapes;


namespace WPFClient
{
    /// <summary>
    /// Interaction logic for LoginScreen.xaml
    /// </summary>
    public partial class LoginScreen : Window
    {
        public LoginScreen()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            LibraryServiceClient LSC = new LibraryServiceClient();
            int permission = LSC.VerifyLogin(txtUsername.Text, txtPassword.Password);
            if (permission == 999)
            {
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Username or password is incorrect.");
            }
            LSC.Close();
        }
    }
}
