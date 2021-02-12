using System;
using System.Collections.Generic;
using System.Text;

namespace ProjektBoard.Entities.DTO
{
    public class Person
    {
        public int Id { get; set; }
        public string Vorname { get; set; }
        public string Nachname { get; set; }
        public string Anmeldename { get; set; }
        public string Passwort { get; set; }
    }
}
