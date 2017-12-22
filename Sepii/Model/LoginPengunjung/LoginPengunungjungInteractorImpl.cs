using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sepii.Model.LoginPengunjung
{
    class LoginPengunungjungInteractorImpl : ILoginPengunjungInteractor
    {
       
        MySqlConnection connection;
        String query;
        MemberModel memberkModel = new MemberModel();
        NapiModel napiModel = new NapiModel();

        public void LoginPengungjung(string nomorKtp, string nomorTahanan, IOnLoginPengunjungFinishedListener listener)
        {
            connection = ConnectDB.ConnectingDB();
            
            
            try
            {
                connection.Open();
                MySqlCommand command = connection.CreateCommand();
                query = "INSERT INTO `jenguk` (`NoKtp_member`, `NoTahanan_napi`, `Date`) VALUES ('" + nomorKtp + "', '" + nomorTahanan + "', CURRENT_TIMESTAMP)";
                command.CommandText = query;
                command.ExecuteNonQuery();
                listener.onSuccessKirim();
               

            }
            catch (Exception e)

            {
                listener.onErrorKirim();
                Console.WriteLine("Error:"+e);
            }
            
            
          

            connection.Close();
        }

        public void SearchIdMember(string nomorKtp, IOnLoginPengunjungFinishedListener listener ,List<MemberModel> memberModelList)
        {
           
            connection = ConnectDB.ConnectingDB();

            try
            {
                connection.Open();
                string query = "SELECT * FROM `member` WHERE `noKTP`= '" + nomorKtp + "'";

                Boolean error = true;

                MySqlCommand command = connection.CreateCommand();
                command.CommandText = query;

                MySqlDataReader reader = command.ExecuteReader();


                while (reader.Read())
                {
                    

                    if (reader.GetString(0).ToString() == nomorKtp)
                    {
                        
                        memberkModel.setNomorKtp(reader.GetString(0).ToString());
                      

                        memberkModel.setNama(reader.GetString(1).ToString());


                        memberkModel.setJenisKelamin(reader.GetString(2).ToString());

                        memberkModel.setKewarganegaraan(reader.GetString(3).ToString());

                        memberkModel.setTanggalLahir(reader.GetString(4).ToString());


                        memberkModel.setAgama(reader.GetString(5).ToString());
                       

                        memberkModel.setNomorTlp(reader.GetString(6).ToString());
                   
                        memberkModel.setEmail(reader.GetString(7).ToString());
                  


                        memberkModel.setAlamat(reader.GetString(8).ToString());
                        


                        memberkModel.setKecamatan(reader.GetString(9).ToString());
                      

                        memberkModel.setRtRw(reader.GetString(10).ToString());
                        


                        error = false;
                       

                        memberModelList.Add(memberkModel);

                        listener.onSuccessCariIdMember();

                        memberModelList.RemoveAt(0);

                    }


                      

                }

                if (error == true)
                {
                    listener.onErrorCariIdMember();
              
                }






                connection.Close();



            }

            catch (Exception e)
            {
                Console.WriteLine("Error:" + e);
            }
        }

        public void SearchIdNapi(string nomorTahanan, IOnLoginPengunjungFinishedListener listener, List<NapiModel> napiModelList)
        {
            connection = ConnectDB.ConnectingDB();


            try
            {
                string query = "SELECT * FROM `napi` WHERE `noTahanan`= '" + nomorTahanan + "'";
                Boolean error = true;

                connection.Open();


                MySqlCommand command = connection.CreateCommand();
                command.CommandText = query;

                MySqlDataReader reader = command.ExecuteReader();


                while (reader.Read())
                {

                    
                    if (reader.GetString(0).ToString() == nomorTahanan)
                    {
                        napiModel.setNomorTahanan(reader.GetString(0).ToString());

                        napiModel.setNamaTahanan(reader.GetString(1).ToString());

                        napiModel.setJenisKelaminTahanan(reader.GetString(2).ToString());
                     
                       napiModel.setKewarganegaraanTahanan(reader.GetString(3).ToString());

                       napiModel.setTanggalLahirTahanan(reader.GetString(4).ToString());

                        napiModel.setAgamaTahanan(reader.GetString(5).ToString());

                        napiModelList.Add(napiModel);
                        
                        listener.onSuccessCariIdNapi();

                        //hapus karena hanya meggunakan satu object
                        napiModelList.RemoveAt(0);

                        error = false;
                    }




                }

                if (error == true)
                {

                    listener.onErrorCariIdNapi();

                }
                connection.Close();

            }

            catch (Exception e)
            {
                Console.WriteLine("Error:"+e);

            }
            
        }
    }
}
