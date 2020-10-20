using MySql.Data.MySqlClient;
using System.Data;

namespace DiceTravel.Classes
{
    abstract public class Entity
    {
        //*** Connection strings ***
        //Local

        //Create, Update, Delete methods
        abstract public void CreateItself();
        abstract public void UpdateItself();
        abstract public void DeleteItself();

        //Validation
        abstract public void Validation();

        //Database handling methods

        static protected string connString = "server=localhost;user id = root; password=1234;database=dice_travel;port=33060";

        //select, insert, update
        static public MySqlCommand CreateCommand(string sqlCommandString)
        {
            MySqlCommand sqlCommand = new MySqlCommand(sqlCommandString);
            sqlCommand.Connection = new MySqlConnection(connString);

            return sqlCommand;
        }

        static public void RunSqlCommand(MySqlCommand sqlCommand)
        {
            sqlCommand.Connection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlCommand.Connection.Close();
        }

        static public DataTable ReadQueryTable(MySqlCommand sqlCommand)
        {
            DataTable dataTable = new DataTable();
            using (MySqlDataAdapter adapter = new MySqlDataAdapter(sqlCommand))
            {
                adapter.Fill(dataTable);
            }
            return dataTable;
        }
    }
}
