using System;
using System.Collections.Generic;
using System.Text;

namespace ProjektBoard.Entities.Domaene
{
    public  class ProjektDomaenenDVO
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Beschreibung { get; set; }
        public DateTime? Beginn { get; set; }
        public DateTime? Ende { get; set; }
        public DateTime? update { get; set; }

        public string Status { get; set; }
    }
}
