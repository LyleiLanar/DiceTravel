using MySql.Data.MySqlClient;
using System.Data;

namespace DiceTravel.Classes
{
    abstract public class Entity
    {
        //*** Connection strings ***
        //Local
        static protected string connString = "server=localhost;user id = root; password=1234;database=dice_travel;port=33060";

        //online
        //static protected string connString = "server=185.51.67.15;user id = ghezemi1_dt_admin; password=Synae&Decrii;database=ghezemi1_dice_travel;port=3306";

        //Create, Update, Delete methods
        abstract public void CreateItself();
        abstract public void UpdateItself();
        abstract public void DeleteItself();

        //Validation
        abstract public void Validation();

        //Database handling methods
        static public MySqlCommand CreateCommand(string sqlCommandString)
        {
            MySqlCommand sqlCommand = new MySqlCommand(sqlCommandString)
            {
                Connection = new MySqlConnection(connString)
            };

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
