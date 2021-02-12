using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ProjektBoard.Entities.DTO
{
    [Table("Projekt")]
    public class Projekt
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Beschreibung { get; set; }
        public DateTime Beginn { get; set; }
        public DateTime Ende { get; set; }
    }
}
