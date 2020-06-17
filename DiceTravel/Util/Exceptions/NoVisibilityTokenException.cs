using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceTravel.Util.Exceptions
{
    class NoVisibilityTokenException : Exception
    {
        public NoVisibilityTokenException(string message) : base(message)
        {
            ;
        }
    }
}
