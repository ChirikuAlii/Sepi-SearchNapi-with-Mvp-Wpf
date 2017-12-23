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
using Sepii.Model.LoginPengunjung;
using Sepii.Presenter.Daftar;

namespace Sepii.View
{
    
    /// <summary>
    /// Interaction logic for Daftar.xaml
    /// </summary>
    public partial class Daftar : Window , IDaftarView
    {
        IDaftarPresenter presenter;
        MySqlConnection connection;
        String nomorKtp;
        String nama;
        String jenisKelamin;
        String tanggalLahir;
        String agama;
        String kewarganegaraan;
        String nomorTlp;
        String email;
        String alamat;
        String kecamatan;
        String rtRw;
        public Daftar()
        {
            presenter = new DaftarPresenterImpl(this);
            InitializeComponent();
        }


        private void btnDaftar_Click(object sender, RoutedEventArgs e)
        {
            nomorKtp = txtBoxNoKtp.Text;
            nama = txtBoxNama.Text;
            jenisKelamin = rbLakilaki.IsChecked.ToString();
            tanggalLahir = datePickerLahir.Text;
            agama = txtBoxAgama.Text;
            kewarganegaraan = txtBoxKewarganegaraan.Text;
            nomorTlp = txtBoxNoTelepon.Text;
            email = txtBoxEmail.Text;
            alamat = txtBoxAlamat.Text;
            kecamatan = txtBoxKecamatan.Text;
            rtRw = txtBoxRtRw.Text;
         
            presenter.perfromAddData(
                nomorKtp,
                nama,
                jenisKelamin,
                tanggalLahir,
                agama,
                kewarganegaraan,
                nomorTlp,
                email,
                alamat,
                kecamatan,
                rtRw
                );
            
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


        public void setValidationsInsertData()
        {
           
        }

        public void setInsertDataSuccess()
        {
            System.Windows.MessageBox.Show("Data Berhasil disimpan");
        }

        public void setInsertDataError()
        {
            System.Windows.MessageBox.Show("Data Gagal disimpan");
        }

        public void setEmptyInsertData()
        {
            System.Windows.MessageBox.Show("Isi Data Terlebih Dahulu","Error",MessageBoxButton.OK, MessageBoxImage.Exclamation);
        }
    }


   


}
