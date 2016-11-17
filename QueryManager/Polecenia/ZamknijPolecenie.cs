using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace QueryManager.Polecenia
{
    class ZamknijPolecenie : AbstrakcyjnePolecenie
    {
        public bool Canceled { get; private set; }

        public ZamknijPolecenie(MainForm form)
            : base(form)
        {
        }

        public override void Wykonaj()
        {
            Canceled = false;

            if (_form.CzyZmodyfikowanoRepozytorium)
            {
                DialogResult result = MessageBox.Show(_form, "Plik został zmieniony, zapisać zmiany?", "Zamknij",
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                switch (result)
                {
                    case DialogResult.Yes:
                        _form.ZapiszZmianyPrzedZamknieciem();
                        break;
                    case DialogResult.No:
                        break;
                    case DialogResult.Cancel:
                        Canceled = true;
                        return;
                    default:
                        Canceled = true;
                        return;
                }
            }

            _form.PrzygotujNoweRepozytorium(null, null);
            
            _form.EnableNowaKwerenda(false);
            _form.EnableZamknij(false);
            _form.EnableZapisz(false);
            _form.EnableZapiszJako(false);
        }
    }
}
