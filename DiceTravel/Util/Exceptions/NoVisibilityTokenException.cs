using System;

namespace DiceTravel.Util.Exceptions
{
    public class NoVisibilityTokenException : Exception
    {
        public NoVisibilityTokenException(string message) : base(message)
        {
            ;
        }
    }
}
