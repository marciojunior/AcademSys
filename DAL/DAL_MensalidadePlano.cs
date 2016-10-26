using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Models;

namespace DAL
{
    public class DAL_MensalidadePlano : IRepository
    {
        DAL_MontaComando monta;
        MO_DB db;
        string sql;

        /// <summary>
        /// Inserindo uma relação entre Mensalidade e plano --
        /// </summary>
        /// <param name="mp">dados de mensalidade e plano</param>
        public void inserirMP(MO_MensalidadePlano mp)
        {
            if (mp != null)
            {
                monta = new DAL_MontaComando();
                db = new MO_DB();
                sql = string.Empty;

                db.tabela = MO_NomesBanco.tabelaMenPlan;
                db.campos = string.Format("{0},{1},{2}", MO_NomesBanco.idMenPlan, MO_NomesBanco.fkMenMenPlan, MO_NomesBanco.fkPlanMenPlan);
                db.valores = string.Format("null,{0},{1}", mp.idMens, mp.idPlano);

                sql = monta.montaInserir(db);
                executar(sql);
            }
            else throw new Exception("ERROR, tente novamente mais tarde.");
        }

        /// <summary>
        /// Edita informação de uma relação.. 
        /// </summary>
        /// <param name="mp"></param>
        public void editarMP(MO_MensalidadePlano mp)
        {
            if (mp != null)
            {
                monta = new DAL_MontaComando();
                db = new MO_DB();
                sql = string.Empty;

                db.tabela = MO_NomesBanco.tabelaMenPlan;
                db.campos = string.Format("{0}={2},{1}={3}", MO_NomesBanco.fkMenMenPlan, MO_NomesBanco.fkPlanMenPlan, mp.idMens, mp.idPlano);
                db.adicionais = string.Format("{0}={1}", MO_NomesBanco.idMenPlan, mp.id);

                sql = monta.montaEditar(db);
                executar(sql);
            }
            else throw new Exception("ERROR, tente novamente mais tarde.");
        }

        /// <summary>
        /// Excluir uma relação..
        /// </summary>
        /// <param name="mp">dados da relação</param>
        public void excluir(MO_MensalidadePlano mp)
        {
            if (mp != null)
            {
                monta = new DAL_MontaComando();
                db = new MO_DB();
                sql = string.Empty;

                db.tabela = MO_NomesBanco.tabelaMenPlan;
                db.adicionais = string.Format("{0}={1}", MO_NomesBanco.idMenPlan, mp.id);

                sql = monta.montaExcluir(db);
                executar(sql);
            }
            else throw new Exception("ERROR, tente novamente mais tarde.");
        }

        /// <summary>
        /// Pesquisa todas os tipos, exemplo de buscas:
        /// pesquisarMP(string.Empty, string.Empty);
        /// </summary>
        /// <param name="where">clausula de busca, condição</param>
        /// <param name="orderBy">ordenação da busca</param>
        /// <returns>lista com objetos</returns>
        public List<MO_MensalidadePlano> pesquisarMP(string where, string orderBy)
        {
            monta = new DAL_MontaComando();
            db = new MO_DB();
            sql = string.Empty;

            db.tabela = MO_NomesBanco.tabelaMenPlan;
            db.campos = "*";
            if (where != string.Empty)
                db.adicionais = string.Format(" WHERE {0}", where);
            if (orderBy != string.Empty)
                db.adicionais += string.Format(" ORDER BY {0}", orderBy);

            sql = monta.montaSelecionar(db);
            return montaLista(executaRetorno(sql));
        }

        /// <summary>
        /// Monta a lista com os objetos
        /// </summary>
        /// <param name="dt">resultado do banco de dados</param>
        /// <returns>lista com objetos</returns>
        private List<MO_MensalidadePlano> montaLista(DataTable dt)
        {
            List<MO_MensalidadePlano> lMP = new List<MO_MensalidadePlano>();
            MO_MensalidadePlano MP;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                MP = new MO_MensalidadePlano();
                MP.id = int.Parse(dt.Rows[i][MO_NomesBanco.idMenPlan].ToString());
                MP.idMens = int.Parse(dt.Rows[i][MO_NomesBanco.fkMenMenPlan].ToString());
                MP.idPlano = int.Parse(dt.Rows[i][MO_NomesBanco.fkPlanMenPlan].ToString());

                lMP.Add(MP);
            }
            return lMP;
        }
    }
}
