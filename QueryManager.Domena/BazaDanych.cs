using System;
using System.Collections.Generic;
using System.Text;
using System.Data.OleDb;
using System.IO;

namespace QueryManager.Domena
{
    /// <summary>
    /// Reprezentuję bazę danych na której można wykonywać kwerendy.
    /// </summary>
    public class BazaDanych
    {
        private string _baza;

        public BazaDanych(string baza) { _baza = baza; }

        public override string ToString() { return _baza; }

        /// <summary>
        /// Wykonuję kwerendę na danej bazie.
        /// </summary>
        /// <param name="kwerenda"></param>
        /// <returns></returns>
        public int Wykonaj(Kwerenda kwerenda)
        {
            string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + _baza;
            return ExecuteNonQuery(kwerenda.Sql, connectionString);
        }

        int ExecuteNonQuery(string sql, string connectionString)
        {
            int rowsAffected = -1;
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand(sql, connection);
                rowsAffected = command.ExecuteNonQuery();
            }
            return rowsAffected;
        }
    }
}
