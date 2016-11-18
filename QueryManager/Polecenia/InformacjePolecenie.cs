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
                "Data publikacji: 18 listopada 2016\n" +
                "@ 2013-2016 Damian Hintz.\nWszelkie prawa zastrzeżone.",
                Application.ProductName, Application.ProductVersion),
                "Informacje o QueryManager",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}
