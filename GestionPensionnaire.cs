using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace ApplicationVeterinaire
{
    internal class GestionPensionnaire
    {
        public MySqlConnection ConnectToDatabase()
        {
            string stringConnection = "server=localhost;database=pensionnaire; uid=root; pwd=;";
            MySqlConnection connection = new MySqlConnection(stringConnection);
            try
            {
                connection.Open();                    
            }
            catch (Exception exception)
            {
                Console.WriteLine("connection failed"+exception.Message);
            }
            return connection;
        }
        // Fonction qui ajoute un animal dans la BD
        public void Ajouter()
        {

        }
        
    }
}
