using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using QueryManager.Domena.Abstrakcje;
using QueryManager.Domena.Repozytoria;
using QueryManager.Domena.Repozytoria.Xml;
using QueryManager.Domena.Repozytoria.Text;

namespace QueryManager.Domena.Rozszerzenia
{
    public static class RepozytoriumRozszerzenia
    {
        public static IKwerendyReader CreateQueryReader(this string fileName, RepozytoriumKwerend q)
        {
            var ext = Path.GetExtension(fileName).ToLower();
            switch(ext)
            {
                case ".xml":
                    return new KwerendyXmlReader(q);
                case ".txt":
                    return new KwerendyTextReader(q);
                default:
                    throw new NotImplementedException("Brak implementacji importera repozytorium typu: " + ext);
            }
        }

        public static IKwerendyWriter CreateQueryWriter(this string fileName, RepozytoriumKwerend q)
        {
            var ext = Path.GetExtension(fileName).ToLower();
            switch (ext)
            {
                case ".xml":
                    return new KwerendyXmlWriter(q);
                case ".txt":
                    return new KwerendyTextWriter(q);
                default:
                    throw new NotImplementedException("Brak implementacji eksportera repozytorium typu: " + ext);
            }
        }
    }
}
