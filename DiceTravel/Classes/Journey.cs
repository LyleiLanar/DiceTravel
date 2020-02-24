using DiceTravel.Util;
using System;
using System.Data;

namespace DiceTravel.Classes
{
    class Journey : Entity
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
            Closed = dataRow["closed"].ToString();
            Visibility = dataRow["visibility"].ToString();
        }

        //Properties
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Title { get; set; }
        public string StartLocation { get; set; }
        public string StartDate { get; set; }
        public string Closed { get; set; }
        public string Visibility { get; set; }
        
        //entityMethods
        public Journey GetJourney_ById(int id)
        {
            string query = $"SELECT * FROM journeys WHERE id = {id};";

            return new Journey(DBDriver.ReadQuery(query).Rows[0]);
        }
        public DataTable GetJourneys_ByUser(int userId)
        {
            string query = $"SELECT * FROM journeys WHERE user_id = {userId};";
            return DBDriver.ReadQuery(query);
        }

        //Methods
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
            if (StartLocation == "") { throw new ValidationException("Missing Start location!"); }
        }
    }



}
