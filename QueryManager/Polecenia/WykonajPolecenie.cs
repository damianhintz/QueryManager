using System;
using System.Collections.Generic;
using System.Text;
using QueryManager.Domena;
using QueryManager.Widok;

namespace QueryManager.Polecenia
{
    class WykonajPolecenie : AbstrakcyjnePolecenie
    {
        private EdytorBazy _edytor;

        public WykonajPolecenie(MainForm form)
            : base(form)
        {
            _edytor = new EdytorBazy(form);
        }

        public override void Wykonaj()
        {
            _edytor.Kwerendy = _form.WybraneKwerendy();
            _edytor.ShowDialog(_form);
        }
    }
}
