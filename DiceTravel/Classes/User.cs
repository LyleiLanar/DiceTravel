using DiceTravel.Classes;
using DiceTravel.Util;
using System;
using System.Collections.Generic;
using System.Data;

namespace DiceTravel
{
    public class User : Entity
    {
        //props
        public int Id { get; set; }
        public string Password { get; set; }
        public string LoginName { get; set; }
        public string Surname { get; set; }
        public string Firstname { get; set; }
        public string BirthDate { get; set; }

        //constructors
        public User(DataRow dataRow)
        {
            Id = Int32.Parse(dataRow["id"].ToString());
            Password = dataRow["pswd"].ToString();
            LoginName = dataRow["login_name"].ToString();
            Surname = dataRow["sur_name"].ToString();
            Firstname = dataRow["first_name"].ToString();
            BirthDate = dataRow["birth_date"].ToString();
        }
        public User()
        {

        }

        //methods

        public override string GetInsertSql()
        {
            return $"INSERT INTO `dice_travel`.`users` (`login_name`, `pswd`,`sur_name`,`first_name`,`birth_date`) " +
                                    $"VALUES ('{LoginName}', '{Password}','{Surname}','{Firstname}','{BirthDate}');";

        }
        public override string GetTableQueryString()
        {
            return "SELECT * FROM users";
        }
        public override void Validation()
        {
            if (LoginName == "") { throw new ValidationException("Missing 'Login Name'!"); }
        }
        public List<Journey> GetJourneys()
        {
            List<Journey> journeys = new List<Journey>();
            string getJourneyCommand = $"SELECT * FROM journeys WHERE user_id = {Id};";
            DataTable dataTable = DBDriver.ReadQuery(getJourneyCommand);

            foreach (DataRow row in dataTable.Rows)
            {
                journeys.Add(new Journey(row));
            }

            return journeys;
        }
        public Journey GetActiveJourney()
        {
            Journey activeJourney = null;

            if (IsThereActiveJourney())
            {
                string queryString = $"SELECT * FROM dice_travel.journeys WHERE user_id = {this.Id};";

                DataTable table = DBDriver.ReadQuery(queryString);
                activeJourney = new Journey(table.Rows[0]);
            }
            return activeJourney;
        }
        public bool IsThereActiveJourney()
        {
            string queryString = $"SELECT count(*) as db FROM dice_travel.journeys WHERE closed = 0 AND user_id = {this.Id};";
            DataTable table = DBDriver.ReadQuery(queryString);

            if (table.Rows[0]["db"].ToString() == "0")
            {
                return false;
            }
            return true;
        }

        //static methods
        static public User GetUser_ById(int id)
        {
            string query = $"SELECT * FROM users WHERE id = {id}";
            DataTable table = DBDriver.ReadQuery(query);
            return new User(table.Rows[0]);
        }
        static public User GetUserBy_LoginName(string loginName)
        {
            string query = $"SELECT * FROM users WHERE login_name like '{loginName}'";
            DataTable table = DBDriver.ReadQuery(query);
            return new User(table.Rows[0]);
        }
    }
}
