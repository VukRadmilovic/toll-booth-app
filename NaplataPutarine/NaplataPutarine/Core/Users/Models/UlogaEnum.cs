using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaplataPutarine.Core.Users.Models
{
    internal class UlogaEnum
    {
        public enum Uloga
        {
            MENADZER,
            SEF_STANICE,
            RADNIK_MESTA,
            ADMINISTRATOR
        };

        public static Uloga Parse(string literal)
        {
            return (Uloga)Enum.Parse(typeof(Uloga), literal);
        }
    }
}
