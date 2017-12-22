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
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Sepii.View
{
    
    /// <summary>
    /// Interaction logic for Daftar.xaml
    /// </summary>
    public partial class Daftar : Window
    {
        MySqlConnection connection;
        string gender = null;
        string date = null;
        public Daftar()
        {
            InitializeComponent();
        }


        private void btnDaftar_Click(object sender, RoutedEventArgs e)
        {
            ConnectingDB();
            getGender();
            getDate();
            addToDatabase();
            connection.Close();
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
                System.Windows.Application.Current.Shutdown();
            }
                
        }
        public void addToDatabase()
        {
            try
            {
                connection.Open();
                string Query = "INSERT INTO `member` (`noKTP`, `nama`, `jenis kelamin`, `kewarganegaraan`, `tempat tanggal lahir`, `agama`, `nomor telepon`, `email`, `alamat`, `kecamatan`, `RT/RW`) VALUES ('" + txtBoxNoKtp.Text + "', '" + txtBoxNama.Text + "', '" + gender + "', '" + txtBoxKewarganegaraan.Text + "', '" + date + "', '" + txtBoxAgama.Text + "', '" + txtBoxNoTelepon.Text + "', '" + txtBoxEmail.Text + "', '" + txtBoxAlamat.Text + "', '" + txtBoxKecamatan.Text + "', '" + txtBoxRtRw.Text + "')";
                MySqlCommand createCommand = new MySqlCommand(Query, connection);
                createCommand.ExecuteNonQuery();
                System.Windows.MessageBox.Show("Saved");
            }
            catch (Exception e)
            {
                System.Windows.MessageBox.Show(e.ToString());
            }
          

        }

        public void getGender()
        {
            if (rbLakilaki.IsChecked == true)
            {
                gender="Laki-laki";
            }
            else if (rbPerempuan.IsChecked == true)
                gender= "Perempuan";
        }

        public void getDate()
        {
            var dateTime = datePickerLahir.SelectedDate.Value.ToShortDateString();
            date = datePickerLahir.SelectedDate.Value.ToShortDateString();
        }
        public void ConnectingDB()
        {

            string SERVER, DATABASE, UID, PASS;
            SERVER = "localhost";
            DATABASE = "sepi";
            UID = "root";
            PASS = "";


            string connect = $"SERVER ={SERVER};DATABASE={DATABASE};UID={UID};PASSWORD={PASS}; ";
            connection = new MySqlConnection(connect);

        }

    }


   


}
