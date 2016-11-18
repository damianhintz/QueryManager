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
        private ZapiszJakoPolecenie _zapiszJako;
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

        public MainForm(string baza)
        {
            Baza = baza;
            InitializeComponent();
            InicjowaniePolecen();
            BindowaniePolecen();
            Text = GetTitle();
        }

        string GetTitle()
        {
            if (string.IsNullOrEmpty(Baza)) return string.Format(Application.ProductName);
            return string.Format("{0} ({1})", Application.ProductName, Baza);
        }

        void InicjowaniePolecen()
        {
            _nowyPlik = new NowyPlikPolecenie(this);
            _otwórz = new OtwórzPolecenie(this);
            _nowaKwerenda = new NowaKwerendaPolecenie(this);
            _importujKwerendy = new ImportujKwerendyPolecenie(this);
            _zamknij = new ZamknijPolecenie(this);
            _zapisz = new ZapiszPolecenie(this);
            _zapiszJako = new ZapiszJakoPolecenie(this);
            _zakończ = new ZakończPolecenie(this);
            _edytor = new EdytorPolecenie(this);
            _usuń = new UsuńPolecenie(this);
            _wykonaj = new WykonajPolecenie(this);
            _informacje = new InformacjePolecenie(this);
        }

        /// <summary>
        /// Przypisuje do atrybutu <code>Tag</code> konkretny obiekt PolecenieBase.
        /// </summary>
        void BindowaniePolecen()
        {
            nowyPlikMenuItem.Tag = _nowyPlik;
            otwórzPlikMenuItem.Tag = _otwórz;
            nowaKwerendaMenuItem.Tag = _nowaKwerenda;
            importujKwerendyMenuItem.Tag = _importujKwerendy;
            dodajKwerendaMenuItem.Tag = _nowaKwerenda;
            dodajKontekstToolStripMenuItem.Tag = _nowaKwerenda;
            zamknijMenuItem.Tag = _zamknij;
            zapiszMenuItem.Tag = _zapisz;
            zapiszJakoMenuItem.Tag = _zapiszJako;
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
            _nazwaRepozytorium = nazwaPliku;
            _repozytorium = repozytorium;
            kwerendyView.Items.Clear();
            string title = GetTitle();
            if (string.IsNullOrEmpty(nazwaPliku))
            {
                Text = title;
            }
            else
            {
                Text = nazwaPliku + " - " + title;
                foreach (var q in repozytorium) AddQueryItem(q);
            }
        }

        /// <summary>
        /// Dodaj nową kwerendę do repozytorium.
        /// </summary>
        /// <param name="kwerenda"></param>
        public void DodajKwerendę(Kwerenda kwerenda)
        {
            _repozytorium.Dodaj(kwerenda);
            AddQueryItem(kwerenda);
        }

        void AddQueryItem(Kwerenda kwerenda)
        {
            kwerendyView.Items.Add(new KwerendaListViewItem(kwerenda));
        }

        internal void UsuńKwerendę(KwerendaListViewItem item)
        {
            _repozytorium.Usuń(item.Kwerenda);
            //Trzeba odświeżyć listę z repozytorium!
            //Nie wystarczy usunąć pozycji z listy, jeżeli na liście są dwie
            //identyczne kwerendy to zostanie usunięta pierwsza znaleziona,
            //a użytkownik mógł wybrać pozycję znajdującą się dalej na liście.
            //Jeżeli użytkownik będzie później edytował kwerendę nie zostanie ona
            //zapisana do repozytorium, bo została wcześniej usunięta.
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

        /// <summary>
        /// Wykonaj polecenie powiązane z wybraną pozycją w menu.
        /// </summary>
        /// <param name="sender"></param>
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
            foreach (KwerendaListViewItem item in kwerendyView.SelectedItems) return item;
            return null;
        }

        internal Kwerenda[] WybraneKwerendy()
        {
            List<Kwerenda> kwerendy = new List<Kwerenda>();
            foreach (KwerendaListViewItem item in kwerendyView.SelectedItems) kwerendy.Add(item.Kwerenda);
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
            foreach (ListViewItem item in kwerendyView.Items) item.Selected = true;
        }
    }
}
