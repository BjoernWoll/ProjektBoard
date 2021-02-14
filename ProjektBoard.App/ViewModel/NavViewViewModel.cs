using ProjektBoard.DatenLayer.Repositories;
using ProjektBoard.Entities.Domaene;
using ProjektBoard.Entities.DTO;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ProjektBoard.App.ViewModel
{
    public class NavViewViewModel
    {
        private ProjektRepository repo = new ProjektRepository();
        private PersonenRepositroy persRepo = new PersonenRepositroy();
        public NavViewViewModel()
        {
            Projekte = new ObservableCollection<ProjektDomaenenDVO>();

            Projekte.Clear();
            Personen.Clear();

            persRepo.All().ForEach(p => Personen.Add(p));
            repo.AllProjekte().ForEach(r => Projekte.Add(r));
        }





        public ObservableCollection<Person> Personen { get; set; } = new ObservableCollection<Person>();
        public ObservableCollection<ProjektDomaenenDVO> Projekte { get; set; }
    }
}
