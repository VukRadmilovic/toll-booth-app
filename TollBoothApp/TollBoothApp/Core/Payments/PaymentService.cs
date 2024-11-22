using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TollBoothApp.Core.Payments.Models;
using TollBoothApp.Core.Prices.Models;

namespace TollBoothApp.Core.Payments
{
    internal class PaymentService
    {
        private readonly PaymentRepository repository;
        public PaymentService()
        {
            repository = new PaymentRepository();
        }

        public List<EnhancedComboBoxItem> GetCat()
        {
            List<KategorijaVozila> li = repository.GetCat();
            List<EnhancedComboBoxItem> cat = new List<EnhancedComboBoxItem>();
            foreach (KategorijaVozila kategorijaVozila in li)
            {
                cat.Add(new EnhancedComboBoxItem(kategorijaVozila.Naziv, kategorijaVozila.Id));
            }
            return cat;
        }

        internal double AvgSpeed(Kartica start, TollStations.Models.NaplatnaStanica stanica, DateTime stop)
        {
            return repository.AvgSpeed(start, stanica, stop);
        }

        internal double Kurs(Kartica start, TollStations.Models.NaplatnaStanica stanica, int type)
        {
            return repository.Kurs(start, stanica, type);
        }

        public List<Kartica> GetCards()
        {
            return repository.GetCards();
        }
    }
}
