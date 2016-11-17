using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace QueryManager
{
    static class Program
    {
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            string nazwaBazy = args.Length > 0 ? DekodowanieNazwy(args[0], "?") : null;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm(nazwaBazy));
        }

        static string DekodowanieNazwy(string nazwaBazy, string kodSpacji = "?")
        {
            if (string.IsNullOrEmpty(nazwaBazy)) return null;
            return nazwaBazy.Replace(kodSpacji, " ");
        }
    }
}
