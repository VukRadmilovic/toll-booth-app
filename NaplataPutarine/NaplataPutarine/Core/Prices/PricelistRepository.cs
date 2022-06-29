using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NaplataPutarine.Core.Prices.Models;
using NaplataPutarine.Core.Database;

namespace NaplataPutarine.Core.Prices
{
    internal class PricelistRepository : Repository
    {
        public List<Price> GetCenovnik()
        {
            List<Price> cenovnik = new List<Price>();

            string getQuery = "SELECT [CENA].IdDeonica, [KategorijaVozila].Naziv, [CENA].Vrednost, [Cena].DatumKreiranja FROM CENA " +
                "LEFT OUTER JOIN KategorijaVozila ON [KategorijaVozila].Id = [CENA].IdKategorija " +
                "ORDER BY [Cena].DatumKreiranja DESC";
            foreach (DataRow row in database.CreateTableOfData(getQuery).Rows)
            {
                Price temp = new Price(Convert.ToInt32(row["IdDeonica"]), row["Naziv"].ToString(), Convert.ToDouble(row["Vrednost"]), 
                    new DateOnly(Convert.ToInt32(row["DatumKreiranja"].ToString().Split('/')[2].Split()[0]), Convert.ToInt32(row["DatumKreiranja"].ToString().Split('/')[0]), Convert.ToInt32(row["DatumKreiranja"].ToString().Split('/')[1]) ));
                if (!cenovnik.Any(x => x.deonica == temp.deonica && x.kategorija == temp.kategorija))
                {
                    cenovnik.Add(temp);
                }
                //MessageBox.Show(Convert.ToInt32(row["DatumKreiranja"].ToString().Split('/')[2].Split()[0]) + " " + Convert.ToInt32(row["DatumKreiranja"].ToString().Split('/')[1]) + " " + Convert.ToInt32(row["DatumKreiranja"].ToString().Split('/')[0]));
            }
            return cenovnik;
        }
    }
}
