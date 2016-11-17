using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

using QueryManager.Domena;

namespace QueryManager.Testy
{
    [TestClass]
    public class RepozytoriumKwerendTest
    {
        string _katalogTestow = @"..\..\";

        void SetRepozytorium(string nazwa, params Kwerenda[] kwerendy)
        {
            var rep = new RepozytoriumKwerend();
            foreach (var k in kwerendy) rep.Dodaj(k);
            var path = Path.Combine(_katalogTestow, nazwa);
            RepozytoriumReader.Zapisz(path, rep);
        }

        RepozytoriumKwerend GetRepozytorium(string nazwa)
        {
            var rep = new RepozytoriumKwerend();
            var path = Path.Combine(_katalogTestow, nazwa);
            return RepozytoriumReader.Wczytaj(path);
        }

        [TestMethod]
        public void TestNowePusteRepozytorium()
        {
            SetRepozytorium("test_puste.xml");
        }

        [TestMethod]
        public void TestNoweRepozytorium()
        {
            SetRepozytorium("test1.xml", new Kwerenda("kwerenda1", "opis kwerendy", "select * from test"));
        }

        [TestMethod]
        public void TestWczytajRepozytorium()
        {
            SetRepozytorium("test_zapisz.xml",
                new Kwerenda("kwerenda1", "opis kwerendy1", "select * from test"),
                new Kwerenda("kwerenda2", "opis kwerendy2", "select * from test"));

            RepozytoriumKwerend rep = GetRepozytorium("test_zapisz.xml");

            //rep.Items
            //rep.Select("*.sql");
            //rep.Add("name", "alias", "desc", "sql");
            //Kwerenda q = rep["name"];
            //q.Wykonaj("*.mdb");

            //string[] files = Directory.GetFiles(katalogTestow, "*.xml");
            Assert.AreEqual(2, rep.Count);
        }

        [TestMethod]
        public void TestSzukajRepozytorium()
        {
            SetRepozytorium("test_szukaj.xml",
                new Kwerenda("kwerenda1", "opis kwerendy1", "select * from test"),
                new Kwerenda("kwerenda2", "opis kwerendy2", "select * from test"),
                new Kwerenda("kwerenda3", "opis kwerendy3", "select * from test"));

            RepozytoriumKwerend rep = GetRepozytorium("test_szukaj.xml");

            Assert.AreEqual(3, rep.Count);

            /*Assert.AreEqual(0, GetCount(rep.Szukaj("kwerenda")));
            Assert.AreEqual(0, GetCount(rep.Szukaj("kwerenda4")));
            Assert.AreEqual(1, GetCount(rep.Szukaj("kwerenda1")));
            Assert.AreEqual(3, GetCount(rep.Szukaj("kwerenda", true)));
            Assert.AreEqual(3, GetCount(rep.Szukaj("kwerenda.", true)));
            Assert.AreEqual(3, GetCount(rep.Szukaj(".*", true)));*/
        }

        [TestMethod]
        public void TestBazaDanych()
        {
            string[] files = Directory.GetFiles(_katalogTestow, "*.mdb");

            RepozytoriumKwerend rep = GetRepozytorium("test_szukaj.xml");

            foreach (string file in files)
            {
                BazaDanych baza = new BazaDanych(file);
                //baza.Wykonaj(rep["kwerenda1"]);
            }
        }

        [TestMethod]
        public void TestUsuwanieZRepozytorium()
        {
            RepozytoriumKwerend rep = new RepozytoriumKwerend();
            rep.Usuń(null);

            Kwerenda k1 = new Kwerenda("a", "", "");

            rep.Dodaj(k1);
            Assert.AreEqual(1, rep.Count);

            rep.Usuń(null);
            Assert.AreEqual(1, rep.Count);

            Kwerenda k2 = new Kwerenda("a", "", "");

            rep.Dodaj(k2);
            rep.Usuń(k2);
            Assert.AreEqual(1, rep.Count);
        }
    }
}
