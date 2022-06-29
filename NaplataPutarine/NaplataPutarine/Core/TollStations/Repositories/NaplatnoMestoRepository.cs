using NaplataPutarine.Core.Devices;
using NaplataPutarine.Core.Devices.Models;
using NaplataPutarine.Core.TollStations.Models;
using NaplataPutarine.Core.Users;
using NaplataPutarine.Core.Users.Models;
using NaplataPutarine.Core.Utilities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaplataPutarine.Core.TollStations.Repositories
{
    internal class NaplatnoMestoRepository : Repository
    {
        private readonly UredjajRepository _uredjajRepository;

        public NaplatnoMestoRepository()
        {
            _uredjajRepository = new UredjajRepository();
        }

        public List<NaplatnoMesto> GetAllTollBooths()
        {
            List<NaplatnoMesto> tollBooths = new List<NaplatnoMesto>();
            List<Uredjaj> allDevices = _uredjajRepository.GetAllDevices();
            string getQuery = "SELECT [NaplatnoMesto].* " +
                              "FROM [NaplatnoMesto] " +
                              "WHERE IsDeleted = 0";
            foreach (DataRow row in database.CreateTableOfData(getQuery).Rows)
            {
                int tollBoothId = Convert.ToInt32(row["Id"]);
                List<Uredjaj> tollBoothDevices = new List<Uredjaj>();
                foreach (Uredjaj device in allDevices)
                {
                    if (device.NaplatnoMestoUredjaja.Id == tollBoothId)
                    {
                        tollBoothDevices.Add(device);
                    }
                }
                tollBooths.Add(new NaplatnoMesto(tollBoothId, new NaplatnaStanica(Convert.ToInt32(row["IdNaplatnaStanica"])), tollBoothDevices));
            }
            return tollBooths;
        }

        public List<NaplatnoMesto> Get(int stanicaID)
        {
            List<NaplatnoMesto> tollBooths = new List<NaplatnoMesto>();
            List<Uredjaj> allDevices = _uredjajRepository.GetAllDevices();
            string getQuery = "SELECT [NaplatnoMesto].* " +
                              "FROM [NaplatnoMesto] " +
                              "WHERE IsDeleted = 0 AND IdNaplatnaStanica = @id";
            foreach (DataRow row in database.CreateTableOfData(getQuery, ("@id", stanicaID)).Rows)
            {
                int tollBoothId = Convert.ToInt32(row["Id"]);
                List<Uredjaj> tollBoothDevices = new List<Uredjaj>();
                foreach (Uredjaj device in allDevices)
                {
                    if (device.NaplatnoMestoUredjaja.Id == tollBoothId)
                    {
                        tollBoothDevices.Add(device);
                    }
                }
                tollBooths.Add(new NaplatnoMesto(tollBoothId, new NaplatnaStanica(Convert.ToInt32(row["IdNaplatnaStanica"])), tollBoothDevices));
            }
            return tollBooths;
        }

        public void Add(int stanicaID, List<Uredjaj> uredjaji)
        {
            try
            {
                string mestoIDQuery = "SELECT max(ID) AS maxID " +
                                        "FROM [NaplatnoMesto]";
                int mestoID = Convert.ToInt32(database.CreateTableOfData(mestoIDQuery).Rows[0]["maxID"]) + 1;

                string query = "INSERT INTO [NaplatnoMesto] " +
                                    "(Id, IdNaplatnaStanica, isDeleted) " +
                                    "values(@mestoID, @stanicaID, 0)";
                database.ExecuteNonQueryCommand(query, ("@mestoID", mestoID), ("@stanicaID", stanicaID));
                
                _uredjajRepository.Add(mestoID, uredjaji);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Update(int mestoID, List<Uredjaj> uredjaji)
        {
            try
            {
                List<Uredjaj> sviUredjaji = _uredjajRepository.GetAllDevices();
                List<Uredjaj> uredjajiZaBrisanje = new List<Uredjaj>();
                foreach (Uredjaj postojeciUredjaj in sviUredjaji)
                {
                    if (postojeciUredjaj.NaplatnoMestoUredjaja.Id != mestoID)
                    {
                        continue;
                    }
                    bool pronadjen = false;
                    foreach (Uredjaj novUredjaj in uredjaji.ToList())
                    {
                        if (postojeciUredjaj.GetType() == novUredjaj.GetType())
                        {
                            pronadjen = true;
                            uredjaji.Remove(novUredjaj);
                            break;
                        }
                    }
                    if (!pronadjen)
                    {
                        uredjajiZaBrisanje.Add(postojeciUredjaj);
                    }
                }
                foreach (Uredjaj uredjaj in uredjajiZaBrisanje)
                {
                    _uredjajRepository.Delete(uredjaj.Id);
                }
                _uredjajRepository.Add(mestoID, uredjaji);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Delete(int id)
        {
            try
            {
                string query = "UPDATE [NaplatnoMesto] " +
                                "SET isDeleted = 1 " +
                                "WHERE Id = @id";
                database.ExecuteNonQueryCommand(query, ("@id", id));
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
