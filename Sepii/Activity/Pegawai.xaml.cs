using MySql.Data.MySqlClient;
using Sepii.Model;
using Sepii.Presenter.Pegawai;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    /// Interaction logic for Pegawai.xaml
    /// </summary>
    public partial class Pegawai : Window , IPegawaiView
    {
        System.Windows.Controls.DataGrid data;
        IPegawaiPresenter presenter;
        MySqlConnection connection;
        public Pegawai()
        {
            presenter = new PegawaiPresenterImpl(this);
            InitializeComponent();
            presenter.performLoadTable();
            
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            DialogResult dialog = System.Windows.Forms.MessageBox.Show("Apakah Anda Yakin Ingin Keluar?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == System.Windows.Forms.DialogResult.No)
            {
                e.Cancel = true;


            }
            else
            {
                if (this.IsActive == false)
                    e.Cancel = true;
                else
                    System.Windows.Application.Current.Shutdown();
            }

        }

        private void btnLoadTable_Click(object sender, RoutedEventArgs e)
        {

            presenter.performLoadTable();

            //ganti
            
        }


     



        public void setErrorLoadTable()
        {
            System.Windows.MessageBox.Show("Periksa jaringan anda!");
        }

        public void setSucccesLoadTable(DataTable dataAntri)
        {
            dataGridAntrian.ItemsSource = dataAntri.DefaultView;
        }
    }
}
    
