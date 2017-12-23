using MySql.Data.MySqlClient;
using Sepii.Model;
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
    public partial class Pegawai : Window
    {
        MySqlConnection connection;
        public Pegawai()
        {
            LoadTable();
            connection = ConnectDB.ConnectingDB();
            InitializeComponent();
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
            LoadTable();
        }

        void LoadTable()
        {
            connection.Open();
            String query = "SELECT CONCAT(jenguk.ID) AS 'Antrian', CONCAT(member.nama) AS 'Nama Pengunjung' ,CONCAT(napi.nama) AS 'Nama Tahanan' ,  CONCAT(napi.noTahanan) AS 'Nomor Tahanan' ,jenguk.Date  " +
                "FROM `jenguk` , `member` , `napi` " +
                "WHERE member.noKTP = jenguk.NoKtp_member AND napi.noTahanan = jenguk.NoTahanan_napi  ORDER BY jenguk.ID";


            MySqlCommand command = new MySqlCommand(query, connection);
            command.ExecuteNonQuery();

            MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter(command);
            DataTable data = new DataTable();
            sqlDataAdapter.Fill(data);
            dataGrid.ItemsSource = data.DefaultView;
            connection.Close();
        }
    }
}
    
