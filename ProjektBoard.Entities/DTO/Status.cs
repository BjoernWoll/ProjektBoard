using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ProjektBoard.Entities.DTO
{
    [Table("Status")]
    public class Status
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Beschreibung { get; set; }
    }
}
