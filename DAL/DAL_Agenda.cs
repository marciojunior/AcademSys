using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Models;

namespace DAL
{
    public class DAL_Agenda : IRepository
    {
        MO_Agenda agenda = new MO_Agenda();
        DAL_MontaComando monta;
        MO_DB db;
        string sql;

        /// <summary>
        /// Inserir na agenda daquele determinado usuário..
        /// </summary>
        /// <param name="ag">carrega todas as informações da agenda</param>
        public void inserir(MO_Agenda ag)
        {
            if (ag != null)
            {
                db = new MO_DB();
                monta = new DAL_MontaComando();
                sql = "";

                db.tabela = MO_NomesBanco.tabelaAg;
                db.campos = string.Format("{0},{1},{2},{3},{4}", MO_NomesBanco.idAg, MO_NomesBanco.fkUsuAg,
                    MO_NomesBanco.dtAg, MO_NomesBanco.tituAg, MO_NomesBanco.descAg);
                db.valores = string.Format("null,{0},'{1}','{2}','{3}'", ag.idUsu, ag.data.ToString("dd/MM/yyyy"), ag.titulo, ag.descricao);

                sql = monta.montaInserir(db);
                executar(sql);
            }
        }

        /// <summary>
        /// Ediatr a agenda do usuario..
        /// </summary>
        /// <param name="ag">valores essencias para a agenda..</param>
        public void editarAgenda(MO_Agenda ag)
        {
            if (ag != null)
            {
                db = new MO_DB();
                monta = new DAL_MontaComando();
                sql = "";

                db.tabela = MO_NomesBanco.tabelaAg;
                db.campos = string.Format("{0}={4}, {1}='{5}', {2}='{6}', {3}='{7}'", MO_NomesBanco.fkUsuAg, MO_NomesBanco.dtAg, MO_NomesBanco.tituAg, MO_NomesBanco.descAg,
                    ag.idUsu, ag.data.ToString("dd/MM/yyyy"), ag.titulo, ag.descricao);
                db.adicionais = string.Format("{0}={1}", MO_NomesBanco.idAg, ag.id);

                sql = monta.montaEditar(db);
                executar(sql);
            }
        }

        /// <summary>
        /// Pesquisa todas as agendas daquele determinado usuário
        /// </summary>
        /// <param name="ag">dados necessarios para a busca da agenda</param>
        /// <returns></returns>
        public List<MO_Agenda> pesquisaTodas(MO_Agenda ag)
        {
            if (ag != null)
            {
                db = new MO_DB();
                monta = new DAL_MontaComando();
                sql = "";

                db.tabela = MO_NomesBanco.tabelaAg;
                db.campos = "*";
                //ordenando pela data..
                db.adicionais = string.Format(" WHERE {0}={1} ORDER BY {2}", MO_NomesBanco.fkUsuAg, ag.idUsu, MO_NomesBanco.dtAg);
                sql = monta.montaSelecionar(db);
                return montaLista(executaRetorno(sql));
            }
            else
                return null;
        }

        /// <summary>
        /// pesquisa todos dados da agenda referentes aquela data.
        /// </summary>
        /// <param name="ag">dados essencias da agenda</param>
        /// <returns>lista com todas as agendas</returns>
        public List<MO_Agenda> pesquisaPorData(MO_Agenda ag)
        {
            if (ag != null)
            {
                db = new MO_DB();
                monta = new DAL_MontaComando();
                sql = "";

                db.tabela = MO_NomesBanco.tabelaAg;
                db.campos = "*";
                //ordenando pela data..
                db.adicionais = string.Format(" WHERE {0}={1} and {2}='{3}'",
                    MO_NomesBanco.fkUsuAg, ag.idUsu, MO_NomesBanco.dtAg, ag.data.ToString("dd/MM/yyyy"));
                sql = monta.montaSelecionar(db);
                return montaLista(executaRetorno(sql));
            }
            else
                return null;
        }

        /// <summary>
        /// Monta a lista de agenda para ser retornada
        /// </summary>
        /// <param name="dt">recebe a resposta do banco em data table</param>
        /// <returns>retorna ela em lista</returns>
        private List<MO_Agenda> montaLista(DataTable dt)
        {
            MO_Agenda ag;
            List<MO_Agenda> lstAg = new List<MO_Agenda>();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ag = new MO_Agenda();
                ag.id = int.Parse(dt.Rows[i][MO_NomesBanco.idAg].ToString());
                ag.idUsu = int.Parse(dt.Rows[i][MO_NomesBanco.fkUsuAg].ToString());
                ag.data = Convert.ToDateTime(dt.Rows[i][MO_NomesBanco.dtAg].ToString());
                ag.titulo = dt.Rows[i][MO_NomesBanco.tituAg].ToString();
                ag.descricao = dt.Rows[i][MO_NomesBanco.descAg].ToString();

                lstAg.Add(ag);
            }
            return lstAg;
        }
    }
}
