using System.IO;
using System.Xml.Serialization;
using QueryManager.Domena.Abstrakcje;

namespace QueryManager.Domena.Repozytoria.Xml
{
    /// <summary>
    /// Czytnik kwerend z pliku xml.
    /// </summary>
    public class KwerendyXmlWriter : IKwerendyWriter
    {
        RepozytoriumKwerend _repo;
        
        public KwerendyXmlWriter(RepozytoriumKwerend repozytorium)
        {
            _repo = repozytorium;
        }
        
        public void ZapiszZmiany(string nazwaPliku)
        {
            using (var writer = new StreamWriter(nazwaPliku))
            {
                var serializer = new XmlSerializer(typeof(RepozytoriumKwerend));
                serializer.Serialize(writer, _repo);
            }
        }
    }
}
