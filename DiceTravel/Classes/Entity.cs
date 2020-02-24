using System.Data;

namespace DiceTravel.Classes
{
    abstract public class Entity
    {
        //methods
        abstract public void Validation();
        abstract public string GetInsertSql();
        abstract public string GetTableQueryString();

    }
}
