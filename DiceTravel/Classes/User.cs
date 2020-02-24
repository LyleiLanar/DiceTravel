using DiceTravel.Classes;
using DiceTravel.Util;
using System;
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
        public bool IsThereActiveJourney()
        {
            int userId = ActiveUserStore.ActiveUser.Id;
            string queryString = $"SELECT count(*) as db FROM dice_travel.journeys WHERE closed = 0 AND user_id = {userId};";

            DataTable table = DBDriver.ReadQuery(queryString);

            if (table.Rows[0]["db"].ToString() == "0")
            {
                return false;
            }
            return true;

        }
        public int GetActiveJourneyId()
        {
            int activeJourneyId = -1;

            if (IsThereActiveJourney())
            {
                int userId = ActiveUserStore.ActiveUser.Id;
                string queryString = $"SELECT id FROM dice_travel.journeys WHERE user_id = {userId};";

                DataTable table = DBDriver.ReadQuery(queryString);
                activeJourneyId = (int)table.Rows[0]["id"];
            }
            return activeJourneyId;
        }
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
        static public User GetAuthenticatedUser(string loginName, string password)
        {
            try
            {
                User user = User.GetUserBy_LoginName(loginName);
                try
                {
                    if (user.Password == password)
                    {
                        return user;
                    }
                }
                catch (IndexOutOfRangeException)
                {
                    return null;
                }
            }
            catch (Exception)
            {
                throw new EntityCreationException("Wrong Login name or Password!");
            }
            return null;
        }
    }
}
