using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Models;

namespace DAL
{
    public class DAL_Ponto : IRepository
    {
        DAL_MontaComando monta;
        MO_DB db;
        string sql = "";

        /// <summary>
        /// inserir o ponto 
        /// </summary>
        /// <param name="p">parametro com dados de conta</param>
        public void inserirPonto(MO_Ponto p)
        {
            if (p != null)
            {
                monta = new DAL_MontaComando();
                db = new MO_DB();
                sql = "";

                db.tabela = MO_NomesBanco.tabelaPt;
                db.campos = string.Format("{0},{1},{2},{3},{4},{5}", MO_NomesBanco.idPt, MO_NomesBanco.fkUsuPt, MO_NomesBanco.dtEPt, MO_NomesBanco.dtSPt,
                    MO_NomesBanco.hrEPt, MO_NomesBanco.hrSPt);
                db.valores = string.Format("null,{0},'{1}','{2}','{3}','{4}'", p.idUsu, p.dataEntrada.ToString("dd/MM/yyyy"), 
                    "", p.hrEntrada.ToString(),"");

                sql = monta.montaInserir(db);
                executar(sql);
            }
            else throw new Exception("ERROR, tente novamente mais tarde.");
        }

        /// <summary>
        /// editando um ponto(fechando ele)
        /// </summary>
        /// <param name="p"></param>
        public void fecharPonto(MO_Ponto p)
        {
            if (p != null)
            {
                monta = new DAL_MontaComando();
                db = new MO_DB();
                sql = "";

                db.tabela = MO_NomesBanco.tabelaPt;
                db.campos = string.Format("{0}='{2}',{1}='{3}'", MO_NomesBanco.dtSPt, MO_NomesBanco.hrSPt,p.dataSaida.ToString("dd/MM/yyyy"), p.hrSaida.ToString());
                db.adicionais = string.Format("{0}={1}", MO_NomesBanco.idPt, pegaUltimoInserido());

                sql = monta.montaEditar(db);
                executar(sql);
            }
            else throw new Exception("ERROR, tente novamente mais tarde.");
        }

        /// <summary>
        /// pesquisa ponto
        /// </summary>
        /// <param name="where">cu</param>
        /// <param name="orderBy">cu</param>
        public List<MO_Ponto> pesquisaPonto(string where, string orderBy)
        {
            monta = new DAL_MontaComando();
            db = new MO_DB();
            sql = "";

            db.tabela = MO_NomesBanco.tabelaPt;
            db.campos = "*";
            if (where != null)
                db.adicionais = " WHERE " + where;
            if (orderBy != null)
                db.adicionais += " ORDER BY " + orderBy;

            sql = monta.montaSelecionar(db);
            return montaListaPonto(executaRetorno(sql));
        }

        /// <summary>
        /// retorna o ultimo id inserido
        /// </summary>
        /// <returns>ultimo id</returns>
        private int pegaUltimoInserido()
        {
            sql = "SELECT * FROM " + MO_NomesBanco.tabelaPt + " ORDER BY id DESC LIMIT 1";
            return (int)montaListaPonto(executaRetorno(sql))[0].id;
        }

        /// <summary>
        /// monta as listas é mais pratico q o restante e funciona melhor.
        /// </summary>
        /// <param name="dt">dados retornados do banco em forma de datatable</param>
        /// <returns>lista com todos os pontos</returns>
        private List<MO_Ponto> montaListaPonto(DataTable dt)
        {
            List<MO_Ponto> lP = new List<MO_Ponto>();
            MO_Ponto p;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                p = new MO_Ponto();

                p.id = int.Parse(dt.Rows[i][MO_NomesBanco.idPt].ToString());
                p.idUsu = int.Parse(dt.Rows[i][MO_NomesBanco.fkUsuPt].ToString());
                p.dataEntrada = Convert.ToDateTime(dt.Rows[i][MO_NomesBanco.dtEPt].ToString());
                p.dataSaida = dt.Rows[i][MO_NomesBanco.dtSPt].ToString() != "" ? Convert.ToDateTime(dt.Rows[i][MO_NomesBanco.dtSPt].ToString()) : DateTime.MinValue;
                p.hrEntrada = Convert.ToDateTime(dt.Rows[i][MO_NomesBanco.hrEPt].ToString());
                p.hrSaida = dt.Rows[i][MO_NomesBanco.hrSPt].ToString() != "" ? Convert.ToDateTime(dt.Rows[i][MO_NomesBanco.hrSPt].ToString()) : DateTime.MinValue;

                lP.Add(p);
            }
            return lP;
        }
    }
}
