using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QueryManager.Domena.Abstrakcje
{
    public interface IKwerendyWriter
    {
        void ZapiszZmiany(string fileName);
    }
}
