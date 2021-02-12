using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ProjektBoard.Entities.DTO
{
    public class ProjektStatus
    {
        public int Id { get; set; }
   
        [Column("update_am")]
        public  DateTime Updateam { get; set; }

        [ForeignKey("Projekte")]
        public int Projekt { get; set; }
        public ICollection<Projekt> Projekte{ get; set; }

        [ForeignKey("Stati")]
        public int Status { get; set; }
        public ICollection<Status> Stati { get; set; }
    }
}
