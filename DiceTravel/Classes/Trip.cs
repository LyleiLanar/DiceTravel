using DiceTravel.Util;
using System;
using System.Data;

namespace DiceTravel.Classes
{
    public class Trip : Entity
    {
        public int Id { get; set; }
        public int JourneyId { get; set; }
        public int SerialNumber { get; set; }
        public string EndLocation { get; set; }
        public string EndDate { get; set; }
        public int Visibility { get; set; }

        public Trip(DataRow dataRow)
        {
            Id = Int32.Parse(dataRow["id"].ToString());
            JourneyId = Int32.Parse(dataRow["journey_id"].ToString());
            SerialNumber = Int32.Parse(dataRow["serial_number"].ToString());
            EndLocation = dataRow["end_location"].ToString();
            EndDate = dataRow["end_date"].ToString();
            Visibility = Int32.Parse(dataRow["visibility"].ToString());
        }
        public Trip()
        {
        }

        //entityMethods
        public void DeleteItself()
        {
            string deleteCommand = $"DELETE FROM trips WHERE id = {this.Id}";
            DBDriver.DeleteRow(deleteCommand);
        }
        
        public override string GetInsertSql()
        {
            string activeJourneyId = ActiveUserStore.GetActiveJourneyId().ToString();
            return $"INSERT INTO `dice_travel`.`trips` (`journey_id`, `serial_number`,`end_location`,`end_date`,`visibility`) " +
                                  $"VALUES ('{activeJourneyId}', '{SerialNumber}','{EndLocation}','{EndDate}','{Visibility}');";
        }
        public override string GetTableQueryString()
        {
            return "SELECT * FROM trips";
        }
        public override void Validation()
        {
            if (JourneyId == 0) { throw new ValidationException("Missing journeyId!"); }
            if (EndLocation == "") { throw new ValidationException("Missing Goal location!"); }
        }
    }
}
