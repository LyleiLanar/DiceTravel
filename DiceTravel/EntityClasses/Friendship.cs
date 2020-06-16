using DiceTravel.Classes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceTravel.EntityClasses
{
    class Friendship : Entity
    {

        public int SenderId { get; set; }
        public int GetterId { get; set; }
        public int Accepted { get; set; }

        //constructors
        public Friendship(DataRow dataRow)
        {
            SenderId = Int32.Parse(dataRow["id"].ToString());
            GetterId = Int32.Parse(dataRow["id"].ToString());            
            Accepted = Int32.Parse(dataRow["visibility"].ToString());
        }
        public Friendship()
        {
        }

        public override void CreateItself()
        {
            string query = "INSERT INTO `dice_travel`.`friends` (`sender_id`, `getter_id`,`accepted`) " +
                                    "VALUES (@sender_id,@getter_id,@accepted);";

            MySqlCommand sqlCommand = new MySqlCommand(query)
            {
                Connection = new MySqlConnection(Properties.Settings.Default.dice_travelConnString)
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

        public override void DeleteItself()
        {
            throw new NotImplementedException();
        }

        public override void UpdateItself()
        {
            throw new NotImplementedException();
        }

        public override void Validation()
        {
            throw new NotImplementedException();
        }
    }
}
