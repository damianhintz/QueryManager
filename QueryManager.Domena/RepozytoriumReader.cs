using System.IO;
using System.Xml.Serialization;

namespace QueryManager.Domena
{
    /// <summary>
    /// Fabryka repozytorium kwerend.
    /// </summary>
    public class RepozytoriumReader
    {
        /// <summary>
        /// Importuj repozytorium z pliku.
        /// </summary>
        /// <param name="nazwaPliku"></param>
        /// <returns></returns>
        public static RepozytoriumKwerend Wczytaj(string nazwaPliku)
        {
            string ext = Path.GetExtension(nazwaPliku);
            switch (ext.ToLower())
            {
                case ".xml":
                    return WczytajPlikXml(nazwaPliku);
                default:
                    break;
            }
            return null;
        }

        static RepozytoriumKwerend WczytajPlikXml(string nazwaPliku)
        {
            RepozytoriumKwerend repozytorium = null;
            using (StreamReader reader = new StreamReader(nazwaPliku))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(RepozytoriumKwerend));
                repozytorium = (RepozytoriumKwerend)serializer.Deserialize(reader);
            }
            return repozytorium;
        }

        /// <summary>
        /// Zapisz repozytorium do pliku.
        /// </summary>
        /// <param name="nazwaPliku"></param>
        /// <param name="repozytorium"></param>
        public static void Zapisz(string nazwaPliku, RepozytoriumKwerend repozytorium)
        {
            using (StreamWriter writer = new StreamWriter(nazwaPliku))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(RepozytoriumKwerend));
                serializer.Serialize(writer, repozytorium);
            }
        }
    }
}
