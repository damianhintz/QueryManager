using System.Windows.Forms;
using QueryManager.Domena;
using QueryManager.Domena.Encje;

namespace QueryManager.Widok
{
    class KwerendaListViewItem : ListViewItem
    {
        private Kwerenda _kwerenda;

        public Kwerenda Kwerenda
        {
            get { return _kwerenda; }
            set
            {
                _kwerenda.Numer = SubItems[0].Text = value.Numer;
                _kwerenda.Nazwa = SubItems[1].Text = value.Nazwa;
                _kwerenda.Opis = SubItems[2].Text = value.Opis;
                _kwerenda.Sql = SubItems[3].Text = value.Sql;
            }
        }

        public KwerendaListViewItem(Kwerenda kwerenda)
            : base(new string[] { kwerenda.Numer, kwerenda.Nazwa, kwerenda.Opis, kwerenda.Sql })
        {
            _kwerenda = kwerenda;
        }
    }
}
