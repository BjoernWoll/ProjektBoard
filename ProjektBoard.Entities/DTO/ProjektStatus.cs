using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ProjektBoard.Entities.DTO
{
    [Table("ProjektStatus")]
    public class ProjektStatus
    {
 //       [Key]
        public int id { get; set; }
   
        [Column("update_am")]
        public  DateTime Updateam { get; set; }


       public int Projekt_fk { get; set; }
        
        [ForeignKey("Projekt_Fk")]
       public ICollection<Projekt> Projekte{ get; set; }

        
        [ForeignKey("Status")]
        public int Status_fk { get; set; }
       
      public ICollection<Status> Stati { get; set; }
    }
}
