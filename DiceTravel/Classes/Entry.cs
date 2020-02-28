using DiceTravel.Util;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DiceTravel.Classes
{
    class Entry : Entity
    {
        public Entry(DataRow dataRow)
        {
            Id = Int32.Parse(dataRow["id"].ToString());
            TripId = Int32.Parse(dataRow["trip_id"].ToString());
            EntryDate = dataRow["entry_date"].ToString();
            Picture = null;
            Comment = dataRow["comment"].ToString();
            Visibility = Int32.Parse(dataRow["visibility"].ToString());
        }

        public int Id { get; set; }
        public int TripId { get; set; }
        public string EntryDate { get; set; }
        public byte[] Picture { get; set; }
        public string Comment { get; set; }
        public int Visibility { get; set; }

        public override string GetInsertSql()
        {
            return $"INSERT INTO `dice_travel`.`entries` (`trip_id`, `entry_date`,`picture`,`comment`,`visibility`) " +
                                    $"VALUES ('{TripId}', '{EntryDate}','{Picture}','{Comment}','{Visibility}');";
        }
        public override string GetTableQueryString()
        {
            return "SELECT * FROM entries";
        }
        public override void Validation()
        {
            throw new NotImplementedException();
        }
    
    
    
    }
}
