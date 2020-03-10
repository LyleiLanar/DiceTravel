using DiceTravel.Classes;
using DiceTravel.Util;
using MySql.Data.MySqlClient;
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

        //CRUD
        public override void CreateItself()
        {
            string query = "INSERT INTO `dice_travel`.`users` (`login_name`, `pswd`,`sur_name`,`first_name`,`birth_date`) " +
                                    $"VALUES (@login_name,@pswd,@sur_name,@first_name,@birth_date);";

            MySqlCommand sqlCommand = new MySqlCommand(query)
            {
                Connection = new MySqlConnection(Properties.Settings.Default.dice_travelConnString)
            };

            sqlCommand.Parameters.Add("@login_name", MySqlDbType.VarChar, 20);
            sqlCommand.Parameters.Add("@pswd", MySqlDbType.VarChar, 32);
            sqlCommand.Parameters.Add("@sur_name", MySqlDbType.VarChar, 20);
            sqlCommand.Parameters.Add("@first_name", MySqlDbType.VarChar, 1);
            sqlCommand.Parameters.Add("@birth_date", MySqlDbType.Date);

            sqlCommand.Parameters["@login_name"].Value = LoginName;
            sqlCommand.Parameters["@pswd"].Value = Password;
            sqlCommand.Parameters["@sur_name"].Value = Surname;
            sqlCommand.Parameters["@first_name"].Value = Firstname;
            sqlCommand.Parameters["@birth_date"].Value = BirthDate;

            RunSqlCommand(sqlCommand);
        }
        static public User ReadUser(MySqlCommand sqlCommand)
        {
            return new User(ReadQueryTable(sqlCommand).Rows[0]);
        }
        public override void UpdateItself()
        {
            throw new NotImplementedException();
        }
        public override void DeleteItself()
        {
            string query = "DELETE FROM users WHERE id = @id";

            MySqlCommand sqlCommand = new MySqlCommand(query)
            {
                Connection = new MySqlConnection(Properties.Settings.Default.dice_travelConnString)
            };
            sqlCommand.Parameters.Add("@id", MySqlDbType.Int32);
            sqlCommand.Parameters["@id"].Value = this.Id;

            RunSqlCommand(sqlCommand);
        }

        //entity methods

        public List<Journey> GetJourneys()
        {
            string getTripsCommand = $"SELECT * FROM dice_travel.journeys WHERE user_id = @user_id ORDER BY start_date DESC";
            MySqlCommand sqlCommand = CreateCommand(getTripsCommand);
            sqlCommand.Parameters.Add("@user_id", MySqlDbType.Int32);
            sqlCommand.Parameters["@user_id"].Value = Id;

            DataTable dataTable = ReadQueryTable(sqlCommand);

            List<Journey> journeys = new List<Journey>();
            foreach (DataRow row in dataTable.Rows)
            {
                journeys.Add(new Journey(row));
            }

            return journeys;
        }
        public Journey GetActiveJourney()
        {
            Journey activeJourney;

            string query = $"SELECT * FROM dice_travel.journeys WHERE user_id = @Id and closed = 0;";
            MySqlCommand sqlCommand = CreateCommand(query);
            sqlCommand.Parameters.Add("@Id", MySqlDbType.Int32);
            sqlCommand.Parameters["@Id"].Value = Id;

            DataTable table = ReadQueryTable(sqlCommand);
            if (table.Rows.Count == 0)
            {
                return null;
            }
            activeJourney = new Journey(table.Rows[0]);

            return activeJourney;
        }
        public bool IsThereActiveJourney()
        {
            string query = $"SELECT count(*) as db FROM dice_travel.journeys WHERE closed = 0 AND user_id = @Id;";
            MySqlCommand sqlCommand = CreateCommand(query);
            sqlCommand.Parameters.Add("@Id", MySqlDbType.Int32);
            sqlCommand.Parameters["@Id"].Value = Id;

            DataTable table = ReadQueryTable(sqlCommand);

            if (table.Rows[0]["db"].ToString() == "0")
            {
                return false;
            }
            return true;
        }

        public List<Entry> GetAllEntries()
        {
            string getTripsCommand = "SELECT * FROM dice_travel.entries " +
                "INNER JOIN dice_travel.trips on entries.trip_id = trips.id " +
                "INNER JOIN dice_travel.journeys on trips.journey_id = journeys.id " +
                "WHERE journeys.user_id = @user_id ORDER BY entries.entry_date; ";

            MySqlCommand sqlCommand = CreateCommand(getTripsCommand);
            sqlCommand.Parameters.Add("@user_id", MySqlDbType.Int32);
            sqlCommand.Parameters["@user_id"].Value = Id;

            DataTable dataTable = ReadQueryTable(sqlCommand);
            List<Entry> entries = new List<Entry>();

            foreach (DataRow row in dataTable.Rows)
            {
                entries.Add(new Entry(row));
            }

            return entries;
        }
        //misc methods
        public override void Validation()
        {
            if (LoginName == "") { throw new ValidationException("Missing 'Login Name'!"); }
        }

        //static methods
        static public User GetUser_ById(int id)
        {
            string query = $"SELECT * FROM users WHERE id = @Id";
            MySqlCommand sqlCommand = CreateCommand(query);
            sqlCommand.Parameters.Add("@Id", MySqlDbType.Int32);
            sqlCommand.Parameters["@Id"].Value = id;

            DataTable table = ReadQueryTable(sqlCommand);
            return new User(table.Rows[0]);
        }
        static public User GetUserBy_LoginName(string loginName)
        {
            string query = $"SELECT * FROM users WHERE login_name like @login_name";
            MySqlCommand sqlCommand = CreateCommand(query);
            sqlCommand.Parameters.Add("@login_name", MySqlDbType.VarChar, 20);
            sqlCommand.Parameters["@login_name"].Value = loginName;

            DataTable table = ReadQueryTable(sqlCommand);
            return new User(table.Rows[0]);
        }

    }
}
