using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Models;

namespace DAL
{
    public class DAL_Plano : IRepository
    {
        DAL_MontaComando monta;
        MO_DB db;
        string sql;

        /// <summary>
        /// inserindo um plano no banco de dados
        /// </summary>
        /// <param name="p">dados essencias de plano</param>
        public void inserirPlano(MO_Plano p)
        {
            if (p != null)
            {
                monta = new DAL_MontaComando();
                db = new MO_DB();
                sql = string.Empty;

                db.tabela = MO_NomesBanco.tabelaPlan;
                db.campos = string.Format("{0},{1},{2},{3},{4},{5}", MO_NomesBanco.idPlan, MO_NomesBanco.fkUsuPlan, MO_NomesBanco.nomePlan, MO_NomesBanco.qtdVPlan,
                    MO_NomesBanco.valPlan, MO_NomesBanco.statPlan);
                db.valores = string.Format("null,{0},'{1}',{2},{3},{4}", p.idUsu, p.nome, p.qtdAula, p.valor.ToString().Replace(",", "."), (int)Status.ativo);

                sql = monta.montaInserir(db);
                executar(sql);
            }
            else throw new Exception("ERROR, tente novamente mais tarde.");
        }

        /// <summary>
        /// Editando certo plano..
        /// </summary>
        /// <param name="p">dados essenciais de plano</param>
        public void editarPlano(MO_Plano p)
        {
            if (p != null)
            {
                monta = new DAL_MontaComando();
                db = new MO_DB();
                sql = string.Empty;

                db.tabela = MO_NomesBanco.tabelaPlan;
                db.campos = string.Format("{0}={5},{1}='{6}',{2}={7},{3}={8},{4}={9}", MO_NomesBanco.fkUsuPlan, MO_NomesBanco.nomePlan, MO_NomesBanco.qtdVPlan,
                    MO_NomesBanco.valPlan, MO_NomesBanco.statPlan, p.idUsu, p.nome, p.qtdAula, p.valor.ToString().Replace(",", "."), (int)p.stat);
                db.adicionais = string.Format("{0}={1}", MO_NomesBanco.idPlan, p.id);

                sql = monta.montaEditar(db);
                executar(sql);
            }
            else throw new Exception("ERROR, tente novamente mais tarde.");
        }

        /// <summary>
        /// procurar todos os planos: exemplo:
        /// procurarPlano(string.Empty, string.Empty);
        /// </summary>
        /// <param name="where">condição para a busca</param>
        /// <param name="orderBy">ordenando a busca</param>
        /// <returns>lista com todos os planos</returns>
        public List<MO_Plano> procurarPlano(string where, string orderBy)
        {
            monta = new DAL_MontaComando();
            db = new MO_DB();
            sql = string.Empty;

            db.tabela = MO_NomesBanco.tabelaPlan;
            db.campos = "*";
            if (where != string.Empty)
                db.adicionais = string.Format(" WHERE {0}", where);
            if (orderBy != string.Empty)
                db.adicionais += string.Format(" ORDER BY {0}", orderBy);

            sql = monta.montaSelecionar(db);
            return montarLista(executaRetorno(sql));
        }

        /// <summary>
        /// Transforma em uma lista de objetos, mais facil de se trabalhar!
        /// </summary>
        /// <param name="dt">resultado do banco em data table</param>
        /// <returns>lista com todos os planos</returns>
        private List<MO_Plano> montarLista(DataTable dt)
        {
            List<MO_Plano> lPlan = new List<MO_Plano>();
            MO_Plano p;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                p = new MO_Plano();
                p.id = int.Parse(dt.Rows[i][MO_NomesBanco.idPlan].ToString());
                p.idUsu = int.Parse(dt.Rows[i][MO_NomesBanco.fkUsuPlan].ToString());
                p.nome = dt.Rows[i][MO_NomesBanco.nomePlan].ToString();
                p.qtdAula = int.Parse(dt.Rows[i][MO_NomesBanco.qtdVPlan].ToString());
                p.valor = double.Parse(dt.Rows[i][MO_NomesBanco.valPlan].ToString().Replace(".", ","));
                p.stat = (Status)dt.Rows[i][MO_NomesBanco.statPlan];

                lPlan.Add(p);
            }
            return lPlan;
        }
    }
}
