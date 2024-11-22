using TollBoothApp.Core;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TollBoothApp.Core.Payments.Models;
using TollBoothApp.Core.TollStations.Models;
using TollBoothApp.Core.Users.Models;

namespace TollBoothApp.Core.Payments.Repositories
{
    internal class UplataRepository : Repository
    {
        public List<Uplata> GetAllPayments()
        {
            List<Uplata> payments = new List<Uplata>();
            string getQuery = "SELECT [Uplata].*, [UplataRadnik].IdRadnik AS IdMisc, [Valuta].Naziv, [TipUplata].Naziv AS TipNaziv " +
                              "FROM [Uplata] " +
                              "LEFT OUTER JOIN [TipUplata] ON [Uplata].Tip = [TipUplata].Id " +
                              "LEFT OUTER JOIN [UplataRadnik] ON [UplataRadnik].IdUplata = [Uplata].Id " +
                              "LEFT OUTER JOIN [Valuta] ON [Uplata].Valuta = [Valuta].Id " +
                              "WHERE [TipUplata].Naziv = 'GOTOVINSKA_UPLATA' " +
                              "UNION " +
                              "SELECT [Uplata].*, [UplataTag].IdTag AS IdMisc, [Valuta].Naziv, [TipUplata].Naziv AS TipNaziv " +
                              "FROM [Uplata] " +
                              "LEFT OUTER JOIN [TipUplata] ON [Uplata].Tip = [TipUplata].Id " +
                              "LEFT OUTER JOIN [UplataTag] ON [UplataTag].IdUplata = [Uplata].Id " +
                              "LEFT OUTER JOIN [Valuta] ON [Uplata].Valuta = [Valuta].Id " +
                              "WHERE [TipUplata].Naziv = 'ELEKTRONSKA_UPLATA'";
            foreach(DataRow row in database.CreateTableOfData(getQuery).Rows)
            {
                switch(row["TipNaziv"].ToString())
                {
                    case "GOTOVINSKA_UPLATA":
                        payments.Add(new GotovinskaUplata(Convert.ToInt32(row["Id"]),
                                                          DateOnly.FromDateTime(DateTime.Parse(row["DatumUplate"].ToString())),
                                                          Convert.ToDouble(row["Iznos"]),
                                                          ValutaEnum.Parse(row["Naziv"].ToString()),
                                                          new NaplatnoMesto(Convert.ToInt32(row["IdNaplatnoMesto"])),
                                                          new Radnik(Convert.ToInt32(row["IdMisc"]))
                                                          ));break;
                    default:
                        payments.Add(new ElektronskaUplata(Convert.ToInt32(row["Id"]),
                                  DateOnly.FromDateTime(DateTime.Parse(row["DatumUplate"].ToString())),
                                  Convert.ToDouble(row["Iznos"]),
                                  ValutaEnum.Parse(row["Naziv"].ToString()),
                                  new NaplatnoMesto(Convert.ToInt32(row["IdNaplatnoMesto"])),
                                  new Tag(Convert.ToInt32(row["IdMisc"]))
                                  ));break;
                }
            }
            return payments;
        }
    }
}
