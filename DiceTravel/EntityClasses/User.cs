using DiceTravel.Classes;
using DiceTravel.EntityClasses;
using DiceTravel.Util;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace DiceTravel
{
    public class User : Entity
    {
        //Properties
        public int Id { get; set; }
        public string Password { get; set; }
        public string LoginName { get; set; }
        public string Surname { get; set; }
        public string Firstname { get; set; }
        public string BirthDate { get; set; }

        //Constructors
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

        //Create, Update, Delete methods
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
            sqlCommand.Dispose();
        }
        public override void UpdateItself()
        {
            string query = "UPDATE `dice_travel`.`users` SET `login_name`=@login_name, `pswd`=@pswd,`sur_name`=@sur_name,`first_name`=@first_name,`birth_date`=@birth_date " +
                "WHERE id = @id"; ;

            MySqlCommand sqlCommand = new MySqlCommand(query)
            {
                Connection = new MySqlConnection(Properties.Settings.Default.dice_travelConnString)
            };

            sqlCommand.Parameters.Add("@id", MySqlDbType.Int32);
            sqlCommand.Parameters.Add("@login_name", MySqlDbType.VarChar, 20);
            sqlCommand.Parameters.Add("@pswd", MySqlDbType.VarChar, 32);
            sqlCommand.Parameters.Add("@sur_name", MySqlDbType.VarChar, 20);
            sqlCommand.Parameters.Add("@first_name", MySqlDbType.VarChar, 1);
            sqlCommand.Parameters.Add("@birth_date", MySqlDbType.Date);

            sqlCommand.Parameters["@id"].Value = Id;
            sqlCommand.Parameters["@login_name"].Value = LoginName;
            sqlCommand.Parameters["@pswd"].Value = Password;
            sqlCommand.Parameters["@sur_name"].Value = Surname;
            sqlCommand.Parameters["@first_name"].Value = Firstname;
            sqlCommand.Parameters["@birth_date"].Value = BirthDate;

            RunSqlCommand(sqlCommand);
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

        //Read methods
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
            using (MySqlCommand sqlCommand = CreateCommand(query))
            {
                sqlCommand.Parameters.Add("@Id", MySqlDbType.Int32);
                sqlCommand.Parameters["@Id"].Value = Id;

                using (DataTable table = ReadQueryTable(sqlCommand))
                {
                    if (table.Rows.Count == 0)
                    {
                        return null;
                    }
                    activeJourney = new Journey(table.Rows[0]);

                    return activeJourney;
                }
            }
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

            using (MySqlCommand sqlCommand = CreateCommand(getTripsCommand))
            {
                sqlCommand.Parameters.Add("@user_id", MySqlDbType.Int32);
                sqlCommand.Parameters["@user_id"].Value = Id;

                using (DataTable dataTable = ReadQueryTable(sqlCommand))
                {
                    List<Entry> entries = new List<Entry>();

                    foreach (DataRow row in dataTable.Rows)
                    {
                        entries.Add(new Entry(row));
                    }

                    return entries;
                }
            }
        }
        public List<User> GetFriends()
        {
            List<Friendship> friendships = Friendship.GetActiveFriendshipsByUserId(Id);

            List<User> friends = new List<User>();

            foreach (Friendship friendship in friendships)
            {
                if (friendship.SenderId == Id)
                {
                    friends.Add(User.GetUserById(friendship.GetterId));
                }
                else
                {
                    friends.Add(User.GetUserById(friendship.SenderId));
                }
            }
            return friends;
        }

        //Validation
        public override void Validation()
        {
            if (LoginName == "") { throw new ValidationException("Missing 'Login Name'!"); }
        }

        //Static Read methods
        static public User GetUserById(int id)
        {
            string query = $"SELECT * FROM users WHERE id = @Id";
            MySqlCommand sqlCommand = CreateCommand(query);
            sqlCommand.Parameters.Add("@Id", MySqlDbType.Int32);
            sqlCommand.Parameters["@Id"].Value = id;

            DataTable table = ReadQueryTable(sqlCommand);
            return new User(table.Rows[0]);
        }
        static public User GetUserByLoginName(string loginName)
        {
            string query = $"SELECT * FROM users WHERE login_name like @login_name";
            MySqlCommand sqlCommand = CreateCommand(query);
            sqlCommand.Parameters.Add("@login_name", MySqlDbType.VarChar, 20);
            sqlCommand.Parameters["@login_name"].Value = loginName;

            DataTable table = ReadQueryTable(sqlCommand);
            return new User(table.Rows[0]);
        }
        internal static List<User> SearchForUsersByLoginNameFragment(string loginNameFragment)
        {
            string query = $"SELECT * FROM dice_travel.users WHERE (login_name like @Fragment) and (id != @ActiveId) limit 10";
            MySqlCommand sqlCommand = CreateCommand(query);
            sqlCommand.Parameters.Add("@Fragment", MySqlDbType.VarChar);
            sqlCommand.Parameters["@Fragment"].Value = $"%{loginNameFragment}%";
            sqlCommand.Parameters.Add("@ActiveId", MySqlDbType.Int32);
            sqlCommand.Parameters["@ActiveId"].Value = ActiveUserStore.ActiveUser.Id;

            DataTable table = ReadQueryTable(sqlCommand);

            List<User> users = new List<User>();

            foreach (DataRow row in table.Rows)
            {
                users.Add(new User(row));
            }

            sqlCommand.Dispose();
            table.Dispose();

            return users;
        }
        internal static bool AreFriends(User thisUser, User thatUser)
        {
            string query = $"" +
                $"SELECT * " +
                $"FROM dice_travel.friends " +
                $"WHERE (sender_id = @ThisId and getter_id = @ThatId) or (sender_id = @ThatId and getter_id = @ThisId) having accepted = 1;";

            using (MySqlCommand sqlCommand = CreateCommand(query))
            {
                sqlCommand.Parameters.Add("@ThisId", MySqlDbType.Int32);
                sqlCommand.Parameters["@ThisId"].Value = thisUser.Id;
                sqlCommand.Parameters.Add("@ThatId", MySqlDbType.Int32);
                sqlCommand.Parameters["@ThatId"].Value = thatUser.Id;

                using (DataTable table = ReadQueryTable(sqlCommand))
                {
                    if (table.Rows.Count == 0)
                    {
                        return false;
                    }
                    return true;
                }
            }
        }
        internal static bool AreMakingFriendship(User thisUser, User thatUser)
        {
            string query = $"" +
                $"SELECT * " +
                $"FROM dice_travel.friends " +
                $"WHERE (sender_id = @ThisId and getter_id = @ThatId) or (sender_id = @ThatId and getter_id = @ThisId) having accepted = 0;";

            using (MySqlCommand sqlCommand = CreateCommand(query))
            {
                sqlCommand.Parameters.Add("@ThisId", MySqlDbType.Int32);
                sqlCommand.Parameters["@ThisId"].Value = thisUser.Id;
                sqlCommand.Parameters.Add("@ThatId", MySqlDbType.Int32);
                sqlCommand.Parameters["@ThatId"].Value = thatUser.Id;

                using (DataTable table = ReadQueryTable(sqlCommand))
                {
                    if (table.Rows.Count == 0)
                    {
                        return false;
                    }
                    return true;
                }
            }
        }

    }
}
