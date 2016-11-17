using System;
using System.Collections.Generic;
using System.Windows.Forms;
using QueryManager.Domena;

namespace QueryManager.Widok
{
    /// <summary>
    /// Edytor baz danych.
    /// </summary>
    public partial class EdytorBazy : Form
    {
        MainForm _form;
        List<Kwerenda> _kwerendy;

        /// <summary>
        /// Ustawia kwerendy, które można będzie wykonać dla wybranych baz.
        /// </summary>
        public Kwerenda[] Kwerendy
        {
            set
            {
                _kwerendy = new List<Kwerenda>(value);
                mainLabel.Text =
                    string.Format("Wybierz bazy danych, dla których wykonać kwerendy ({0} kwerend(y)).",
                    _kwerendy.Count);
                bazyView.Items.Clear();
                AddItems(_form.Baza);
            }
        }

        public EdytorBazy(MainForm form)
        {
            InitializeComponent();
            _form = form;
            Kwerendy = new Kwerenda[0];
        }

        private void wykonajButton_Click(object sender, EventArgs e)
        {
            foreach (BazaListViewItem item in bazyView.Items)
            {
                item.Wykonaj();
                Application.DoEvents();
                item.EnsureVisible();
            }
            MessageBox.Show(this, "Wykonywanie kwerend zakończone.", "Wykonaj");
        }

        private void przeglądajButton_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog.ShowDialog(this);
            if (result != DialogResult.OK) return;
            foreach (string file in openFileDialog.FileNames) AddItems(file);
        }

        private void AddItems(string file)
        {
            foreach (var query in _kwerendy) NewItem(file, query);
        }

        private void NewItem(string file, Kwerenda query)
        {
            if (string.IsNullOrEmpty(file)) return;
            var baza = new BazaDanych(file);
            bazyView.Items.Add(new BazaListViewItem(baza, query));
        }

        private void wykluczButton_Click(object sender, EventArgs e)
        {
            bazyView.Items.Clear();
        }
    }
}
