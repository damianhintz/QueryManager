using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using QueryManager.Domena;
using QueryManager.Domena.Repozytoria.Text;

namespace QueryManager.Polecenia
{
    class ZapiszJakoTextPolecenie : AbstrakcyjnePolecenie
    {
        private SaveFileDialog _saveFileDialog;

        public ZapiszJakoTextPolecenie(MainForm form)
            : base(form)
        {
            _saveFileDialog = new SaveFileDialog();
            _saveFileDialog.Title = "Zapisz";
            _saveFileDialog.Filter = "Pliki tekstowe (*.txt)|*.txt";
            _saveFileDialog.FileName = _form.NazwaRepozytorium;
        }

        public override void Wykonaj()
        {
            _saveFileDialog.FileName = _form.NazwaRepozytorium;
            DialogResult result = _saveFileDialog.ShowDialog(_form);
            if (result != DialogResult.OK) return;

            var writer = new KwerendyTextWriter(_form.Repozytorium);
            writer.ZapiszZmiany(_saveFileDialog.FileName);
            _form.PrzygotujNoweRepozytorium(_saveFileDialog.FileName, _form.Repozytorium);

            _form.EnableZapisz(false);
        }
    }
}
