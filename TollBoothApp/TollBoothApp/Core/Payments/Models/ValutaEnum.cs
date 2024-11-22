using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TollBoothApp.Core.Payments.Models
{
    internal class ValutaEnum
    {
        public enum Valuta
        {
            RSD,
            EUR,
            USD
        }

        public static Valuta Parse(string literal)
        {
            return (Valuta)Enum.Parse(typeof(Valuta), literal);
        }
    }
}
