using DiceTravel.Util;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DiceTravel.Classes
{
    class Entry : Entity
    {
        //props
        public int Id { get; set; }
        public int TripId { get; set; }
        public string EntryDate { get; set; }
        public byte[] Picture { get; set; }
        public string Comment { get; set; }
        public int Visibility { get; set; }
        
        //constructors
        public Entry(DataRow dataRow)
        {
            Id = Int32.Parse(dataRow["id"].ToString());
            TripId = Int32.Parse(dataRow["trip_id"].ToString());
            EntryDate = dataRow["entry_date"].ToString();
            Picture = null;
            Comment = dataRow["comment"].ToString();
            Visibility = Int32.Parse(dataRow["visibility"].ToString());
        }
        public Entry()
        {
        }

        //CRUD
        public override void CreateItself()
        {
            string query = "INSERT INTO `dice_travel`.`entries` (`trip_id`, `entry_date`,`picture`,`comment`,`visibility`) " +
                                    "VALUES (@trip_id,@entry_date,@picture,@comment,@visibility);";

            MySqlCommand sqlCommand = new MySqlCommand(query);
            sqlCommand.Connection = new MySqlConnection(Properties.Settings.Default.dice_travelConnString);

            sqlCommand.Parameters.Add("@trip_id", MySqlDbType.Int32);
            sqlCommand.Parameters.Add("@entry_date", MySqlDbType.DateTime);
            sqlCommand.Parameters.Add("@picture", MySqlDbType.Blob);
            sqlCommand.Parameters.Add("@comment", MySqlDbType.VarChar,512);
            sqlCommand.Parameters.Add("@visibility", MySqlDbType.Int32);

            sqlCommand.Parameters["@trip_id"].Value = TripId;
            sqlCommand.Parameters["@entry_date"].Value = EntryDate;
            sqlCommand.Parameters["@picture"].Value = Picture;
            sqlCommand.Parameters["@comment"].Value = Comment;
            sqlCommand.Parameters["@visibility"].Value = Visibility;

            RunSqlCommand(sqlCommand);
        }
        static public Entry ReadEntry(MySqlCommand sqlCommand)
        {
            return new Entry(ReadQueryTable(sqlCommand).Rows[0]);
        }
        public override void UpdateItself()
        {
            throw new NotImplementedException();
        }
        public override void DeleteItself()
        {
            string query = "DELETE FROM entries WHERE id = @id";

            MySqlCommand sqlCommand = new MySqlCommand(query);
            sqlCommand.Connection = new MySqlConnection(Properties.Settings.Default.dice_travelConnString);
            sqlCommand.Parameters.Add("@id", MySqlDbType.Int32);
            sqlCommand.Parameters["@id"].Value = this.Id;

            RunSqlCommand(sqlCommand);
        }
        
        //DB methods
        public override string GetInsertSql()
        {
            return $"INSERT INTO `dice_travel`.`entries` (`trip_id`, `entry_date`,`picture`,`comment`,`visibility`) " +
                                    $"VALUES ('{TripId}', '{EntryDate}','{Picture}','{Comment}','{Visibility}');";
        }
        public override string GetTableQueryString()
        {
            return "SELECT * FROM entries";
        }

        //misc methods
        public override void Validation()
        {
            throw new NotImplementedException();
        }

    }
}
