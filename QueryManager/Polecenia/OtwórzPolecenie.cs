using System;
using System.Windows.Forms;
using QueryManager.Domena;
using QueryManager.Domena.Repozytoria;
using QueryManager.Domena.Repozytoria.Xml;

namespace QueryManager.Polecenia
{
    class OtwórzPolecenie : AbstrakcyjnePolecenie
    {
        private OpenFileDialog _openFileDialog;

        public OtwórzPolecenie(MainForm form)
            : base(form)
        {
            _openFileDialog = new OpenFileDialog();
            _openFileDialog.Title = "Otwórz plik";
            _openFileDialog.Filter = "*.xml|*.xml";
            _openFileDialog.Multiselect = false;
        }

        public override void Wykonaj()
        {
            var result = _openFileDialog.ShowDialog(_form);
            if (result != DialogResult.OK) return;
            Wczytaj(_openFileDialog.FileName);
        }

        public void Wczytaj(string fileName)
        {
            try
            {
                var repo = new RepozytoriumKwerend();
                var reader = new KwerendyXmlReader(repo);
                reader.Wczytaj(fileName);
                _form.PrzygotujNoweRepozytorium(fileName, repo);
                _form.EnableNowaKwerenda(true);
                _form.EnableZamknij(true);
                _form.EnableZapisz(false);
                _form.EnableZapiszJako(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(_form,
                    ex.Message, "Otwórz",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
