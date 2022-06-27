using NaplataPutarine.Core.TollStations.Models;
using NaplataPutarine.Core.Users;
using NaplataPutarine.Core.Users.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaplataPutarine.Core.TollStations.Repositories
{
    internal class NaplatnaStanicaRepository : Repository
    {
        private readonly NaplatnoMestoRepository _naplatnoMestoRepo;
        private readonly KorisnikRepository _korisnikRepo;

        public NaplatnaStanicaRepository()
        {
            _naplatnoMestoRepo = new NaplatnoMestoRepository();
            _korisnikRepo = new KorisnikRepository();
        }

        public List<NaplatnaStanica> GetAllTollStations()
        {
            List<NaplatnaStanica> tollStations = new List<NaplatnaStanica>();
            List<NaplatnoMesto> allTollBooths = _naplatnoMestoRepo.GetAllTollBooths();
            List<Radnik> allWorkers = _korisnikRepo.GetAllWorkers();
            string getQuery = "SELECT [NaplatnaStanica].* " +
                              "FROM [NaplatnaStanica] " +
                              "WHERE IsDeleted = 0";
            foreach (DataRow row in database.CreateTableOfData(getQuery).Rows)
            {
                List<NaplatnoMesto> tollStationBooths = new List<NaplatnoMesto>();
                List<Radnik> tollStationWorkers = new List<Radnik>();
                Radnik boss = null;
                int tollStationId = Convert.ToInt32(row["Id"]);
                int tollStationBossId = Convert.ToInt32(row["IdSef"]);

                foreach (NaplatnoMesto tollBooth in allTollBooths)
                {
                    if (tollBooth.MaticnaNaplatnaStanica.Id == tollStationId)
                    {
                        tollStationBooths.Add(tollBooth);
                    }
                }

                foreach (Radnik worker in allWorkers)
                {
                    if (worker.MestoRada != null && worker.MestoRada.Id == tollStationId)
                    {
                        tollStationWorkers.Add(worker);
                    }
                    if (worker.Id == tollStationBossId)
                    {
                        boss = worker;
                    }
                }

                tollStations.Add(new NaplatnaStanica(tollStationId,
                                                     row["Naziv"].ToString(),
                                                     row["Mesto"].ToString(),
                                                     DateOnly.FromDateTime(DateTime.Parse(row["DatumIzgradnje"].ToString())),
                                                     boss,
                                                     tollStationWorkers,
                                                     tollStationBooths
                                                     ));
            }
            return tollStations;
        }
    }
}
