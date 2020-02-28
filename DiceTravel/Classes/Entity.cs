using MySql.Data.MySqlClient;
using System.Data;

namespace DiceTravel.Classes
{
    abstract public class Entity
    {
        //entity methods
        abstract public string GetInsertSql();
        abstract public string GetTableQueryString();

        //CRUD
        abstract public void CreateItself();
        abstract public void UpdateItself();
        abstract public void DeleteItself();

        //methods
        abstract public void Validation();

        //static methods
        static public void RunSqlCommand(MySqlCommand sqlCommand)
        {
            sqlCommand.Connection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlCommand.Connection.Close();
        }
        static public DataTable ReadQueryTable(MySqlCommand sqlCommand)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            return dataTable;
        }
        static public MySqlCommand CreateCommand(string sqlCommandString)
        {
            MySqlCommand sqlCommand = new MySqlCommand(sqlCommandString);
            sqlCommand.Connection = new MySqlConnection(Properties.Settings.Default.dice_travelConnString);

            return sqlCommand;
        }
    }
}
