using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using QueryManager.Domena.Repozytoria;
using QueryManager.Domena;
using QueryManager.Domena.Encje;
using QueryManager.Domena.Repozytoria.Xml;
using QueryManager.Domena.Rozszerzenia;
using Shouldly;

namespace QueryManager.Testy
{
    [TestClass]
    public class KwerendyXmlTest
    {
        string _samplesPath = @"..\..\Samples";

        [TestMethod]
        public void Repozytorium_ShouldBeEmpty()
        {
            var repo = CreateRepo("test_puste.xml");
            repo.ShouldBeEmpty();
        }

        [TestMethod]
        public void Repozytorium_ShouldNotBeEmpty()
        {
            var repo = CreateRepo("test1.xml",
                new Kwerenda("kwerenda1", "opis kwerendy", "select * from test"));
            repo.ShouldNotBeEmpty();
            repo.Count.ShouldBe(1);
        }

        [TestMethod]
        public void Repozytorium_ShouldReadQueries()
        {
            var repoExpected = CreateRepo("test_zapisz.xml",
                new Kwerenda("kwerenda1", "opis kwerendy1", "select * from test"),
                new Kwerenda("kwerenda2", "opis kwerendy2", "select * from test"));
            var repo = ReadRepo("test_zapisz.xml");
            repo.Count.ShouldBe(repoExpected.Count);
        }

        [TestMethod]
        public void Repozytorium_ShouldContainQueries()
        {
            var expected = CreateRepo("test_szukaj.xml",
                new Kwerenda("kwerenda1", "opis kwerendy1", "select * from test"),
                new Kwerenda("kwerenda2", "opis kwerendy2", "select * from test"),
                new Kwerenda("kwerenda3", "opis kwerendy3", "select * from test"));
            var repo = ReadRepo("test_szukaj.xml");
            repo.Count.ShouldBe(expected.Count);
        }

        [TestMethod]
        public void Repozytorium_ShouldRemoveQueries()
        {
            var repo = new RepozytoriumKwerend();
            repo.Usuń(null);
            var k1 = new Kwerenda("a", "", "");
            repo.Dodaj(k1);
            Assert.AreEqual(1, repo.Count);

            repo.Usuń(null);
            Assert.AreEqual(1, repo.Count);

            var k2 = new Kwerenda("a", "", "");
            repo.Dodaj(k2);
            repo.Usuń(k2);
            Assert.AreEqual(1, repo.Count);
        }

        RepozytoriumKwerend CreateRepo(string fileName, params Kwerenda[] kwerendy)
        {
            var repo = new RepozytoriumKwerend();
            foreach (var k in kwerendy) repo.Dodaj(k);
            var path = Path.Combine(_samplesPath, fileName);
            var writer = path.CreateQueryWriter(repo);
            writer.ZapiszZmiany(path);
            repo.Count.ShouldBe(kwerendy.Length);
            return repo;
        }

        RepozytoriumKwerend ReadRepo(string fileName)
        {
            var repo = new RepozytoriumKwerend();
            var path = Path.Combine(_samplesPath, fileName);
            //var reader = new KwerendyXmlReader(repo);
            var reader = path.CreateQueryReader(repo);
            reader.Wczytaj(path);
            return repo;
        }

    }
}
