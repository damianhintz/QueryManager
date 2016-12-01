using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using QueryManager.Properties;
using QueryManager.Domena;
using QueryManager.Widok;
using QueryManager.Polecenia;
using QueryManager.Domena.Repozytoria;
using QueryManager.Domena.Encje;
using System.Text;

namespace QueryManager
{
    public partial class MainForm : Form
    {
        public string Baza { get; private set; }
        //Plik
        private NowyPlikPolecenie _nowyPlik;
        private OtwórzPolecenie _otwórz;
        private NowaKwerendaPolecenie _nowaKwerenda;
        private ImportujKwerendyPolecenie _importujKwerendy;
        private ZamknijPolecenie _zamknij;
        private ZapiszPolecenie _zapisz;
        private ZapiszJakoPolecenie _zapiszJakoXml;
        private ZapiszJakoTextPolecenie _zapiszJakoText;
        private ZakończPolecenie _zakończ;
        //Kwerenda
        private EdytorPolecenie _edytor;
        private UsuńPolecenie _usuń;
        private WykonajPolecenie _wykonaj;
        //Pomoc
        private InformacjePolecenie _informacje;
        //Repozytorium
        private RepozytoriumKwerend _repozytorium;
        public RepozytoriumKwerend Repozytorium { get { return _repozytorium; } }

        private string _nazwaRepozytorium;
        public string NazwaRepozytorium { get { return _nazwaRepozytorium; } }

        public bool CzyZmodyfikowanoRepozytorium { get { return zapiszMenuItem.Enabled; } }
        KwerendyListView _view;

        public MainForm(string baza)
        {
            Baza = baza;
            InitializeComponent();
            InicjowaniePoleceń();
            BindowaniePoleceń();
            Text = GetTitle();
            _view = new KwerendyListView(kwerendyView, _repozytorium);
        }

        string GetTitle()
        {
            if (string.IsNullOrEmpty(Baza)) return string.Format(Application.ProductName);
            return string.Format("{0} ({1})", Application.ProductName, Baza);
        }

        void InicjowaniePoleceń()
        {
            _nowyPlik = new NowyPlikPolecenie(this);
            _otwórz = new OtwórzPolecenie(this);
            _nowaKwerenda = new NowaKwerendaPolecenie(this);
            _importujKwerendy = new ImportujKwerendyPolecenie(this);
            _zamknij = new ZamknijPolecenie(this);
            _zapisz = new ZapiszPolecenie(this);
            _zapiszJakoXml = new ZapiszJakoPolecenie(this);
            _zapiszJakoText = new ZapiszJakoTextPolecenie(this);
            _zakończ = new ZakończPolecenie(this);
            _edytor = new EdytorPolecenie(this);
            _usuń = new UsuńPolecenie(this);
            _wykonaj = new WykonajPolecenie(this);
            _informacje = new InformacjePolecenie(this);
        }

        /// <summary>
        /// Przypisuje do atrybutu <code>Tag</code> konkretny obiekt PolecenieBase.
        /// </summary>
        void BindowaniePoleceń()
        {
            nowyPlikMenuItem.Tag = _nowyPlik;
            otwórzPlikMenuItem.Tag = _otwórz;
            nowaKwerendaMenuItem.Tag = _nowaKwerenda;
            importujKwerendyMenuItem.Tag = _importujKwerendy;
            dodajKwerendaMenuItem.Tag = _nowaKwerenda;
            dodajKontekstToolStripMenuItem.Tag = _nowaKwerenda;
            zamknijMenuItem.Tag = _zamknij;
            zapiszMenuItem.Tag = _zapisz;
            eksportujXmlMenuItem.Tag = _zapiszJakoXml;
            eksportujTekstowyMenuItem.Tag = _zapiszJakoText;
            zakończMenuItem.Tag = _zakończ;
            zmieńMenuItem.Tag = _edytor;
            zmienKontekstToolStripMenuItem.Tag = _edytor;
            usuńMenuItem.Tag = _usuń;
            usunKontekstToolStripMenuItem.Tag = _usuń;
            wykonajKontekstToolStripMenuItem.Tag = _wykonaj;
            wykonajMenuItem.Tag = _wykonaj;
            informacjeOMenuItem.Tag = _informacje;
        }

