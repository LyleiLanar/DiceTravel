﻿using MySql.Data.MySqlClient;
using System.Data;

namespace DiceTravel.Classes
{
    abstract public class Entity
    {
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
                Connection = new MySqlConnection(Properties.Settings.Default.dice_travelConnString)
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
