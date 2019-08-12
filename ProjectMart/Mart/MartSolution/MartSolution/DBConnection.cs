using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MartSolution
{
    class DBConnection
    {
        private static OleDbConnection con;
        public static void Open()
        {
            try
            {
                con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|Database\martsolution.mdb;Jet OLEDB:Database Password=pur3bl00d");
                con.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        public static void Close()
        {
            con.Close();
        }
        public static void _Write(String query)
        {
            try
            {
                OleDbCommand cmd = new OleDbCommand(query, con);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        public static void _Write(String query, OleDbParameter[] oledbPList)
        {
            try
            {
                OleDbCommand cmd = new OleDbCommand(query, con);
                foreach (OleDbParameter par in oledbPList)
                {
                    cmd.Parameters.Add(par);
                }
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        public static OleDbDataReader _Read(String query)
        {
            try
            {
                OleDbCommand cmd = new OleDbCommand(query, con);
                return cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
        }
        public static OleDbDataReader _Read(String query ,OleDbParameter[] oledbPList)
        {
            try
            {
                OleDbCommand cmd = new OleDbCommand(query, con);
                if (oledbPList != null)
                {
                    foreach (OleDbParameter par in oledbPList)
                    {
                        cmd.Parameters.Add(par);
                    }
                }
                return cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
        }
        public static OleDbDataReader _ReadWithVals(String query, OleDbParameter[] oledbPList)
        {
            try
            {
                OleDbCommand cmd = new OleDbCommand(query, con);
                foreach (OleDbParameter par in oledbPList)
                {
                    cmd.Parameters.Add(par);
                }
                return cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
        }
    }
}
