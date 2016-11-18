using System.IO;
using System.Xml.Serialization;
using QueryManager.Domena.Abstrakcje;

namespace QueryManager.Domena.Repozytoria.Xml
{
    /// <summary>
    /// Zapisuje kwerendy do pliku xml.
    /// </summary>
    public class KwerendyXmlReader : IKwerendyReader
    {
        RepozytoriumKwerend _repo;
        
        public KwerendyXmlReader(RepozytoriumKwerend repozytorium)
        {
            _repo = repozytorium;
        }
        
        public void Wczytaj(string nazwaPliku)
        {
            string ext = Path.GetExtension(nazwaPliku);
            switch (ext.ToLower())
            {
                case ".xml":
                    WczytajPlikXml(nazwaPliku);
                    break;
                default:
                    break;
            }
        }

        void WczytajPlikXml(string nazwaPliku)
        {
            RepozytoriumKwerend repo = null;
            using (StreamReader reader = new StreamReader(nazwaPliku))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(RepozytoriumKwerend));
                repo = (RepozytoriumKwerend)serializer.Deserialize(reader);
                foreach (var k in repo) _repo.Dodaj(k);
            }
        }
        
    }
}
