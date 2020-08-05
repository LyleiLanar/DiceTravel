using DiceTravel.Util;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace DiceTravel.Classes
{
    public class Journey : Entity
    {
        public Journey()
        {
        }

        public Journey(DataRow dataRow)
        {
            Id = Int32.Parse(dataRow["id"].ToString());
            UserId = Int32.Parse(dataRow["user_id"].ToString());
            Title = dataRow["title"].ToString();
            StartLocation = dataRow["start_location"].ToString();

            string dateString = dataRow["start_date"].ToString();
            DateTime date = DateTime.Parse(dateString);
            StartDate = date.ToString("yyy-MM-dd HH:mm:ss");

            Closed = Int32.Parse(dataRow["closed"].ToString());
            Visibility = Int32.Parse(dataRow["visibility"].ToString());
        }

        //Props
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Title { get; set; }

        public string StartLocation { get; set; }
        public string StartDate { get; set; }
        public int Closed { get; set; }
        public int Visibility { get; set; }
        public string GetVisibilityAsString
        {
            get
            {
                if (Visibility == 2)
                {
                    return "Public";
                }
                if (Visibility == 1)
                {
                    return "OnlyFriends";
                }

                return "Private";
            }
        }

        //CRUD methods
        public override void CreateItself()
        {
            string query = "INSERT INTO `dice_travel`.`journeys` (`user_id`, `title`,`start_location`,`start_date`,`closed`,`visibility`) " +
                                   "VALUES (@user_id, @title, @start_location, @start_date, @closed, @visibility);";
            MySqlCommand sqlCommand = CreateCommand(query);

            sqlCommand.Parameters.Add("@user_id", MySqlDbType.Int32);
            sqlCommand.Parameters.Add("@title", MySqlDbType.VarChar, 50);
            sqlCommand.Parameters.Add("@start_location", MySqlDbType.VarChar, 20);
            sqlCommand.Parameters.Add("@start_date", MySqlDbType.DateTime);
            sqlCommand.Parameters.Add("@closed", MySqlDbType.Int32);
            sqlCommand.Parameters.Add("@visibility", MySqlDbType.Int32);

            sqlCommand.Parameters["@user_id"].Value = ActiveUserStore.ActiveUser.Id;
            sqlCommand.Parameters["@title"].Value = Title;
            sqlCommand.Parameters["@start_location"].Value = StartLocation;
            sqlCommand.Parameters["@start_date"].Value = StartDate;
            sqlCommand.Parameters["@closed"].Value = Closed;
            sqlCommand.Parameters["@visibility"].Value = Visibility;

            RunSqlCommand(sqlCommand);
        }
        static public Journey ReadJourney(MySqlCommand sqlCommand)
        {
            return new Journey(ReadQueryTable(sqlCommand).Rows[0]);
        }
        public override void UpdateItself()
        {
            string query = "UPDATE `dice_travel`.`journeys` SET `user_id`=@user_id, `title`=@title,`start_location`=@start_location,`start_date`=@start_date,`closed`=@closed,`visibility`=@visibility WHERE id = @id";
            MySqlCommand sqlCommand = CreateCommand(query);

            sqlCommand.Parameters.Add("@id", MySqlDbType.Int32);
            sqlCommand.Parameters.Add("@user_id", MySqlDbType.Int32);
            sqlCommand.Parameters.Add("@title", MySqlDbType.VarChar, 50);
            sqlCommand.Parameters.Add("@start_location", MySqlDbType.VarChar, 20);
            sqlCommand.Parameters.Add("@start_date", MySqlDbType.DateTime);
            sqlCommand.Parameters.Add("@closed", MySqlDbType.Int32);
            sqlCommand.Parameters.Add("@visibility", MySqlDbType.Int32);

            sqlCommand.Parameters["@id"].Value = Id;
            sqlCommand.Parameters["@user_id"].Value = UserId;
            sqlCommand.Parameters["@title"].Value = Title;
            sqlCommand.Parameters["@start_location"].Value = StartLocation;
            sqlCommand.Parameters["@start_date"].Value = StartDate;
            sqlCommand.Parameters["@closed"].Value = Closed;
            sqlCommand.Parameters["@visibility"].Value = Visibility;

            RunSqlCommand(sqlCommand);
        }
        public override void DeleteItself()
        {
            List<Trip> tripsToDelete = GetTrips();

            foreach (Trip trip in tripsToDelete)
            {
                trip.DeleteItself();
            }

            string query = "DELETE FROM journeys WHERE id = @id";

            MySqlCommand sqlCommand = new MySqlCommand(query)
            {
                Connection = new MySqlConnection(Properties.Settings.Default.dice_travelConnString)
            };

            sqlCommand.Parameters.Add("@id", MySqlDbType.Int32);
            sqlCommand.Parameters["@id"].Value = Id;

            RunSqlCommand(sqlCommand);
        }

        //DB methods
        public List<Trip> GetTrips()
        {
            string getTripsCommand = $"SELECT * FROM trips WHERE journey_id = @journey_id ORDER BY end_date DESC";
            using (MySqlCommand sqlCommand = CreateCommand(getTripsCommand))
            {
                sqlCommand.Parameters.Add("@journey_id", MySqlDbType.Int32);
                sqlCommand.Parameters["@journey_id"].Value = Id;

                using (DataTable dataTable = ReadQueryTable(sqlCommand))
                {

                    List<Trip> trips = new List<Trip>();
                    foreach (DataRow row in dataTable.Rows)
                    {
                        trips.Add(new Trip(row));
                    }

                    return trips;
                }
            }
        }
        public Trip GetLastTrip()
        {
            string query = $"SELECT * FROM trips WHERE journey_id = @journey_id AND end_date = @end_date ORDER BY serial_number DESC LIMIT 1;";
            MySqlCommand sqlCommand = CreateCommand(query);

            sqlCommand.Parameters.Add("@journey_id", MySqlDbType.Int32);
            sqlCommand.Parameters.Add("@end_date", MySqlDbType.DateTime);
            sqlCommand.Parameters["@journey_id"].Value = Id;
            sqlCommand.Parameters["@end_date"].Value = Properties.Settings.Default.nullDate;

            //MessageBox.Show(Properties.Settings.Default.nullDate);

            DataTable dataTable = ReadQueryTable(sqlCommand);
            if (dataTable.Rows.Count == 0)
            {
                return null;
            }
            return new Trip(dataTable.Rows[0]);
        }

        //misc methods
        public override void Validation()
        {
            if (UserId == 0) { throw new ValidationException("Missing userID!"); }
            if (Title == "") { throw new ValidationException("Missing title!"); }
            if (StartLocation == "") { throw new ValidationException("Missing Start location!"); }
        }
        public void CloseItself()
        {
            Trip trip = this.GetLastTrip();
            trip.ReachDestination();

            this.Closed = 1;
            this.UpdateItself();
        }

        //static methods
        static public Journey GetJourney_ById(int journeyId)
        {
            string query = $"SELECT * FROM journeys WHERE id = @id";
            MySqlCommand sqlCommand = CreateCommand(query);
            sqlCommand.Parameters.Add("@id", MySqlDbType.Int32);
            sqlCommand.Parameters["@id"].Value = journeyId;

            DataTable dataTable = ReadQueryTable(sqlCommand);
            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                return new Journey(dataTable.Rows[0]);
            }
            return null;
        }
    }
}
