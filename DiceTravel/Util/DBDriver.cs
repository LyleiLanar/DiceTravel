using MySql.Data.MySqlClient;
using System.Data;

namespace DiceTravel.Util
{
    static class DBDriver
    {
        static readonly string connString = Properties.Settings.Default.dice_travelConnString;

        public static void InsertRow(string queryString, string insertCommand)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter(queryString, connString);

            using (MySqlConnection connection = new MySqlConnection(connString))
            {
                connection.Open();
                using (adapter.InsertCommand = new MySqlCommand(insertCommand, connection))
                {
                    adapter.InsertCommand.ExecuteNonQuery();
                }
            }
        }
        public static DataTable ReadQuery(string queryString)
        {
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(queryString, connString);
            adapter.Fill(table);

            return table;
        }
        public static void UpdateRow(string updateCommand)
        {
            // el kell készíteni az Update parancsot
        }
        public static void DeleteRow(string deleteCommand)
        {
            using (MySqlConnection connection = new MySqlConnection(connString))
            {
                connection.Open();
                using (MySqlCommand cmd = new MySqlCommand(deleteCommand, connection))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void runCommand(MySqlCommand sqlCommand)
        {                
                MySqlConnection myConnection = new MySqlConnection(connString);

                string myInsertQuery = "INSERT INTO Orders (id, customerId, amount) Values(1001, 23, 30.66)";
                MySqlCommand myCommand = new MySqlCommand(myInsertQuery);
                myCommand.Connection = myConnection;
                myConnection.Open();
                myCommand.ExecuteNonQuery();
                myCommand.Connection.Close();
            
        }

    }
}
