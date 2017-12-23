
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
using Sepii.Presenter;
using MySql.Data.MySqlClient;
using System.Data;
using System.Collections;
using Sepii.Model;
using Sepii.Presenter.LoginPengunjung;
using Sepii.Model.LoginPengunjung;
using System.ComponentModel;
using System.Windows.Forms;

namespace Sepii.View
{
    /// <summary>
    
    /// Interaction logic for LoginPengunjung.xaml
    /// </summary>
    public partial class LoginPengunjung : Window ,ILoginPengunjungView 
    {
        MySqlConnection connection;
        ILoginPengunjungPresenter presenter;
        String nomorKtp;
        String nomorTahananNapi;
        String cariIdMember;
        String cariIdNapi;

        public LoginPengunjung()
        {
            connection = ConnectDB.ConnectingDB();   
            InitializeComponent();
            presenter = new LoginPengunjungPresenterImpl(this);
             
        }
        //EventHandler

        private void btnKirim_Click(object sender, RoutedEventArgs e)
        {
            nomorKtp = txtBoxNoKtp.Text;
            nomorTahananNapi = txtBoxNomorNapi.Text;
            presenter.performKirim(nomorKtp, nomorTahananNapi);
            
        }

        private void btnCariIdMember_Click(object sender, RoutedEventArgs e)
        {
            cariIdMember = txtBoxCariIdMember.Text;
            
            presenter.performSearchIdMember(cariIdMember);

          
        }

        private void btnCariIdNapi_Click(object sender, RoutedEventArgs e)
        {

            cariIdNapi = txtBoxCariIdNapi.Text;
            presenter.performSearchIdNapi(cariIdNapi);
          

        }

        private void btnPrint_Click(object sender, RoutedEventArgs e)
        {

        }

      
        //ChangeView
        public void setAddDataSuccess()
        {

            System.Windows.MessageBox.Show("Data berhasil di kirim");
        }

        public void setAddDataError()
        {
            System.Windows.MessageBox.Show("Data gagal di kirim");
        }

        public void setErrorItemMember()
        {
            System.Windows.MessageBox.Show("Data tidak di temukan");
            txtBoxCariIdMember.Clear();
            txtBoxNama.Clear();
            txtBoxNoKtp.Clear();
            txtBoxJenisKelamin.Clear();
            txtBoxTanggalLahir.Clear();
            txtBoxAgama.Clear();
            txtBoxKewarganegaraan.Clear();
            txtBoxNoTlp.Clear();
            txtBoxEmail.Clear();
            txtBoxAlamat.Clear();
            txtBoxKecamatan.Clear();
            txtBoxRtRw.Clear();


        }
        

        public void setItemMemberr(List<MemberModel> dataModel)
        {
            //binding to view through presenter
            txtBoxNoKtp.Text = dataModel[0].getNomorKtp();
            txtBoxNama.Text = dataModel[0].getNama();
            txtBoxJenisKelamin.Text = dataModel[0].getJenisKelamin();
            txtBoxTanggalLahir.Text = dataModel[0].getTanggalLahir();
            txtBoxAgama.Text = dataModel[0].getAgama();
            txtBoxKewarganegaraan.Text = dataModel[0].getKewarganegaraan();
            txtBoxNoTlp.Text = dataModel[0].getNomorTlp();
            txtBoxEmail.Text = dataModel[0].getEmail();
            txtBoxAlamat.Text = dataModel[0].getAlamat();
            txtBoxKecamatan.Text = dataModel[0].getKecamatan();
            txtBoxRtRw.Text = dataModel[0].getRtRw();
        
            
        }

        public void setItemNapi(List<NapiModel> dataModel)
        {

            //binding to view through presenter
            txtBoxNomorNapi.Text = dataModel[0].getNomorTahanan();
            txtBoxNamaNapi.Text = dataModel[0].getNamaTahanan();
            txtBoxJenisKelaminNapi.Text = dataModel[0].getJenisKelaminTahanan();
            txtBoxTanggalLahirNapi.Text = dataModel[0].getTanggalLahirTahanan();
            txtBoxAgamaNapi.Text = dataModel[0].getAgamaTahanan();
            txtBoxKewarganegaraanNapi.Text = dataModel[0].getKewarganegaraanTahanan();
        }

        public void setErrorItemNapi()
        {
            System.Windows.MessageBox.Show("Data tidak di temukan!");
            txtBoxNomorNapi.Clear();
            txtBoxNama.Clear();
            txtBoxJenisKelamin.Clear();
            txtBoxTanggalLahirNapi.Clear();
            txtBoxAgamaNapi.Clear();
            txtBoxKewarganegaraanNapi.Clear();

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

    }
    

    
}
