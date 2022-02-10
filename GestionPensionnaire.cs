using MySql.Data.MySqlClient;
using System;

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
                Console.WriteLine("connection failed" + exception.Message);
            }
            return connection;
        }
        // Fonction qui ajoute un animal dans la BD
        public void Ajouter()
        {

        }

    }
}
