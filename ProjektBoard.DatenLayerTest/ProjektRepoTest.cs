using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjektBoard.DatenLayer.Repositories;
using System.Linq;

namespace ProjektBoard.DatenLayerTest
{
    [TestClass]
    public class ProjektRepoTest

    {
        [TestMethod]
        public void AllProjekte()
        {
            ProjektRepository repository = new ProjektRepository();
           repository.AllProjekte();
        }


    }
}
