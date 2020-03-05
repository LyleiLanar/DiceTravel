using DiceTravel.Util;
using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace DiceTravel.Classes
{
    public class Trip : Entity
    {
        //props
        public int Id { get; set; }
        public int JourneyId { get; set; }
        public int SerialNumber { get; set; }
        public string EndLocation { get; set; }
        public DateTime EndDate { get; set; }
        public int Visibility { get; set; }

        //constructors
        public Trip(DataRow dataRow)
        {
            Id = Int32.Parse(dataRow["id"].ToString());
            JourneyId = Int32.Parse(dataRow["journey_id"].ToString());
            SerialNumber = Int32.Parse(dataRow["serial_number"].ToString());
            EndLocation = dataRow["end_location"].ToString();

            string dateString = dataRow["end_date"].ToString();
            DateTime date = DateTime.Parse(dateString);
            //EndDate = date.ToString("yyy-MM-dd HH:mm:ss");
            EndDate = date;

            Visibility = Int32.Parse(dataRow["visibility"].ToString());
        }
        public Trip()
        {
        }

        //CRUD

        public override void CreateItself()
        {
            string query = "INSERT INTO `dice_travel`.`trips` (`journey_id`, `serial_number`,`end_location`,`end_date`,`visibility`) " +
                                  "VALUES (@journey_id, @serial_number, @end_location, @end_date, @visibility);";

            MySqlCommand sqlCommand = new MySqlCommand(query)
            {
                Connection = new MySqlConnection(Properties.Settings.Default.dice_travelConnString)
            };

            sqlCommand.Parameters.Add("@journey_id", MySqlDbType.Int32);
            sqlCommand.Parameters.Add("@serial_number", MySqlDbType.Int32);
            sqlCommand.Parameters.Add("@end_location", MySqlDbType.VarChar, 20);
            sqlCommand.Parameters.Add("@end_date", MySqlDbType.Timestamp, 1);
            sqlCommand.Parameters.Add("@visibility", MySqlDbType.Int32);

            sqlCommand.Parameters["@journey_id"].Value = ActiveUserStore.GetActiveJourney().Id;
            sqlCommand.Parameters["@serial_number"].Value = SerialNumber;
            sqlCommand.Parameters["@end_location"].Value = EndLocation;
            sqlCommand.Parameters["@end_date"].Value = EndDate;
            sqlCommand.Parameters["@visibility"].Value = Visibility;

            RunSqlCommand(sqlCommand);
        }
        static public Trip ReadTrip(MySqlCommand sqlCommand)
        {
            return new Trip(ReadQueryTable(sqlCommand).Rows[0]);
        }
        public override void UpdateItself()
        {
            string query = "UPDATE `dice_travel`.`trips` SET `journey_id`=@journey_id, `serial_number`=@serial_number,`end_location`=@end_location,`end_date`=@end_date,`visibility`=@visibility " +
                "WHERE id = @id";

            MySqlCommand sqlCommand = new MySqlCommand(query)
            {
                Connection = new MySqlConnection(Properties.Settings.Default.dice_travelConnString)
            };

            sqlCommand.Parameters.Add("@id", MySqlDbType.Int32);
            sqlCommand.Parameters.Add("@journey_id", MySqlDbType.Int32);
            sqlCommand.Parameters.Add("@serial_number", MySqlDbType.Int32);
            sqlCommand.Parameters.Add("@end_location", MySqlDbType.VarChar, 20);
            sqlCommand.Parameters.Add("@end_date", MySqlDbType.Timestamp, 1);
            sqlCommand.Parameters.Add("@visibility", MySqlDbType.Int32);

            sqlCommand.Parameters["@id"].Value = Id;
            sqlCommand.Parameters["@journey_id"].Value = JourneyId;
            sqlCommand.Parameters["@serial_number"].Value = SerialNumber;
            sqlCommand.Parameters["@end_location"].Value = EndLocation;
            sqlCommand.Parameters["@end_date"].Value = EndDate;
            sqlCommand.Parameters["@visibility"].Value = Visibility;

            RunSqlCommand(sqlCommand);
        }        
        public override void DeleteItself()
        {
            string query = "DELETE FROM trips WHERE id = @id;";

            MySqlCommand sqlCommand = new MySqlCommand(query)
            {
                Connection = new MySqlConnection(Properties.Settings.Default.dice_travelConnString)
            };

            sqlCommand.Parameters.Add("@id", MySqlDbType.Int32);
            sqlCommand.Parameters["@id"].Value = Id;

            RunSqlCommand(sqlCommand);
        }        
        
        //DB Methods

        //misc methods
        public override void Validation()
        {
            if (JourneyId == 0) { throw new ValidationException("Missing journeyId!"); }
            if (EndLocation == "") { throw new ValidationException("Missing Goal location!"); }
        }

    }
}
