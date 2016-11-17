using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace QueryManager.Polecenia
{
    abstract class AbstrakcyjnePolecenie
    {
        protected MainForm _form;

        public AbstrakcyjnePolecenie(MainForm form)
        {
            _form = form;
        }

        public abstract void Wykonaj();
    }
}
