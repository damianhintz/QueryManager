using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

using QueryManager.Domena;

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
            RepozytoriumReader.Zapisz(_form.NazwaRepozytorium, _form.Repozytorium);
            _form.EnableZapisz(false);
        }
    }
}
