using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Models;

namespace DAL
{
    public class DAL_Cliente : IRepository
    {
        MO_DB db;
        DAL_MontaComando monta;
        string sql;

        /// <summary>
        /// Inserindo a primeira parte de cliente que seria os dados principais de clientes
        /// </summary>
        /// <param name="cl">dados principais do cliente</param>
        /// <returns>id deste cliente que fora inserido no banco(SELECT LAST_INSERT_ID())</returns>
        public void inserirUsuario(MO_Cliente cl)
        {
            if (cl != null)
            {
                sql = "";
                db = new MO_DB();
                monta = new DAL_MontaComando();

                db.tabela = MO_NomesBanco.tabelaCli;
                db.campos = string.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12}", 
                    MO_NomesBanco.idCli, MO_NomesBanco.fkUsuCli, MO_NomesBanco.matricCli, MO_NomesBanco.nomeCli, MO_NomesBanco.telCli, MO_NomesBanco.celCli,
                    MO_NomesBanco.sexCli, MO_NomesBanco.cpfCli, MO_NomesBanco.identCli, MO_NomesBanco.ufIdentCli, MO_NomesBanco.emailCli,
                    MO_NomesBanco.dtNCli, MO_NomesBanco.statCli);

                db.valores = string.Format("null,{0},{1},'{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}',{11}",
                    cl.idUsu, cl.matricula, cl.nome, cl.telefone, cl.celular, cl.sexo, cl.cpf, cl.identidade, cl.ufIdentidade, cl.email, cl.nasc, (int)cl.status);

                sql = monta.montaInserir(db);
                executar(sql);
            }
            else throw new Exception("Error, tente novamente mais tarde!");
        }

        /// <summary>
        /// Ediatando os dados do cliente, primeira parte para so cliente..
        /// </summary>
        /// <param name="cli">dados principais do cliente</param>
        public void atualiza(MO_Cliente cli)
        {
            if (cli != null)
            {
                db = new MO_DB();
                monta = new DAL_MontaComando();
                sql = "";

                db.tabela = MO_NomesBanco.tabelaCli;
                db.campos = string.Format("{0}={11}, {1}='{12}', {2}='{13}', {3}='{14}', {4}='{15}', {5}='{16}', {6}='{17}', {7}='{18}', {8}='{19}', {9}='{20}', {10}={21}",
                    MO_NomesBanco.matricCli, MO_NomesBanco.nomeCli, MO_NomesBanco.telCli, MO_NomesBanco.celCli, MO_NomesBanco.sexCli, MO_NomesBanco.cpfCli, 
                    MO_NomesBanco.identCli, MO_NomesBanco.ufIdentCli, MO_NomesBanco.emailCli, MO_NomesBanco.dtNCli, MO_NomesBanco.statCli,
                    cli.matricula, cli.nome, cli.telefone, cli.celular, cli.sexo, cli.cpf, cli.identidade, cli.ufIdentidade, cli.email, 
                    cli.nasc, (int)cli.status);

                db.adicionais = string.Format("{0}={1}", MO_NomesBanco.idCli, cli.idCli);
                sql = monta.montaEditar(db);
                executar(sql);
            }
            else throw new Exception("ERROR, tente novamente mais tarde!");
        }

        /// <summary>
        /// pesquisa clientes em todos os tipos, generico para ser manipulado na BLL, vamos economizar codigo!
        /// </summary>
        /// <param name="where">clausulas para where, excessão para economisar codigo, montados na BLL</param>
        /// <param name="orderBy">ordenar</param>
        /// <param name="like">para nome ou algo do tipo</param>
        /// <returns>retorna os dados dos clientes contidos em uma lista</returns>
        public List<MO_Cliente> pesquisaClientes(string where, string orderBy, string like)
        {
            sql = "";
            db = new MO_DB();
            monta = new DAL_MontaComando();

            db.tabela = MO_NomesBanco.tabelaCli;
            db.campos = "*";
            //clausulas
            if (where != null)
                db.adicionais = " WHERE " + where;
            if (like != null)
                db.adicionais += where != null ? string.Format(" AND nome LIKE '%{0}%'", like) : string.Format(" LIKE '%{0}%'", like);
            if (orderBy != null)
                db.adicionais += " ORDER BY " + orderBy;

            sql = monta.montaSelecionar(db);
            return montaLista(executaRetorno(sql));
        }

        /// <summary>
        /// seleciona a ultima linha para obter o id..
        /// </summary>
        /// <returns>Modelo de Cliente com as suas informações inseridas</returns>
        public MO_Cliente selecionarUltimaLinhaInserida()
        {
            db = new MO_DB();
            monta = new DAL_MontaComando();
            sql = "";

            db.tabela = MO_NomesBanco.tabelaCli;
            db.campos = "*";
            db.adicionais = " ORDER BY id DESC LIMIT 1";

            sql = monta.montaSelecionar(db);
            return montaLista(executaRetorno(sql))[0];
        }

        /// <summary>
        /// transforma o dataTable para uma lista de clientes, pois é mais facil de ser manipulada
        /// </summary>
        /// <param name="dt">a resposta do banco de dados</param>
        /// <returns>lista com usuarios</returns>
        private List<MO_Cliente> montaLista(DataTable dt)
        {
            List<MO_Cliente> listCli = new List<MO_Cliente>();
            MO_Cliente cli = new MO_Cliente();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cli = new MO_Cliente();

                cli.idCli = int.Parse(dt.Rows[i][MO_NomesBanco.idCli].ToString());
                cli.idUsu = int.Parse(dt.Rows[i][MO_NomesBanco.fkUsuCli].ToString());
                cli.matricula = int.Parse(dt.Rows[i][MO_NomesBanco.matricCli].ToString());
                cli.nome = dt.Rows[i][MO_NomesBanco.nomeCli].ToString();
                cli.telefone = dt.Rows[i][MO_NomesBanco.telCli].ToString();
                cli.celular = dt.Rows[i][MO_NomesBanco.celCli].ToString();
                cli.sexo = dt.Rows[i][MO_NomesBanco.sexCli].ToString();
                cli.cpf = dt.Rows[i][MO_NomesBanco.cpfCli].ToString();
                cli.identidade = dt.Rows[i][MO_NomesBanco.identCli].ToString();
                cli.ufIdentidade = dt.Rows[i][MO_NomesBanco.ufIdentCli].ToString();
                cli.email = dt.Rows[i][MO_NomesBanco.emailCli].ToString();
                cli.nasc = Convert.ToDateTime(dt.Rows[i][MO_NomesBanco.dtNCli].ToString());
                cli.status = (Status)dt.Rows[i][MO_NomesBanco.statCli];

                listCli.Add(cli);
            }
  
            return listCli;
        }
    }
}
