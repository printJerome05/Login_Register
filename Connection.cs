using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using Login_Register.Properties;
using MySql.Data.MySqlClient;
using ZstdSharp.Unsafe;

namespace Login_Register
{
   

   internal class Connection
    {



        public static string? server = Settings.Default.server;
        public  static string? database = "login_register";
        public static string? user = Settings.Default.user;
        public static string? password = Settings.Default.password;


        public MySqlConnection con = new MySqlConnection($"server={server};user id={user};password={password}");
        private MySqlCommand cmd = new MySqlCommand();
        public DataSet ds = new DataSet();
        public DataTable dt = new DataTable();
        public string? Username;
       

        public void Open()
        {

            if (con != null && con.State == System.Data.ConnectionState.Closed)
            {

                con.Open();
     
            }

        }

        public void Close()
        {

            if (con != null && con.State == System.Data.ConnectionState.Open)
            { 

                con.Close();

            }

        }

        public void CreateDatabase()
        {
            try
            {
                Open();
                string query = @"
                    CREATE DATABASE IF NOT EXISTS `login_register` /*!40100 DEFAULT CHARACTER SET latin1 */;
                    
                    USE `login_register`;
                    
                    CREATE TABLE IF NOT EXISTS `users` (
                         `id` int(11) NOT NULL AUTO_INCREMENT,
                         `username` varchar(45) DEFAULT NULL,
                         `password` varchar(45) DEFAULT NULL,
                         `role` varchar(45) DEFAULT 'User',
                         `cellnumber` varchar(12) DEFAULT NULL,
                         `birthDate` date DEFAULT NULL,
                         `registeredDate` date DEFAULT NULL,
                         `status` varchar(10) DEFAULT 'Active',
                         PRIMARY KEY (`id`)
                    ) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=latin1;

                    INSERT INTO `users`(`username`, `password`, `cellnumber`, `birthDate`, `registeredDate`)
                    SELECT 'Admin', 'password', '09123456789', '2020-11-05', curdate()
                    FROM dual
                    WHERE NOT EXISTS (
                        SELECT 1 FROM `users` WHERE `username` = 'Admin'
                    );";

                cmd = new MySqlCommand(query, con);
                cmd.ExecuteNonQuery();
                Close();

                // Reconnect using the newly created database
                con = new MySqlConnection($"server={server};user id={user};password={password};database={database}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

    }
}
