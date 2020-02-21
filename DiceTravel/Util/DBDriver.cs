using MySql.Data.MySqlClient;
using System.Data;

namespace DiceTravel.Util
{
    static class DBDriver
    {
        static string connString = Properties.Settings.Default.dice_travelConnString;

        public static DataTable ReadQuery(string queryString)
        {
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(queryString, connString);
            adapter.Fill(table);

            return table;
        }

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
    }
}
