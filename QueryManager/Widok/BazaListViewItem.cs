using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using QueryManager.Domena.Encje;
using QueryManager.Domena;

namespace QueryManager.Widok
{
    class BazaListViewItem : ListViewItem
    {
        private BazaDanych _baza;
        private Kwerenda _kwerenda;

        public BazaListViewItem(BazaDanych baza, Kwerenda kwerenda)
            : base(new string[] { baza.ToString(), kwerenda.ToString(), "Oczekuję." })
        {
            _baza = baza;
            _kwerenda = kwerenda;
        }

        /// <summary>
        /// Wykonuję kwerendę powiązaną z bazą danych.
        /// </summary>
        public void Wykonaj()
        {
            SetWynik(string.Format("{0}", "Wykonuję..."));

            try
            {
                SetWynik(string.Format("Dotknięte wiersze: {0}", _baza.Wykonaj(_kwerenda)));
            }
            catch (Exception ex)
            {
                SetWynik(string.Format("Wystąpił błąd: {0}", ex.Message));
                ForeColor = System.Drawing.Color.Red;
            }
        }

        private void SetWynik(string wynik)
        {
            SubItems[2].Text = wynik;
        }
    }
}
