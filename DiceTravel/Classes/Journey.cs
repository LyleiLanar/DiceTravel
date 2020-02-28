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
            StartDate = dataRow["start_date"].ToString();
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
            throw new NotImplementedException();
        }   
        public override void DeleteItself()
        {
            List<Trip> tripsToDelete = GetTrips();

            foreach (Trip trip in tripsToDelete)
            {
                trip.DeleteItself();
            }

            string query = "DELETE FROM journeys WHERE id = @id";

            MySqlCommand sqlCommand = new MySqlCommand(query);
            sqlCommand.Connection = new MySqlConnection(Properties.Settings.Default.dice_travelConnString);
            sqlCommand.Parameters.Add("@id", MySqlDbType.Int32);
            sqlCommand.Parameters["@id"].Value = ActiveUserStore.GetActiveJourney().Id;

            RunSqlCommand(sqlCommand);
        }

        //DB methods
        public override string GetInsertSql()
        {
            return $"INSERT INTO `dice_travel`.`journeys` (`user_id`, `title`,`start_location`,`start_date`,`closed`,`visibility`) " +
                                   $"VALUES ('{ActiveUserStore.ActiveUser.Id}', '{Title}','{StartLocation}','{StartDate}','{Closed}','{Visibility}');";
        }
        public override string GetTableQueryString()
        {
            return "SELECT * FROM journeys";
        }
        public List<Trip> GetTrips()
        {
            string getTripsCommand = $"SELECT * FROM trips WHERE journey_id = @journey_id";
            MySqlCommand sqlCommand = CreateCommand(getTripsCommand);
            sqlCommand.Parameters.Add("@journey_id", MySqlDbType.Int32);
            sqlCommand.Parameters["@journey_id"].Value = Id;
            
            DataTable dataTable = ReadQueryTable(sqlCommand);

            List<Trip> trips = new List<Trip>();
            foreach (DataRow row in dataTable.Rows)
            {
                trips.Add(new Trip(row));
            }

            return trips;
        }
        public Trip GetLastTrip()
        {
            string query = $"SELECT * FROM trips WHERE journey_id = @journey_id ORDER BY serial_number DESC LIMIT 1;";
            MySqlCommand sqlCommand = CreateCommand(query);

            sqlCommand.Parameters.Add("@journey_id", MySqlDbType.Int32);
            sqlCommand.Parameters["@journey_id"].Value = Id;

            DataTable dataTable = ReadQueryTable(sqlCommand);
            return new Trip(dataTable.Rows[0]);
        }

        //misc methods
        public override void Validation()
        {
            if (UserId == 0) { throw new ValidationException("Missing userID!"); }
            if (Title == "") { throw new ValidationException("Missing title!"); }
            if (StartLocation == "") { throw new ValidationException("Missing Start location!"); }
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
