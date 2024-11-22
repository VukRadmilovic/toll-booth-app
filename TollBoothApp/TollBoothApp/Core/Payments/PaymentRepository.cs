using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using TollBoothApp.Core.Payments.Models;
using TollBoothApp.Core.Prices.Models;

namespace TollBoothApp.Core.Payments
{
    internal class PaymentRepository : Repository
    {
        public List<KategorijaVozila> GetCat()
        {
            List<KategorijaVozila> li = new List<KategorijaVozila>();

            string getQuery = "SELECT Id, Naziv FROM KategorijaVozila";
            foreach (DataRow row in database.CreateTableOfData(getQuery).Rows)
            {
                li.Add(new KategorijaVozila(Convert.ToInt32(row["Id"]), row["Naziv"].ToString()));
            }

            return li;
        }

        public List<Kartica> GetCards()
        {
            List<Kartica> cards = new List<Kartica>();
            string getQuery = "SELECT [NaplatnoMesto].IdNaplatnaStanica, [Kartica].Izdavanje, [Kartica].RegistarskaOznaka " +
                "From Kartica " +
                "LEFT OUTER JOIN NaplatnoMesto ON [NaplatnoMesto].Id = [Kartica].IdNaplatnomesto ";

            foreach (DataRow row in database.CreateTableOfData(getQuery).Rows)
            {
                int year = Convert.ToInt32(row["Izdavanje"].ToString().Split('/')[2].Split()[0]);
                int month = Convert.ToInt32(row["Izdavanje"].ToString().Split('/')[0]);
                int day = Convert.ToInt32(row["Izdavanje"].ToString().Split('/')[1]);
                string time = row["Izdavanje"].ToString().Split('/')[2].Split()[1].Trim();
                Kartica temp = new Kartica(new DateTime(year, month, day, Convert.ToInt32(time.Split(":")[0]), Convert.ToInt32(time.Split(":")[1]), Convert.ToInt32(time.Split(":")[2])), row["RegistarskaOznaka"].ToString(), Convert.ToInt32(row["IdNaplatnaStanica"]));
                cards.Add(temp);
            }
            return cards;
        }

        internal double Kurs(Kartica start, TollStations.Models.NaplatnaStanica stanica, int type)
        {
            string getDeonica = "SELECT Id FROM Deonica WHERE IdPocetnaStanica = @Pocetna AND IdZavrsnaStanica = @Zavrsna";
            DataTable dt = database.CreateTableOfData(getDeonica, ("@Pocetna", start.naplatnoMesto), ("@Zavrsna", stanica.Id));
            DataRow dr;
            if(dt.Rows.Count > 0)
            {
                dr = dt.Rows[0];
            }
            else
            {
                return -1;
            }

            string getQuery = "SELECT Vrednost FROM CENA " +
                "WHERE IdDeonica = @Deonica AND IdKategorija = @Kat " +
                "ORDER BY DatumKreiranja DESC";

            dt = database.CreateTableOfData(getQuery, ("@Deonica", Convert.ToInt32(dr["Id"])), ("@Kat", type));
            if (dt.Rows.Count > 0)
            {
                return Convert.ToDouble(dt.Rows[0]["Vrednost"]);
            }
            else
            {
                return -1;
            }
        }

        internal double AvgSpeed(Kartica start, TollStations.Models.NaplatnaStanica stanica, DateTime stop)
        {
            string getQuery = "SELECT Duzina FROM Deonica WHERE IdPocetnaStanica = @Pocetna AND IdZavrsnaStanica = @Zavrsna";

            DataTable dt = database.CreateTableOfData(getQuery, ("@Pocetna", start.naplatnoMesto), ("@Zavrsna", stanica.Id));
            DataRow row;
            if (dt.Rows.Count > 0)
            {
                row = dt.Rows[0];
            }
            else
            {
                return -1;
            }

            return Convert.ToDouble(row["Duzina"]) / Math.Floor((stop.ToUniversalTime() - start.datumVremeIzdavanja.ToUniversalTime()).TotalSeconds) * 3600;
        }
    }
}
