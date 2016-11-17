using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace QueryManager.Polecenia
{
    class ZakończPolecenie : AbstrakcyjnePolecenie
    {
        public ZakończPolecenie(MainForm form)
            : base(form)
        {
        }

        public override void Wykonaj()
        {
            _form.Close();
        }
    }
}
