using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QueryManager.Domena.Encje;
using QueryManager.Domena;

namespace QueryManager.Widok
{
    /// <summary>
    /// Edytor kwerendy.
    /// </summary>
    public partial class EdytorKwerendy : Form
    {
        /// <summary>
        /// Zwraca/ustawia kopię kwerendy.
        /// </summary>
        public Kwerenda Kwerenda
        {
            get
            {
                return
                    new Kwerenda(numerTextBox.Text, nazwaTextBox.Text, opisTextBox.Text, sqlTextBox.Text);
            }

            set
            {
                numerTextBox.Text = value.Numer;
                nazwaTextBox.Text = value.Nazwa;
                opisTextBox.Text = value.Opis;
                sqlTextBox.Text = value.Sql;
            }
        }

        public EdytorKwerendy()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
