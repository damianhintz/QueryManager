using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QueryManager.Domena.Repozytoria;

namespace QueryManager.Widok
{
    class KwerendyListView
    {
        ListView _view;
        public RepozytoriumKwerend Kwerendy { get; set; }

        public KwerendyListView(ListView view, RepozytoriumKwerend kwerendy)
        {
            Kwerendy = kwerendy;
            _view = view;
            _view.RetrieveVirtualItem += retrieveVirtualItem;
        }

        private void retrieveVirtualItem(object sender, RetrieveVirtualItemEventArgs e)
        {
            var q = Kwerendy.ElementAt(e.ItemIndex);
            var item = new KwerendaListViewItem(q);
            e.Item = item;
        }
    }
}
