using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TollBoothApp.Core.TollStations.Models;
using TollBoothApp.Core.Users.Models;

namespace TollBoothApp.Core.Users
{
    internal class KorisnikRepository : Repository
    {
        public List<Radnik> GetAllWorkers()
        {
            List<Radnik> workers = new List<Radnik>();
            string getQuery = "SELECT [Korisnik].*, [KorisnickiNalog].*,[KorisnikTip].Ime AS ImeUloge, ISNULL([NaplatnaStanica].Id, -1) AS NSId, [NaplatnaStanica].Naziv " +
                              "FROM [KorisnickiNalog] " +
                              "LEFT OUTER JOIN [Korisnik] ON [Korisnik].id = [KorisnickiNalog].IdKorisnika " + 
                              "LEFT OUTER JOIN [KorisnikTip] ON [KorisnickiNalog].Uloga = [KorisnikTip].Id " +
                              "LEFT OUTER JOIN [Radnik] ON [Korisnik].id = [Radnik].IdRadnik " + 
                              "LEFT OUTER JOIN [NaplatnaStanica] ON [Radnik].IdNaplatnaStanica = [NaplatnaStanica].Id";
            foreach (DataRow row in database.CreateTableOfData(getQuery).Rows)
            {
                KorisnickiNalog account = new KorisnickiNalog(row["KorisnickoIme"].ToString(),
                                                              row["Lozinka"].ToString(),
                                                              UlogaEnum.Parse(row["ImeUloge"].ToString()));
                NaplatnaStanica workplace = null;
                if(Convert.ToInt32(row["NSId"]) != -1)
                {
                    workplace = new NaplatnaStanica(Convert.ToInt32(row["NSId"]), row["Naziv"].ToString());
                }
                workers.Add(new Radnik(Convert.ToInt32(row["Id"]),
                                     row["Ime"].ToString(),
                                     row["Prezime"].ToString(),
                                     account,
                                     workplace));
            }
            return workers;
        }
    }
}
