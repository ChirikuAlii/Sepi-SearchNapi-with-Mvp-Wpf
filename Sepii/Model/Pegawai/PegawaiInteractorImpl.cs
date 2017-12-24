using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sepii.Presenter.Pegawai;

namespace Sepii.Model.Pegawai
{
    class PegawaiInteractorImpl : IPegawaiInteractor
    {
        MySqlConnection connection = ConnectDB.ConnectingDB();
        DataTable dataAntrian = new DataTable();
        

        public void LoadData(IOnPegawaiFinishedListener listener)
        {
            try
            {
                
                dataAntrian.Clear();
                connection.Open();
                String query = "SELECT CONCAT(jenguk.ID) AS 'Antrian', CONCAT(member.nama) AS 'Nama Pengunjung' ,CONCAT(napi.nama) AS 'Nama Tahanan' ,  CONCAT(napi.noTahanan) AS 'Nomor Tahanan' ,jenguk.Date FROM `jenguk` , `member` , `napi` WHERE member.noKTP = jenguk.NoKtp_member AND napi.noTahanan = jenguk.NoTahanan_napi  ORDER BY jenguk.ID";


                MySqlCommand command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();

                MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter(command);

                sqlDataAdapter.Fill(dataAntrian);
                listener.onSuccessLoadData(dataAntrian);
                
            }
            catch (Exception e)
            {
                listener.onErrorLoadData();
                Console.WriteLine("Error:" + e);
            }
            connection.Close();
        }
    }
}
