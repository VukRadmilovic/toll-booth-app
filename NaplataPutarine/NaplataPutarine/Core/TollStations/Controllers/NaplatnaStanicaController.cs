using NaplataPutarine.Core.TollStations.Models;
using NaplataPutarine.Core.TollStations.Repositories;

namespace NaplataPutarine.Core.TollStations.Controllers
{
    internal class NaplatnaStanicaController
    {
        private readonly NaplatnaStanicaRepository _repository;
        private readonly SistemZaNaplatuPutarine _sistem;

        public NaplatnaStanicaController()
        {
            _repository = new NaplatnaStanicaRepository();
            _sistem = SistemZaNaplatuPutarine.GetInstance();
        }

        public List<NaplatnaStanica> GetNaplatneStanice()
        {
            return _repository.GetAllTollStations();
        }

        private void ValidateInput(string naziv, string mesto, DateTime izgradnja)
        {
            if (string.IsNullOrEmpty(naziv))
            {
                throw new InvalidInputException("Naziv mora biti unet.");
            }
            if (string.IsNullOrEmpty(mesto))
            {
                throw new InvalidInputException("Mesto mora biti uneto.");
            }
            if (izgradnja.CompareTo(DateTime.Now) > 0)
            {
                throw new InvalidInputException("Datum izgradnje ne sme biti u budućnosti.");
            }
        }

        public void Add(string naziv, string mesto, DateTime izgradnja)
        {
            try
            {
                ValidateInput(naziv, mesto, izgradnja);
                _repository.Add(naziv, mesto, izgradnja);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Update(int id, string naziv, string mesto, DateTime izgradnja)
        {
            try
            {
                ValidateInput(naziv, mesto, izgradnja);
                _repository.Update(id, naziv, mesto, izgradnja);
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

        public void RefreshSistem()
        {
            _sistem.Refresh();
        }
    }
}