        /// <summary>
        /// Przygotuj nowe repozytorium do edycji.
        /// </summary>
        /// <param name="nazwaPliku"></param>
        /// <param name="repozytorium"></param>
        public void PrzygotujNoweRepozytorium(string nazwaPliku, RepozytoriumKwerend repozytorium)
        {
            kwerendyView.VirtualListSize = 0;
            //kwerendyView.Items.Clear();
            _nazwaRepozytorium = nazwaPliku;
            _repozytorium = repozytorium;
            string title = GetTitle();
            if (string.IsNullOrEmpty(nazwaPliku))
            {
                Text = title;
            }
            else
            {
                Text = nazwaPliku + " - " + title;
                //foreach (var q in repozytorium) AddQueryItem(q);
                _view.Kwerendy = _repozytorium;
                kwerendyView.VirtualListSize = _repozytorium.Count;
            }
        }

        public void DodajKwerendę(Kwerenda q)
        {
            _repozytorium.Dodaj(q);
            kwerendyView.VirtualListSize = _repozytorium.Count;
        }

        internal void UsuńKwerendę(KwerendaListViewItem item)
        {
            _repozytorium.Usuń(item.Kwerenda);
            PrzygotujNoweRepozytorium(_nazwaRepozytorium, _repozytorium);
        }

        public void EnableNowaKwerenda(bool enable)
        {
            nowaKwerendaMenuItem.Enabled = enable;
            dodajKwerendaMenuItem.Enabled = enable;
            dodajKontekstToolStripMenuItem.Enabled = enable;
        }

        public void EnableZamknij(bool enable) { zamknijMenuItem.Enabled = enable; }
        public void EnableZapisz(bool enable) { zapiszMenuItem.Enabled = enable; }
        public void EnableZapiszJako(bool enable) { zapiszJakoMenuItem.Enabled = enable; }
        public void ZapiszZmianyPrzedZamknieciem() { _zapisz.Wykonaj(); }

        private void WykonajPolecenie(ToolStripMenuItem sender)
        {
            if (sender == null) return;
            AbstrakcyjnePolecenie polecenie = sender.Tag as AbstrakcyjnePolecenie;
            if (polecenie == null) return;
            polecenie.Wykonaj();
        }

        private void PolecenieMenuItem_Click(object sender, EventArgs e)
        {
            WykonajPolecenie(sender as ToolStripMenuItem);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _zamknij.Wykonaj();
            e.Cancel = _zamknij.Canceled;
        }

        internal KwerendaListViewItem WybranaKwerenda()
        {
            foreach (int index in kwerendyView.SelectedIndices)
                return kwerendyView.Items[index] as KwerendaListViewItem;
            return null;
        }

        internal Kwerenda[] WybraneKwerendy()
        {
            List<Kwerenda> kwerendy = new List<Kwerenda>();
            foreach (int index in kwerendyView.SelectedIndices)
            {
                var item = kwerendyView.Items[index] as KwerendaListViewItem;
                kwerendy.Add(item.Kwerenda);
            }
            return kwerendy.ToArray();
        }

        private void kwerendyListView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            _edytor.Wykonaj();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            string domyślnyPlik = Settings.Default.DefaultRepo;
            if (!Path.IsPathRooted(domyślnyPlik)) domyślnyPlik = Path.Combine(Application.StartupPath, domyślnyPlik);
            if (!string.IsNullOrEmpty(domyślnyPlik)) _otwórz.Wczytaj(domyślnyPlik);
        }

        private void zaznaczWszystkoMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < kwerendyView.VirtualListSize; i++) kwerendyView.SelectedIndices.Add(i);
        }

        private void generatorKwerendMenuItem_Click(object sender, EventArgs e)
        {
            var queryItem = WybranaKwerenda();
            if (queryItem == null) return;
            var open = new OpenFileDialog();
            open.Filter = "Pliki tekstowe (*.tab)|*.tab";
            var result = open.ShowDialog(this);
            if (result != DialogResult.OK) return;
            var templateQuery = queryItem.Kwerenda;
            var templateSql = templateQuery.Sql;
            //Wybierz plik zmiennych *.tab
            var fileName = open.FileName;
            var records = File.ReadAllLines(fileName, Encoding.GetEncoding(1250));
            int index = 1;
            foreach (var record in records)
            {
                var pola = record.Split('\t');
                var sql = templateSql;
                for (int i = 0; i < pola.Length; i++)
                {
                    var zmienna = "[" + i + "]"; //[0], [1], [2], ...
                    var wartość = pola[i];
                    sql = sql.Replace(zmienna, wartość);
                }
                var query = new Kwerenda
                {
                    Numer = index.ToString(),
                    Nazwa = templateQuery.Nazwa,
                    Opis = templateQuery.Opis,
                    Sql = sql
                };
                _repozytorium.Dodaj(query);
                index++;
            }
            kwerendyView.VirtualListSize = _repozytorium.Count;
        }
    }
}
