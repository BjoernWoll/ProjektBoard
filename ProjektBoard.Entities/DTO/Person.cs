using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ProjektBoard.Entities.DTO
{
    [Table("Person")]
    public class Person
    {
        public int Id { get; set; }
        public string Vorname { get; set; }
        [Column("Nachame")]
        public string Nachname { get; set; }
        public string Anmeldename { get; set; }
        public string Passwort { get; set; }
    }
}
