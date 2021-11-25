using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entrepots.Modele;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entrepots.Modele.Tests
{
    [TestClass()]
    public class CasierTests
    {
        [TestMethod()]
        public void RecherchePlaceLibreTest()
        {
            CategorieColis ct1 = new CategorieColis("1", 3);

            Entrepot E1 = new Entrepot(1, "Entrepot 01");

            Casier C1 = new Casier(1, 3, 3, E1, 9);

            Colis c1 = new Colis(ct1, 0, 0,C1);

            List<List<int>> resultat = C1.GetInitialisationConstructionCasier();

           
        }
    }
}