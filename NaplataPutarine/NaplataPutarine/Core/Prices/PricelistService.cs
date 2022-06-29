using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NaplataPutarine.Core.Prices.Models;

namespace NaplataPutarine.Core.Prices
{
    internal class PricelistService
    {
        private readonly PricelistRepository pricelistRepository;
        public PricelistService()
        {
            pricelistRepository = new PricelistRepository();
        }

        public List<Price> GetPricelist()
        {
            return pricelistRepository.GetCenovnik();
        }
    }
}
