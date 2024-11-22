using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TollBoothApp.Core.Prices.Models
{
    internal class Price
    {
        public int deonica { get; set; }
        public string kategorija { get; set; }
        public double vrednost { get; set; }
        public DateOnly date { get; set; }

        public Price(int deonica, string kategorija, double vrednost, DateOnly date)
        {
            this.deonica = deonica;
            this.kategorija = kategorija;
            this.vrednost = vrednost;
            this.date = date;
        }
    }
}
