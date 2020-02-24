using DiceTravel.Util;
using System;
using System.Data;

namespace DiceTravel.Classes
{
    class Journey : Entity
    {
        //Properties
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Title { get; set; }
        public string StartLocation { get; set; }
        public string StartDate { get; set; }
        public string Closed { get; set; }
        public string Visibility { get; set; }

        public Journey GetJourney_ById(int id)
        {
            throw new NotImplementedException();
        }
        public DataTable GetJourneys_ByUser(int userId)
        {
            throw new NotImplementedException();
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
