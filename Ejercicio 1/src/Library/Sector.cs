using System;
using System.Collections.Generic;

namespace SRP
{
    public class Sector{
        public string SectorName { get ; set;}
        public List<Shelf> Shelf { get; set; }  = new List<Shelf>();

    }
}
