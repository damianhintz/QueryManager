using System.IO;
using System.Xml.Serialization;
using QueryManager.Domena.Abstrakcje;
using QueryManager.Domena.Encje;
using System.Text;

namespace QueryManager.Domena.Repozytoria.Text
{
    /// <summary>
    /// Zapisuje kwerendy do pliku xml.
    /// </summary>
    public class KwerendyTextReader : IKwerendyReader
    {
        RepozytoriumKwerend _repo;

        public KwerendyTextReader(RepozytoriumKwerend repozytorium)
        {
            _repo = repozytorium;
        }

        public void Wczytaj(string nazwaPliku)
        {
            var records = File.ReadAllLines(nazwaPliku, Encoding.GetEncoding(1250));
            for (int i = 0; i < records.Length; i += 4)
            {
                var lp = records[i + 0];
                var nazwa = records[i + 1];
                var opis = records[i + 2];
                var sql = records[i + 3];
                var q = new Kwerenda { Numer = lp, Nazwa = nazwa, Opis = opis, Sql = sql };
                _repo.Dodaj(q);
            }
        }

    }
}
