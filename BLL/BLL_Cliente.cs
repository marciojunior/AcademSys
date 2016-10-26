using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Models;
using DAL;

namespace BLL
{
    public class BLL_Cliente
    {
        DAL_Cliente cliDAL = new DAL_Cliente();

        /// <summary>
        /// inserindo os dados basicos de cliente
        /// </summary>
        /// <param name="cli">dados principais de cliente</param>
        public int inserir(MO_Cliente cli)
        {
            if (cli != null)
            {
                filtraDados(cli);
                cliDAL.inserirUsuario(cli);
                return (int)cliDAL.selecionarUltimaLinhaInserida().idCli;
            }
            else throw new Exception("ERROR, tente novamente mais tarde.");
        }

        /// <summary>
        /// Atualiza o cliente
        /// </summary>
        /// <param name="cli">dados do cliente para serem atualizados</param>
        public void atualizar(MO_Cliente cli)
        {
            if (cli != null)
            {
                filtraDados(cli);
                cliDAL.atualiza(cli);
            }
            else throw new Exception("ERROR, tente novamente mais tarde.");
        }

        /// <summary>
        /// Seleciona todos os clientes que estão ativos
        /// </summary>
        /// <returns></returns>
        public List<MO_Cliente> buscaTodosClientesAtivos()
        {
            string where = "";

            where = string.Format("{0}={1}", MO_NomesBanco.statCli, (int)Status.ativo);
            return cliDAL.pesquisaClientes(where, null, null);
        }

        /// <summary>
        /// Para buscar um cliente em especifico    
        /// </summary>
        /// <param name="cli">dados de cliente em especifico id..</param>
        /// <returns>conteudo deste cliente</returns>
        public List<MO_Cliente> buscaClienteId(MO_Cliente cli)
        {
            if (cli != null)
            {
                if (cli.idCli != null)
                {
                    cliDAL = new DAL_Cliente();
                    return cliDAL.pesquisaClientes(string.Format("{0}={1}", MO_NomesBanco.idCli, cli.idCli), null, null);
                }
                else throw new Exception("ERROR, id do cliente não pode ser null.");
            }
            else throw new Exception("ERROR, tente novamente mais tarde.");
        }

        /// <summary>
        /// Busca todos os clientes que podem ser alocados em uma turma
        /// </summary>
        /// <param name="sexo">sexo do cliente se a turma poder entrar mais de um enviar null</param>
        /// <returns>uma lista com todos clientes que estão na turma</returns>
        public List<MO_Cliente> buscaClienteParaTurma(string sexo)
        {
            string where = "";
            cliDAL = new DAL_Cliente();

            where = string.Format("{0}={1}", MO_NomesBanco.statCli, (int)Status.ativo);
            if (sexo != null)
                where += string.Format(" AND {0}='{1}'", MO_NomesBanco.sexCli, sexo);

            return cliDAL.pesquisaClientes(where, null, null);
        }

        /// <summary>
        /// Pesquisa clientes atualizando pelo nome..
        /// </summary>
        /// <param name="nome">like no nome</param>
        /// <returns>lista com todos os clientes</returns>
        public List<MO_Cliente> buscaClienteNome(string nome)
        {
            cliDAL = new DAL_Cliente();
            return cliDAL.pesquisaClientes(string.Format("{0}={1}", MO_NomesBanco.statCli, (int)Status.ativo), null, nome);
        }

        /// <summary>
        /// verificações padores
        /// </summary>
        /// <param name="cli">dados de cliente</param>
        /// <returns>true se tudo ok</returns>
        private bool filtraDados(MO_Cliente cli)
        {
            if (cli.matricula != null)
                if (cli.nome != string.Empty)
                    if (cli.identidade != string.Empty)
                        return true;
                    else throw new Exception("preencha o campo de identidade!");
                else throw new Exception("preencha o campo de nome!");
            else throw new Exception("preencha o campo de nome!");

        }
    }
}
