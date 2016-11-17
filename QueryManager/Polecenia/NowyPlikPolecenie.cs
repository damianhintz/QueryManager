using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using QueryManager.Domena;

namespace QueryManager.Polecenia
{
    class NowyPlikPolecenie : AbstrakcyjnePolecenie
    {
        private SaveFileDialog _saveFileDialog;

        public NowyPlikPolecenie(MainForm form)
            : base(form)
        {
            _form = form;
            _saveFileDialog = new SaveFileDialog();
            _saveFileDialog.Title = "Nowy plik";
            _saveFileDialog.Filter = "*.xml|*.xml";

            _form.EnableNowaKwerenda(false);
            _form.EnableZamknij(false);
            _form.EnableZapisz(false);
            _form.EnableZapiszJako(false);
        }

        public override void Wykonaj()
        {
            DialogResult result = _saveFileDialog.ShowDialog(_form);
            if (result != DialogResult.OK) return;
            string fileName = _saveFileDialog.FileName;

            RepozytoriumKwerend repozytoriumKwerend = new RepozytoriumKwerend();
            RepozytoriumReader.Zapisz(fileName, repozytoriumKwerend);

            _form.PrzygotujNoweRepozytorium(fileName, repozytoriumKwerend);

            _form.EnableNowaKwerenda(true);
            _form.EnableZamknij(true);
            _form.EnableZapisz(false);
            _form.EnableZapiszJako(true);
        }
    }
}
