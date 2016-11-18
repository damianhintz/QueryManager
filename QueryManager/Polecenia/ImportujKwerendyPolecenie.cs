using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using QueryManager.Domena;
using QueryManager.Domena.Encje;

namespace QueryManager.Polecenia
{
    class ImportujKwerendyPolecenie : AbstrakcyjnePolecenie
    {
        OpenFileDialog _open;

        public ImportujKwerendyPolecenie(MainForm form)
            : base(form)
        {
            _open = new OpenFileDialog();
            _open.Filter = "Pliki SQL (*.sql)|*.sql";
            _open.Multiselect = false;
        }

        public override void Wykonaj()
        {
            var result = _open.ShowDialog(_form);
            if (result != DialogResult.OK) return;
            var fileName = _open.FileName;
            var linie = File.ReadAllLines(fileName, Encoding.GetEncoding(1250));
            foreach (var linia in linie)
            {
                if (string.IsNullOrEmpty(linia)) continue;
                _form.DodajKwerendę(ParsujKwerendę(linia));
            }
            _form.EnableZapisz(true);
        }

        Kwerenda ParsujKwerendę(string linia)
        {
            //UPDATE [Granicznik_PZB030] SET [NAM] = UCASE([NAM]) WHERE [NAM] IS NOT NULL AND [NAM] "<>" 'UNK' AND [NAM] "<>" UCASE([NAM]); 
            var sql = linia.Replace("\"<>\"", "<>"); //ALTER TABLE OT_Ulica ALTER COLUMN [nazwa1 TEXT(250);
            var pola = sql.Split(' ');
            var names = from name in pola where JestNazwą(name) select name;
            var nazwa = string.Join(" ", names.ToArray());
            var kwerenda = new Kwerenda(nazwa, string.Empty, sql);
            return kwerenda;
        }

        bool JestNazwą(string text)
        {
            return text.StartsWith("[") || text.EndsWith("]");
        }
    }
}
