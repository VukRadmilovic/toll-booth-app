using TollBoothApp.Core.Devices.Models;
using TollBoothApp.Core.TollStations.Models;
using TollBoothApp.Core.TollStations.Repositories;

namespace TollBoothApp.Core.TollStations.Controllers
{
    internal class NaplatnoMestoController
    {
        private readonly NaplatnoMestoRepository _repository;
        private readonly int _stanicaID;

        public NaplatnoMestoController(int stanicaID)
        {
            _stanicaID = stanicaID;
            _repository = new NaplatnoMestoRepository();
        }

        public List<NaplatnoMesto> GetNaplatnaMesta()
        {
            return _repository.Get(_stanicaID);
        }

        public void Add(int stanicaID, List<Uredjaj> uredjaji)
        {
            try
            {
                _repository.Add(stanicaID, uredjaji);
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
                _repository.Update(mestoID, uredjaji);
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
                _repository.Delete(id);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}