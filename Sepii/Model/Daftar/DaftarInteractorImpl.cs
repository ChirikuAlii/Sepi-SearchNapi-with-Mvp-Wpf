using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sepii.Model.LoginPengunjung;
using MySql.Data.MySqlClient;
using System.Windows;
using System.Windows.Forms;

namespace Sepii.Model.Daftar
{
    class DaftarInteractorImpl : IDaftarInteractor
    {
        public void Daftar(MemberModel memberModel, IOnDaftarFinishedListener listener)
        {
            MySqlConnection connection = ConnectDB.ConnectingDB();
            String query;
            bool gender;

            //Logic getGender
            {
                if (memberModel.getJenisKelamin() == bool.TrueString)
                {
                    memberModel.setJenisKelamin("Laki-laki");


                }

                else
                {
                    memberModel.setJenisKelamin("Perempuan");
                }
            }

                //Logic dataModel
                {
                    //Logic empty dataModel
                    if (
                   memberModel.getNomorKtp() == "" ||
                   memberModel.getNama() == "" ||
                   memberModel.getJenisKelamin() == "" ||
                   memberModel.getKewarganegaraan() == "" ||
                   memberModel.getTanggalLahir() == "" ||
                   memberModel.getAgama() == "" ||
                   memberModel.getNomorTlp() == "" ||
                   memberModel.getEmail() == "" ||
                   memberModel.getAlamat() == "" ||
                   memberModel.getKecamatan() == "" ||
                   memberModel.getRtRw() == "")
                    {
                        listener.onEmptyInsertData();
                    }
                    
                    else
                    {
                        try
                        {
                            connection.Open();
                            query = "INSERT INTO `member` (`noKTP`, `nama`, `jenis kelamin`, `kewarganegaraan`, `tempat tanggal lahir`, `agama`, `nomor telepon`, `email`, `alamat`, `kecamatan`, `RT/RW`) VALUES (" +
                               "'" + memberModel.getNomorKtp() + "', " +
                               "'" + memberModel.getNama() + "', " +
                               "'" + memberModel.getJenisKelamin() + "', " +
                               "'" + memberModel.getKewarganegaraan() + "', " +
                               "'" + memberModel.getTanggalLahir() + "', " +
                               "'" + memberModel.getAgama() + "', " +
                               "'" + memberModel.getNomorTlp() + "', " +
                               "'" + memberModel.getEmail() + "', " +
                               "'" + memberModel.getAlamat() + "', " +
                               "'" + memberModel.getKecamatan() + "', " +
                               "'" + memberModel.getRtRw() + "'" +
                               ")";
                            MySqlCommand createCommand = new MySqlCommand(query, connection);
                            

                            //Validasi Data di input atau tidak
                            DialogResult dialog = System.Windows.Forms.MessageBox.Show("Apakah Anda Yakin Data ini Valid?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                            if (dialog == System.Windows.Forms.DialogResult.Yes)
                            {
                                createCommand.ExecuteNonQuery();
                                listener.onSuccesInsertData();

                            }
                            

                            
                        }
                        catch (Exception e)
                        {
                            
                            listener.onErrorInsertData();

                            Console.WriteLine("Error:" + e);
                        }

                    }
                }
            
               
            }
            
    }
}
