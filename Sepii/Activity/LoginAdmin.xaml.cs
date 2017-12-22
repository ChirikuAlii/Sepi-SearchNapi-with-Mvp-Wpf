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
using System.Windows.Shapes;
using MySql.Data.MySqlClient;
using System.Data;
using Sepii.Model;
using Sepii.Presenter.LoginAdmin;

namespace Sepii.View
{
   
    /// <summary>

    /// Interaction logic for LoginMenu.xaml

    /// </summary>
    public partial class LoginAdmin : Window ,ILoginAdminView
    {
        String username;
        String password;
        ILoginAdminPresenter presenter;
      

        
        
        public LoginAdmin()
        {
            presenter = new LoginAdminPresenterImpl(this);
            
            InitializeComponent();
           
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            ResizeMode = ResizeMode;
            WindowState = WindowState.Maximized;
            
        }

      

        private void btnMasuk_Click(object sender, RoutedEventArgs e)
        {
            username = txtUsername.Text;
            password = txtPassword.Password.ToString();

            presenter.performLogin(username, password);
            
        }

        


        public void setEmptyUsernameOrPassword()
        {
            MessageBox.Show("Input username dan password!");
        }

        public void setLoginSuccess()
        {
            MessageBox.Show("Login berhasil");
            this.Hide();
            new PilihMenu().Show();
        }

        public void setLoginUsernameOrPasswordError()
        {
            MessageBox.Show("Username dan password salah!");
        }



    }

    















}



