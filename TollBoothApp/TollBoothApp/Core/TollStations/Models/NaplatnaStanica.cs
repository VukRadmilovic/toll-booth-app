using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TollBoothApp.Core.Users.Models;

namespace TollBoothApp.Core.TollStations.Models
{
    internal class NaplatnaStanica
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public string Mesto { get; set; }
        public DateOnly DatumIzgradnje { get; set; }
        public Radnik SefStanice { get; set; }
        public List<Radnik> Radnici { get; set; }
        public List<NaplatnoMesto> NaplatnaMesta { get; set; }

        public NaplatnaStanica(int id,
                               string naziv,
                               string mesto,
                               DateOnly datumIzgradnje,
                               Radnik sefStanice,
                               List<Radnik> radnici,
                               List<NaplatnoMesto> naplatnaMesta)
        {
            Id = id;
            Naziv = naziv;
            Mesto = mesto;
            DatumIzgradnje = datumIzgradnje;
            SefStanice = sefStanice;
            Radnici = radnici;
            NaplatnaMesta = naplatnaMesta;
        }

        public NaplatnaStanica(int id)
        {
            Id = id;
        }

        public NaplatnaStanica(int id, string naziv)
        {
            Id = id;
            Naziv = naziv;
        }

        public NaplatnoMesto RegistrujNaplatnoMesto()
        {
            throw new NotImplementedException();
        }

    }
}
