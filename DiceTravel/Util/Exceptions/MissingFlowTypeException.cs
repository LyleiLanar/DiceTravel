using System;

namespace DiceTravel.Util
{
    public class MissingFlowTypeException : Exception
    {
        public MissingFlowTypeException(string message) : base(message)
        {
            ;
        }
    }
}
