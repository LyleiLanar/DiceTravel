using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace DiceTravel
{
    public class User
    {
        public string Id { get; }
        public string LoginName { get; }
        public string Surname { get; }
        public string Firstname { get; }
        public string BirthDate { get; }

        public User(string id, string loginName, string surname, string firstname, string birthDate)
        {
            Id = id;
            LoginName = loginName;
            Surname = surname;
            Firstname = firstname;
            BirthDate = birthDate;
        }

        static public User GetAuthenticatedUser(string loginName, string password)
        {
            String sql = $"SELECT * FROM users WHERE login_name LIKE '{loginName}'";
            String connString = Properties.Settings.Default.dice_travelConnString;

            DataTable table = new DataTable();
            MySqlDataAdapter dptr = new MySqlDataAdapter(sql, connString);

            dptr.Fill(table);
            try
            {
                DataRow userRow = table.Rows[0];
                if (userRow["pswd"].ToString() == password)
                {
                    return new User(userRow["id"].ToString(), userRow["login_name"].ToString(), userRow["sur_name"].ToString(), userRow["first_name"].ToString(), userRow["birth_date"].ToString());
                }
            }
            catch (IndexOutOfRangeException)
            {
                return null;
            }
            return null;
        }
    }
}
