using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using QueryManager.Domena.Repozytoria;
using QueryManager.Domena.Encje;
using QueryManager.Domena.Rozszerzenia;

namespace QueryManager.Testy
{
    [TestClass]
    public class BazaDanychTest
    {
        string _samplesPath = @"..\..\Samples";

        [TestMethod]
        public void BazaDanych_ShouldBeUpdated()
        {
            var files = Directory.GetFiles(_samplesPath, "*.mdb");
            foreach (string file in files)
            {
                var baza = new BazaDanych(file);
                //baza.Wykonaj(rep["kwerenda1"]);
            }
        }

    }
}
