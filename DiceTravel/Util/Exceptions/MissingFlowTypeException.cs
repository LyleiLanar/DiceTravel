using System;

namespace DiceTravel.Util
{
    class MissingFlowTypeException : Exception
    {
        public MissingFlowTypeException(string message) : base(message)
        {
            ;
        }
    }
}
