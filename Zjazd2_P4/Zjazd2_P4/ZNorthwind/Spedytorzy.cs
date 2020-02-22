using System;
using System.Collections.Generic;

namespace Zjazd2_P4.ZNorthwind
{
    public partial class Spedytorzy
    {
        public Spedytorzy()
        {
            Zamówienia = new HashSet<Zamówienia>();
        }

        public int Idspedytora { get; set; }
        public string NazwaFirmy { get; set; }
        public string Telefon { get; set; }

        public virtual ICollection<Zamówienia> Zamówienia { get; set; }
    }
}
