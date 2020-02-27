using DiceTravel.Util;
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

        //Properties
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

        //entityMethods
        static public Journey GetJourney_ById(int id)
        {
            string query = $"SELECT * FROM journeys WHERE id = {id};";
            DataTable dataTable = DBDriver.ReadQuery(query);
            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                return new Journey(dataTable.Rows[0]);
            }
            return null;
        }
        public List<Trip> GetTrips()
        {
            List<Trip> trips = new List<Trip>();
            string getTripsCommand = $"SELECT * FROM trips WHERE journey_id = {Id}";

            DataTable dataTable = DBDriver.ReadQuery(getTripsCommand);

            foreach (DataRow row in dataTable.Rows)
            {
                trips.Add(new Trip(row));
            }

            return trips;
        }
        public void DeleteItself()
        {
            List<Trip> tripsToDelete = GetTrips();

            foreach (Trip trip in tripsToDelete)
            {
                trip.DeleteItself();
            }

            DBDriver.DeleteRow($"DELETE FROM journeys WHERE id = {ActiveUserStore.GetActiveJourneyId()}");
            Program.mainForm.RefreshMainForm();
        }

        //Methods
        public Trip GetLastTrip()
        {
            string lastTripQuery = $"SELECT * FROM trips WHERE journey_id = {this.Id} ORDER BY serial_number DESC LIMIT 1;";

            DataTable dataTable = DBDriver.ReadQuery(lastTripQuery);

            return new Trip(dataTable.Rows[0]);


        }
        public override string GetInsertSql()
        {
            return $"INSERT INTO `dice_travel`.`journeys` (`user_id`, `title`,`start_location`,`start_date`,`closed`,`visibility`) " +
                                   $"VALUES ('{ActiveUserStore.ActiveUser.Id}', '{Title}','{StartLocation}','{StartDate}','{Closed}','{Visibility}');";
        }
        public override string GetTableQueryString()
        {
            return "SELECT * FROM journeys";
        }
        public override void Validation()
        {
            if (UserId == 0) { throw new ValidationException("Missing userID!"); }
            if (Title == "") { throw new ValidationException("Missing title!"); }
            if (StartLocation == "") { throw new ValidationException("Missing Start location!"); }
        }
    }
}
