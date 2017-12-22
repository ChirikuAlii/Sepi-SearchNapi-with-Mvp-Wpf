using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Sepii.View;
using Sepii.Model;
using System.Windows;



namespace Sepii.Model
{
    public class ConnectDB
    {
        
        public static MySqlConnection ConnectingDB()
        {
            
            string SERVER, DATABASE, UID, PASS;
            SERVER = "localhost";
            DATABASE = "sepi";
            UID = "root";
            PASS = "";


            string connect = $"SERVER ={SERVER};DATABASE={DATABASE};UID={UID};PASSWORD={PASS}; ";
           return  new MySqlConnection(connect);
           
        }






    }
}
