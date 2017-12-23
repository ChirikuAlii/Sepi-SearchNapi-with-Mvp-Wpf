using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Sepii.View
{
    /// <summary>
    /// Interaction logic for PilihMenu.xaml
    /// </summary>
    public partial class PilihMenu : Window
    {
        public PilihMenu()
        {
            InitializeComponent();
        }

       

        private void btnDaftar_Click(object sender, RoutedEventArgs e)
        {

            this.Hide();
            new Daftar().Show();
            

        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            new LoginPengunjung().Show();
            
        }

        private void btnPegawai_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            new Pegawai().Show();
            
        }

      

    }
}

