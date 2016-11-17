using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using QueryManager.Widok;

namespace QueryManager.Polecenia
{
    class EdytorPolecenie : AbstrakcyjnePolecenie
    {
        private EdytorKwerendy _edytor;

        public EdytorPolecenie(MainForm form)
            : base(form)
        {
            _edytor = new EdytorKwerendy();
        }

        public override void Wykonaj()
        {
            KwerendaListViewItem item = _form.WybranaKwerenda();

            if (item == null) return;

            _edytor.Kwerenda = item.Kwerenda;

            DialogResult result = _edytor.ShowDialog(_form);

            if (result != DialogResult.OK) return;

            item.Kwerenda = _edytor.Kwerenda;

            _form.EnableZapisz(true);
        }
    }
}
