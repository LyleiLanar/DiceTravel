using DiceTravel.Util;
using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace DiceTravel.Classes
{
    public class Entry : Entity
    {
        //Properties
        public int Id { get; set; }
        public int TripId { get; set; }
        public DateTime EntryDate { get; set; }
        public byte[] Picture { get; set; }
        public string Title { get; set; }
        public string Comment { get; set; }
        public int Visibility { get; set; }

        //Constructors
        public Entry(DataRow dataRow)
        {
            Id = Int32.Parse(dataRow["id"].ToString());
            TripId = Int32.Parse(dataRow["trip_id"].ToString());
            Title = dataRow["title"].ToString();
            EntryDate = (DateTime)dataRow["entry_date"];

            try
            {
                Picture = (byte[])dataRow["picture"];
            }
            catch (InvalidCastException)
            {
                Picture = null;
            }

            Comment = dataRow["comment"].ToString();
            Visibility = Int32.Parse(dataRow["visibility"].ToString());
        } 
        public Entry(int tripId, DateTime entryDate, byte[] picture, string title, string comment, int visibility)
        {
            TripId = tripId;
            EntryDate = entryDate;
            Picture = picture;
            Title = title;
            Comment = comment;
            Visibility = visibility;
        }

        //Create, Update, Delete methods
        public override void CreateItself()
        {
            string query = "INSERT INTO `dice_travel`.`entries` (`trip_id`, `entry_date`,`picture`,`comment`,`visibility`,`title`) " +
                                    "VALUES (@trip_id,@entry_date,@picture,@comment,@visibility,@title);";

            using (MySqlCommand sqlCommand = CreateCommand(query))
            {

                sqlCommand.Parameters.Add("@trip_id", MySqlDbType.Int32);
                sqlCommand.Parameters.Add("@entry_date", MySqlDbType.DateTime);
                sqlCommand.Parameters.Add("@picture", MySqlDbType.Blob);
                sqlCommand.Parameters.Add("@comment", MySqlDbType.VarChar, 512);
                sqlCommand.Parameters.Add("@visibility", MySqlDbType.Int32);
                sqlCommand.Parameters.Add("@title", MySqlDbType.VarChar, 50);

                sqlCommand.Parameters["@trip_id"].Value = TripId;
                sqlCommand.Parameters["@entry_date"].Value = EntryDate;
                sqlCommand.Parameters["@picture"].Value = Picture;
                sqlCommand.Parameters["@comment"].Value = Comment;
                sqlCommand.Parameters["@visibility"].Value = Visibility;
                sqlCommand.Parameters["@title"].Value = Title;

                RunSqlCommand(sqlCommand);
            }
        }
        public override void UpdateItself()
        {
            string query = "UPDATE `dice_travel`.`entries` SET `trip_id`=@trip_id, `entry_date`=@entry_date,`picture`=@picture," +
                "`comment`=@comment,`visibility`=@visibility,`title`=@title WHERE id = @id";
            using (MySqlCommand sqlCommand = CreateCommand(query))
            {

                sqlCommand.Parameters.Add("@id", MySqlDbType.Int32);
                sqlCommand.Parameters.Add("@trip_id", MySqlDbType.Int32);
                sqlCommand.Parameters.Add("@entry_date", MySqlDbType.DateTime);
                sqlCommand.Parameters.Add("@picture", MySqlDbType.Blob);
                sqlCommand.Parameters.Add("@comment", MySqlDbType.VarChar, 1024);
                sqlCommand.Parameters.Add("@visibility", MySqlDbType.Int32);
                sqlCommand.Parameters.Add("@title", MySqlDbType.VarChar, 50);

                sqlCommand.Parameters["@id"].Value = Id;
                sqlCommand.Parameters["@trip_id"].Value = TripId;
                sqlCommand.Parameters["@entry_date"].Value = EntryDate;
                sqlCommand.Parameters["@picture"].Value = Picture;
                sqlCommand.Parameters["@comment"].Value = Comment;
                sqlCommand.Parameters["@visibility"].Value = Visibility;
                sqlCommand.Parameters["@title"].Value = Title;

                RunSqlCommand(sqlCommand);
            }
        }
        public override void DeleteItself()
        {
            string query = "DELETE FROM entries WHERE id = @id";

            using (MySqlCommand sqlCommand = CreateCommand(query))
            {

                sqlCommand.Parameters.Add("@id", MySqlDbType.Int32);
                sqlCommand.Parameters["@id"].Value = this.Id;

                RunSqlCommand(sqlCommand);
            }
        }

        //Validation
        public override void Validation()
        {
            if (String.IsNullOrEmpty(Title)) { throw new ValidationException("Missing Entry Title!"); }
            if (TripId == 0) { throw new ValidationException("Missing Entry TripID!"); }
            if (String.IsNullOrEmpty(Comment)) { throw new ValidationException("Missing Entry Comment!"); }
        }
    }
}
