using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NaplataPutarine.Core.Prices.Models;
using NaplataPutarine.Core.Payments.Models;
using NaplataPutarine.Core.TollStations.Models;

namespace NaplataPutarine.Core.Payments
{
    internal class PaymentController
    {
        private readonly PaymentService service;

        public PaymentController()
        {
            service = new PaymentService();
        }

        public List<EnhancedComboBoxItem> GetCat()
        {
            return service.GetCat();
        }
        public List<Core.Payments.Models.Kartica> GetCards()
        {
            return service.GetCards();
        }
        public double AvgSpeed(Core.Payments.Models.Kartica start, NaplatnaStanica stanica, DateTime stop)
        {
            return service.AvgSpeed(start, stanica, stop);
        }
        public double Kurs(Core.Payments.Models.Kartica start, NaplatnaStanica stanica, int type)
        {
            return service.Kurs(start, stanica, type);
        }
    }
}
