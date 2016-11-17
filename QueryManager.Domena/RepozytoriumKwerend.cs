using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace QueryManager.Domena
{
    /// <summary>
    /// Reprezentuję repozytorium kwerend.
    /// </summary>
    public class RepozytoriumKwerend : IEnumerable<Kwerenda>
    {
        List<Kwerenda> _kwerendy;

        /// <summary>
        /// Zwraca liczbę kwerend w repozytorium.
        /// </summary>
        public int Count { get { return _kwerendy.Count; } }

        public RepozytoriumKwerend() { _kwerendy = new List<Kwerenda>(); }
        public IEnumerator<Kwerenda> GetEnumerator() { return _kwerendy.GetEnumerator(); }
        IEnumerator IEnumerable.GetEnumerator() { return this.GetEnumerator(); }

        /// <summary>
        /// Dodaje nową kwerendę do repozytoriurm.
        /// </summary>
        /// <param name="kwerenda"></param>
        public void Dodaj(Kwerenda kwerenda) { _kwerendy.Add(kwerenda); }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>Potrzebna do serializacji.</remarks>
        /// <param name="kwerenda"></param>
        public void Add(object kwerenda) { Dodaj(kwerenda as Kwerenda); }

        /// <summary>
        /// Usuwa kwerendę z repozytorium.
        /// </summary>
        /// <param name="kwerenda"></param>
        public void Usuń(Kwerenda kwerenda) { _kwerendy.Remove(kwerenda); }
    }
}
