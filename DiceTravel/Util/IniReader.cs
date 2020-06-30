using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DiceTravel.Util
{
    public class IniReader
    {
        public Dictionary<string, string> Properties { get; }

        public IniReader(string filePath)
        {
            Properties = new Dictionary<string, string>();

            foreach (var row in File.ReadAllLines(filePath))
                Properties.Add(row.Split('=')[0], string.Join("=", row.Split('=').Skip(1).ToArray()));
        }

        public string GetPropertyByName(string propName)
        {
            return Properties[propName];
        }
    }
}
