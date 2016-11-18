using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using QueryManager.Domena.Repozytoria;
using QueryManager.Domena;
using QueryManager.Domena.Repozytoria.Xml;

namespace QueryManager.Polecenia
{
    class ZapiszPolecenie : AbstrakcyjnePolecenie
    {
        public ZapiszPolecenie(MainForm form)
            : base(form)
        {
        }

        public override void Wykonaj()
        {
            var writer = new KwerendyXmlWriter(_form.Repozytorium);
            writer.ZapiszZmiany(_form.NazwaRepozytorium);
            _form.EnableZapisz(false);
        }
    }
}
