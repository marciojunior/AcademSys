using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Odbc;

namespace DAL
{
    public abstract class IRepository
    {
        OdbcConnection con;
        private void connect()
        {
            string strConnec = "Driver={MySQL ODBC 5.1 Driver};server=localhost;user=root;pwd=;database=AcademSys";
          
            con = new OdbcConnection(strConnec);
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        private void disconnect()
        {
            try
            {
                //evitar erros
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                    con.Dispose();
                }
            }
            catch { throw new Exception("Erro ao desconectar da base de dados!"); }
        }

        public void executar(string sql)
        {
            OdbcCommand com;
            try
            {
                connect();
                com = new OdbcCommand(sql, con);
                com.ExecuteNonQuery();
            }
            catch { throw new Exception("Erro ao executar instrução!"); }
            finally { disconnect(); }
        }

        public DataTable executaRetorno(string sql)
        {
            DataTable dt = new DataTable();
            OdbcDataAdapter da;

            try
            {
                connect();
                da = new OdbcDataAdapter(sql, con);
                da.Fill(dt);
            }
            catch { throw new Exception("Falha ao executar busca!"); }
            finally { disconnect(); }

            return dt; 
        }
    }
}
