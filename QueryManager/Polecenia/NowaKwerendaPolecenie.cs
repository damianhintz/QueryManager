using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using QueryManager.Domena;
using QueryManager.Widok;

namespace QueryManager.Polecenia
{
    class NowaKwerendaPolecenie : AbstrakcyjnePolecenie
    {
        private EdytorKwerendy _edytor;

        public NowaKwerendaPolecenie(MainForm form)
            : base(form)
        {
            _edytor = new EdytorKwerendy();
        }

        public override void Wykonaj()
        {
            DialogResult result = _edytor.ShowDialog(_form);
            if (result != DialogResult.OK) return;
            _form.DodajKwerendę(_edytor.Kwerenda);
            _form.EnableZapisz(true);
        }
    }
}
