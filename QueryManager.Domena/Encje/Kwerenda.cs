using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace QueryManager.Domena.Encje
{
    /// <summary>
    /// Reprezentuje kwerendę SQL.
    /// </summary>
    public class Kwerenda : IEquatable<Kwerenda>
    {
        public string Numer { get; set; }

        /// <summary>
        /// Zwraca/ustawia nazwę kwerendy.
        /// </summary>
        public string Nazwa { get; set; }
        
        /// <summary>
        /// Zwraca/ustawia opis kwerendy.
        /// </summary>
        public string Opis { get; set; }

        /// <summary>
        /// Zwraca/ustawia kwerendę.
        /// </summary>
        public string Sql { get; set; }

        public Kwerenda() : this("", "", "") { }
        public Kwerenda(string nazwa, string opis, string sql) : this("", nazwa, opis, sql) { }
        public Kwerenda(string numer, string nazwa, string opis, string sql)
        {
            Numer = numer;
            Nazwa = nazwa;
            Opis = opis;
            Sql = sql;
        }

        public bool Equals(Kwerenda other)
        {
            if (other == null) return false;
            if (!other.Sql.Equals(Sql)) return false;
            if (!other.Nazwa.Equals(Nazwa)) return false;
            if (!other.Opis.Equals(Opis)) return false;
            if (!other.Numer.Equals(Numer)) return false;
            return true;
        }

        public override bool Equals(object obj) { return this.Equals(obj as Kwerenda); }
        public override int GetHashCode() { return Sql.GetHashCode(); }
        public override string ToString() { return Nazwa; }
    }
}
