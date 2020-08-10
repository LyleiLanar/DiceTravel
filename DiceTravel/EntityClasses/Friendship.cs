using DiceTravel.Classes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace DiceTravel.EntityClasses
{
    class Friendship : Entity
    {
        //Properties
        public int SenderId { get; set; }
        public int GetterId { get; set; }
        public int Accepted { get; set; }

        //Constructors
        public Friendship(DataRow dataRow)
        {
            SenderId = int.Parse(dataRow["sender_id"].ToString());
            GetterId = int.Parse(dataRow["getter_id"].ToString());
            Accepted = int.Parse(dataRow["accepted"].ToString());
        }
        public Friendship(int senderId, int getterId, int accepted)
        {
            SenderId = senderId;
            GetterId = getterId;
            Accepted = accepted;
        }

        //Create, Update, Delete methods
        public override void CreateItself()
        {
            string query = "INSERT INTO `dice_travel`.`friends` (`sender_id`, `getter_id`,`accepted`) " +
                                    "VALUES (@sender_id,@getter_id,@accepted);";

            MySqlCommand sqlCommand = new MySqlCommand(query)
            {
                Connection = new MySqlConnection(connString)
            };

            sqlCommand.Parameters.Add("@sender_id", MySqlDbType.Int32);
            sqlCommand.Parameters.Add("@getter_id", MySqlDbType.Int32);
            sqlCommand.Parameters.Add("@accepted", MySqlDbType.Int32);

            sqlCommand.Parameters["@sender_id"].Value = SenderId;
            sqlCommand.Parameters["@getter_id"].Value = GetterId;
            sqlCommand.Parameters["@accepted"].Value = Accepted;


            RunSqlCommand(sqlCommand);
            sqlCommand.Dispose();
        }
        public override void UpdateItself()
        {
            string query = "UPDATE `dice_travel`.`friends` SET `accepted` = @Accepted WHERE (`sender_id` = @Sender_id) and (`getter_id` = @Getter_id)";

            MySqlCommand sqlCommand = new MySqlCommand(query)
            {
                Connection = new MySqlConnection(connString)
            };

            sqlCommand.Parameters.Add("@Sender_id", MySqlDbType.Int32);
            sqlCommand.Parameters.Add("@Getter_id", MySqlDbType.Int32);
            sqlCommand.Parameters.Add("@Accepted", MySqlDbType.Int32);

            sqlCommand.Parameters["@Sender_id"].Value = SenderId;
            sqlCommand.Parameters["@Getter_id"].Value = GetterId;
            sqlCommand.Parameters["@Accepted"].Value = Accepted;


            RunSqlCommand(sqlCommand);
            sqlCommand.Dispose();
        }
        public override void DeleteItself()
        {
            string query = "DELETE FROM friends WHERE sender_id = @Id1 AND getter_id = @Id2";

            MySqlCommand sqlCommand = new MySqlCommand(query)
            {
                Connection = new MySqlConnection(connString)
            };

            sqlCommand.Parameters.Add("@Id1", MySqlDbType.Int32);
            sqlCommand.Parameters["@Id1"].Value = SenderId;
            sqlCommand.Parameters.Add("@Id2", MySqlDbType.Int32);
            sqlCommand.Parameters["@Id2"].Value = GetterId;

            RunSqlCommand(sqlCommand);
            sqlCommand.Dispose();
        }

        //Validation
        public override void Validation()
        {
            throw new NotImplementedException();
        }

        //Static Read methods
        static public Friendship GetFriendshipByIds(int id1, int id2)
        {
            string query = $"SELECT * FROM friends WHERE (sender_id = @Id1 AND getter_id = @Id2) OR (sender_id = @Id2 AND getter_id = @Id1)";
            using (MySqlCommand sqlCommand = CreateCommand(query))
            {

                sqlCommand.Parameters.Add("@Id1", MySqlDbType.Int32);
                sqlCommand.Parameters["@Id1"].Value = id1;
                sqlCommand.Parameters.Add("@Id2", MySqlDbType.Int32);
                sqlCommand.Parameters["@Id2"].Value = id2;

                using (DataTable dataTable = ReadQueryTable(sqlCommand))
                {

                    if (dataTable != null && dataTable.Rows.Count > 0)
                    {
                        return new Friendship(dataTable.Rows[0]);
                    }

                    return null;
                }
            }
        }
        static public List<Friendship> GetRecievedFriendshipInvitesByUserId(int id)
        {
            string query = "SELECT * FROM dice_travel.friends " +
                "WHERE friends.getter_id = @Getter_id and friends.accepted = 0";

            using (MySqlCommand sqlCommand = CreateCommand(query))
            {
                sqlCommand.Parameters.Add("@Getter_id", MySqlDbType.Int32);
                sqlCommand.Parameters["@Getter_id"].Value = id;

                using (DataTable dataTable = ReadQueryTable(sqlCommand))
                {
                    List<Friendship> gotInvites = new List<Friendship>();

                    foreach (DataRow row in dataTable.Rows)
                    {
                        gotInvites.Add(new Friendship(row));
                    }
                    return gotInvites;
                }
            }
        }
        static public List<Friendship> GetActiveFriendshipsByUserId(int id)
        {
            string query = "SELECT * FROM dice_travel.friends " +
                 "WHERE (friends.getter_id = @User_id or friends.sender_id = @User_id) and friends.accepted = 1";

            using (MySqlCommand sqlCommand = CreateCommand(query))
            {
                sqlCommand.Parameters.Add("@User_id", MySqlDbType.Int32);
                sqlCommand.Parameters["@User_id"].Value = id;

                using (DataTable dataTable = ReadQueryTable(sqlCommand))
                {
                    List<Friendship> gotInvites = new List<Friendship>();

                    foreach (DataRow row in dataTable.Rows)
                    {
                        gotInvites.Add(new Friendship(row));
                    }
                    return gotInvites;
                }
            }

        }
    }
}
