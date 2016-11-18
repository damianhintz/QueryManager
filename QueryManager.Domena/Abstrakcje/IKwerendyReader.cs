using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QueryManager.Domena.Abstrakcje
{
    public interface IKwerendyReader
    {
        void Wczytaj(string fileName);
    }
}
