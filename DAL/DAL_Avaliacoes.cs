using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Models;

namespace DAL
{
    public class DAL_Avaliacoes : IRepository
    {
        MO_DB db;
        DAL_MontaComando monta;
        string sql = "";

        /// <summary>
        /// Executa o inserir de forma pratica possibilitada por nossos montadores
        /// </summary>
        /// <param name="ava">informações sobre a avaliação</param>
        public void inserirAvaliacao(MO_Avaliacao ava)
        {
            try 
            {
                if (ava != null)
                {
                    db = new MO_DB();
                    monta = new DAL_MontaComando();
                    sql = "";

                    db.tabela = MO_NomesBanco.tabelaAva;
                    db.campos = string.Format("{0},{1},{2},{3},{4}", MO_NomesBanco.idAva, MO_NomesBanco.fkCliAva, MO_NomesBanco.fkUsuAva,
                        MO_NomesBanco.dtAva, MO_NomesBanco.hrAva);
                    db.valores = string.Format("null,{0},{1},'{2}','{3}'", ava.idCli, ava.idUsu, ava.data, ava.hora);
                    //executa a barada
                    sql = monta.montaInserir(db);
                    executar(sql);
                }
                else throw new Exception("ERROR, tente novamente mais tarde.");
            }
            catch { throw new Exception("Falha ao inserir avaliação."); }
        }

        /// <summary>
        /// Editar avaliação selecionada
        /// </summary>
        /// <param name="ava">valores de avaliação</param>
        public void editarAvaliacao(MO_Avaliacao ava)
        {
            try
            {
                if (ava != null)
                {
                    db = new MO_DB();
                    monta = new DAL_MontaComando();
                    sql = "";

                    db.tabela = MO_NomesBanco.tabelaAva;
                    db.campos = string.Format("{0}={4},{1}={5},{2}='{6}',{3}='{7}'", MO_NomesBanco.fkCliAva, MO_NomesBanco.fkUsuAva, MO_NomesBanco.dtAva, MO_NomesBanco.hrAva,
                        ava.idCli, ava.idUsu, ava.data, ava.hora);
                    db.adicionais = string.Format("{0}={1}", MO_NomesBanco.idAva, ava.id);
                    //monta e executa
                    sql = monta.montaEditar(db);
                    executar(sql);
                }
                else throw new Exception("ERROR, tente novamente mais tarde.");
            }
            catch { throw new Exception("Falha ao editar avaliação."); }
        }

        /// <summary>
        /// excluir avaliação agendada, não é ligada a nada então podemos excluir permanentemente do banco de dados..
        /// </summary>
        /// <param name="ava">informaçoes sobre avaliação</param>
        public void deletarAvaliacao(MO_Avaliacao ava)
        {
            try
            {
                if (ava != null)
                {
                    db = new MO_DB();
                    monta = new DAL_MontaComando();
                    sql = "";

                    db.tabela = MO_NomesBanco.tabelaAva;
                    db.adicionais = string.Format("{0}={1}", MO_NomesBanco.idAva, ava.id);
                    //monta a parada
                    sql = monta.montaExcluir(db);
                    executar(sql);
                }
                else throw new Exception("ERROR, tente novamente mais tarde.");
            }
            catch { throw new Exception("Falha ao excluir avaliação."); }
        }

        /// <summary>
        /// procurar, sendo especificado pela bll, fica mais generico e eu economizo na digitação!! kkkk
        /// </summary>
        /// <param name="where">condição para ser executada</param>
        /// <returns></returns>
        public List<MO_Avaliacao> procurarAvaliacoes(string where)
        {
            try
            {
                db = new MO_DB();
                monta = new DAL_MontaComando();
                sql = "";

                db.tabela = MO_NomesBanco.tabelaAva;
                db.campos = "*";
                if (where != null)
                    db.adicionais = " WHERE " + where;

                sql = monta.montaSelecionar(db);
                return montaLista(executaRetorno(sql));
            }
            catch { throw new Exception("Falha ao fazer busca de avaliação."); }
        }

        /// <summary>
        /// Monta a lista, mais facil de trabalhar, de visualizar tb, separando hierarquias
        /// </summary>
        /// <param name="dt">retorno do banco de dados em forma de data table</param>
        /// <returns>retorna uma lista com as avaliações</returns>
        private List<MO_Avaliacao> montaLista(DataTable dt)
        {
            List<MO_Avaliacao> listaAva = new List<MO_Avaliacao>();
            MO_Avaliacao ava;

            for (int i = (dt.Rows.Count - 1); i >= 0; i--)
            {
                ava = new MO_Avaliacao();

                ava.id = int.Parse(dt.Rows[i][MO_NomesBanco.idAva].ToString());
                ava.idCli = int.Parse(dt.Rows[i][MO_NomesBanco.fkCliAva].ToString());
                ava.idUsu = int.Parse(dt.Rows[i][MO_NomesBanco.fkUsuAva].ToString());
                ava.data = dt.Rows[i][MO_NomesBanco.dtAva].ToString();
                ava.hora = dt.Rows[i][MO_NomesBanco.hrAva].ToString();

                listaAva.Add(ava);
            }

            return listaAva;
        }
    }
}
