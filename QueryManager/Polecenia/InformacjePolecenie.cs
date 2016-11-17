using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace QueryManager.Polecenia
{
    class InformacjePolecenie : AbstrakcyjnePolecenie
    {
        public InformacjePolecenie(MainForm form) : base(form) { }

        public override void Wykonaj()
        {
            MessageBox.Show(_form,
                string.Format("{0} - Zarządca kwerend\n" +
                "Wersja: {1}\n" +
                "Data publikacji: 22 grudnia 2015\n" +
                "@2013-2015 OPGK Olsztyn. Wszelkie prawa zastrzeżone.\n" +
                "Licencję na ten produkt posiada:\nOPGK Olszyn",
                Application.ProductName, Application.ProductVersion),
                "Informacje o QueryManager",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}
