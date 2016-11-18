using System.IO;
using System.Xml.Serialization;
using QueryManager.Domena.Abstrakcje;

namespace QueryManager.Domena.Repozytoria.Xml
{
    /// <summary>
    /// Fabryka repozytorium kwerend.
    /// </summary>
    public class KwerendyXmlWriter : IKwerendyWriter
    {
        RepozytoriumKwerend repozytorium;
        
        public KwerendyXmlWriter(RepozytoriumKwerend repozytorium)
        {
            this.repozytorium = repozytorium;
        }
        
        public void ZapiszZmiany(string nazwaPliku)
        {
            using (var writer = new StreamWriter(nazwaPliku))
            {
                var serializer = new XmlSerializer(typeof(RepozytoriumKwerend));
                serializer.Serialize(writer, repozytorium);
            }
        }
    }
}
