using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Models;

namespace DAL
{
    public class DAL_Contas : IRepository
    {
        DAL_MontaComando monta;
        MO_DB db;
        string sql = "";

        #region Contas Pagar
        /// <summary>
        /// inserindo uma conta para que seja paga.
        /// </summary>
        /// <param name="cp">informações sobre a conta que ira ser paga</param>
        public void inserirContaPagar(MO_ContasPagar cp)
        {
            monta = new DAL_MontaComando();
            db = new MO_DB();
            sql = "";

            db.tabela = MO_NomesBanco.tabelaCP;
            db.campos = string.Format("{0},{1},{2},{3},{4}", MO_NomesBanco.idCP, MO_NomesBanco.fkUsuCP, MO_NomesBanco.valCP, MO_NomesBanco.motCP, MO_NomesBanco.pagCP);
            db.valores = string.Format("null,{0},{1},'{2}',{3}", cp.idUsu, cp.valor.ToString().Replace(",", "."), cp.motivo, (int)cp.pag);

            sql = monta.montaInserir(db);
            executar(sql);
        }

        /// <summary>
        /// Serve tanto para editar como para excluir(manter a consistencia de dados.)
        /// </summary>
        /// <param name="cp">dados essenciais de contas</param>
        public void editarContaPagar(MO_ContasPagar cp)
        {
            monta = new DAL_MontaComando();
            db = new MO_DB();
            sql = "";

            db.tabela = MO_NomesBanco.tabelaCP;
            db.campos = string.Format("{0}={4},{1}={5},{2}='{6}',{3}={7}", MO_NomesBanco.fkUsuCP, MO_NomesBanco.valCP, MO_NomesBanco.motCP, 
                MO_NomesBanco.pagCP, cp.idUsu, cp.valor.ToString().Replace(",", "."), cp.motivo, (int)cp.pag);
            db.adicionais = string.Format("{0}={1}", MO_NomesBanco.idCP, cp.id);

            sql = monta.montaEditar(db);
            executar(sql);
        }

        /// <summary>
        /// Procura contas a pagar 
        /// exemplo na utilização do metodo procurarContasP(null, null);
        /// /\/\ busca todas as contas 
        /// </summary>
        /// <param name="where">condição</param>
        /// <param name="orderBy">ordenação</param>
        /// <returns>lista com todas as contas a serem pagas</returns>
        public List<MO_ContasPagar> procurarContasP(string where, string orderBy)
        {
            monta = new DAL_MontaComando();
            db = new MO_DB();
            sql = "";

            db.tabela = MO_NomesBanco.tabelaCP;
            db.campos = "*";
            if (where != null)
                db.adicionais = string.Format(" WHERE {0}", where);
            if (orderBy != null)
                db.adicionais += string.Format(" ORDER BY {0}", orderBy);

            sql = monta.montaSelecionar(db);
            return montaListaContaP(executaRetorno(sql));
        }

        /// <summary>
        /// transforma para lista mais eficiente e melhor para se trabalhar..
        /// </summary>
        /// <param name="dt">retorno do banco</param>
        /// <returns>lista com todas as contas para pagar</returns>
        private List<MO_ContasPagar> montaListaContaP(DataTable dt)
        {
            List<MO_ContasPagar> listCP = new List<MO_ContasPagar>();
            MO_ContasPagar cp;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cp = new MO_ContasPagar();
                cp.id = int.Parse(dt.Rows[i][MO_NomesBanco.idCP].ToString());
                cp.idUsu = int.Parse(dt.Rows[i][MO_NomesBanco.fkUsuCP].ToString());
                cp.valor = double.Parse(dt.Rows[i][MO_NomesBanco.valCP].ToString());
                cp.motivo = dt.Rows[i][MO_NomesBanco.motCP].ToString();
                cp.pag = (Pago)int.Parse(dt.Rows[i][MO_NomesBanco.pagCP].ToString());

                listCP.Add(cp);
            }
            return listCP;
        }
#endregion

