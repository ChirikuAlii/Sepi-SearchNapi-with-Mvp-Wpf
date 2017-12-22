using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sepii.Model.LoginAdmin
{
    class LoginAdminInteractorImpl : ILoginAdminInteractor
    {
        MySqlConnection connection;
        String query;

        public void LoginAdmin(String username, String password, IOnLoginAdminFinishedListener listener , AdminModel adminModel)
        {
            connection = ConnectDB.ConnectingDB();
            query = "SELECT username , password FROM `login` WHERE username = '" + username + "' AND password = '" + password + "'";

            connection.Open();

            MySqlCommand command = connection.CreateCommand();
            command.CommandText = query;

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                adminModel.setUsername(reader.GetString(0).ToString());
                adminModel.setPassword(reader.GetString(1).ToString());
            }

            if (username == ""|| password == "")
            {
                listener.onEmptyUsernameOrPassword();
            }
            else
            {
                if (username == adminModel.getUsername() && password == adminModel.getPassword()) 
                {
                    listener.onSuccess();
                }

                else
                {
                    listener.onUsernameAndPasswordError();
                }

            }

            connection.Close();

        }

       
    }
}
