using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaplataPutarine
{
    internal class InvalidInputException : Exception
    {
        public InvalidInputException(string message) : base(message) { }
    }
}