        #region Contas Receber

        /// <summary>
        /// inserindo uma conta para receber.
        /// </summary>
        /// <param name="cr">dados da conta recebida</param>
        public void inserirContasReceber(MO_ContasReceber cr)
        {
            monta = new DAL_MontaComando();
            db = new MO_DB();
            sql = "";

            db.tabela = MO_NomesBanco.tabelaCR;
            db.campos = string.Format("{0},{1},{2},{3},{4},{5}", MO_NomesBanco.idCR, MO_NomesBanco.fkUsuCR, MO_NomesBanco.fkCliCR, MO_NomesBanco.valCR, 
                MO_NomesBanco.motCR, MO_NomesBanco.fPagCR);
            db.valores = string.Format("null,{0},null,{1},'{2}',{3}", cr.idUsu, cr.valor.ToString().Replace(",", "."), cr.motivo, (int)cr.fp);

            sql = monta.montaInserir(db);
            executar(sql);
        }

        /// <summary>
        /// atualizando uma conta que ira receber
        /// </summary>
        /// <param name="cr">dados da conta que vai receber</param>
        public void editarContasReceber(MO_ContasReceber cr)
        {
            monta = new DAL_MontaComando();
            db = new MO_DB();
            sql = "";

            db.tabela = MO_NomesBanco.tabelaCR;
            db.campos = string.Format("{0}={5},{1}=null,{2}={6},{3}='{7}',{4}={8}", MO_NomesBanco.fkUsuCR, MO_NomesBanco.fkCliCR, MO_NomesBanco.valCR,
                MO_NomesBanco.motCR, MO_NomesBanco.fPagCR, cr.idUsu, cr.valor.ToString().Replace(",", "."), cr.motivo, (int)cr.fp);
            db.adicionais = string.Format("{0}={1}", MO_NomesBanco.idCR, cr.id);

            sql = monta.montaEditar(db);
            executar(sql);
        }

        /// <summary>
        /// procura todas as contas que seram recebidas:
        ///     procurarContasReceber(null, null, null);
        /// </summary>
        /// <param name="where">condição para executar</param>
        /// <param name="orderBy">condição para ordenar</param>
        public List<MO_ContasReceber> procurarContasReceber(string where, string orderBy)
        {
            monta = new DAL_MontaComando();
            db = new MO_DB();
            sql = "";

            db.tabela = MO_NomesBanco.tabelaCR;
            db.campos = "*";
            if (where != null)
                db.adicionais = " WHERE " + where;
            if (orderBy != null)
                db.adicionais += " ORDER BY " + orderBy;

            sql = monta.montaSelecionar(db);
            return montaListaContasRecber(executaRetorno(sql));
        }

        /// <summary>
        /// Mais facil de manipular e de trabalhar
        /// </summary>
        /// <param name="dt">retorno do banco em data table</param>
        /// <returns>lista com todas as contas recebidas</returns>
        private List<MO_ContasReceber> montaListaContasRecber(DataTable dt)
        {
            List<MO_ContasReceber> listCR = new List<MO_ContasReceber>();
            MO_ContasReceber CR;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                CR = new MO_ContasReceber();
                CR.id = int.Parse(dt.Rows[i][MO_NomesBanco.idCR].ToString());
                CR.idUsu = int.Parse(dt.Rows[i][MO_NomesBanco.fkUsuCR].ToString());
                //CR.idCli = int.Parse(dt.Rows[i][MO_NomesBanco.fkCliCR].ToString());
                CR.valor = double.Parse(dt.Rows[i][MO_NomesBanco.valCR].ToString());
                CR.motivo = dt.Rows[i][MO_NomesBanco.motCR].ToString();
                CR.fp = (FormaP)int.Parse(dt.Rows[i][MO_NomesBanco.fPagCR].ToString());

                listCR.Add(CR);
            }
            return listCR;
        }

        #endregion
    }
}
