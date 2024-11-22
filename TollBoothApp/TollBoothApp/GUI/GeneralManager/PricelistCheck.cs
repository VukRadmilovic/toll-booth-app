using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TollBoothApp.Core.Prices;
using TollBoothApp.Core.Prices.Models;

namespace TollBoothApp.GUI.GeneralManager
{
    public partial class PricelistCheck : Form
    {
        private readonly PricelistController controller;
        public PricelistCheck()
        {
            controller = new PricelistController();
            InitializeComponent();
        }

        private void PricelistCheck_Load(object sender, EventArgs e)
        {
            List<Price> pricelist = controller.GetPricelist();
            foreach(Price pric in pricelist)
            {
                PricelistTable.Rows.Add(pric.deonica, pric.kategorija, pric.vrednost, pric.date.ToString());
                
            }
        }
    }
}
