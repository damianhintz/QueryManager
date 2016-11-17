using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using QueryManager.Widok;

namespace QueryManager.Polecenia
{
    class UsuńPolecenie : AbstrakcyjnePolecenie
    {
        public UsuńPolecenie(MainForm form)
            : base(form)
        {
        }

        public override void Wykonaj()
        {
            KwerendaListViewItem item = _form.WybranaKwerenda();

            if (item == null) return;

            DialogResult result = MessageBox.Show(_form, "Usunąć wybraną kwerendę?", "Usuń",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            switch (result)
            {
                case DialogResult.Yes:
                    break;
                case DialogResult.No:
                    return;
            }

            _form.UsuńKwerendę(item);
            _form.EnableZapisz(true);
        }
    }
}
