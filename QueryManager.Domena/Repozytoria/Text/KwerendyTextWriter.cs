using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using System.Text;
using QueryManager.Domena.Abstrakcje;

namespace QueryManager.Domena.Repozytoria.Text
{
    /// <summary>
    /// Czytnik kwerend z pliku tekstowego.
    /// </summary>
    public class KwerendyTextWriter : IKwerendyWriter
    {
        RepozytoriumKwerend _repo;

        public KwerendyTextWriter(RepozytoriumKwerend repozytorium)
        {
            _repo = repozytorium;
        }

        public void ZapiszZmiany(string nazwaPliku)
        {
            var lines = new List<string>();
            foreach (var k in _repo)
            {
                lines.Add(k.Numer);
                lines.Add(k.Nazwa);
                lines.Add(k.Opis);
                lines.Add(k.Sql);
            }
            File.WriteAllLines(nazwaPliku, lines, Encoding.GetEncoding(1250));
        }
    }
}
