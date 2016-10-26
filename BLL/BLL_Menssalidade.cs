using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using Models;

namespace BLL
{
    public class BLL_Menssalidade
    {
        DAL_Menssalidade mDAL = new DAL_Menssalidade();

        /// <summary>
        /// inserir uma menssalidade, 
        /// </summary>
        /// <param name="mens">dados de menssalidade</param>
        public void inserir(MO_Menssalidade mens)
        {
            if (verificaFiltros(mens))
                mDAL.inserirMenssalidade(mens);
        }

        /// <summary>
        /// atualiza uma menssalidade em especifico.
        /// </summary>
        /// <param name="mens">dados de menssalidade</param>
        public void atualizar(MO_Menssalidade mens)
        {
            if (verificaFiltros(mens))
                mDAL.atualizarMenssalidade(mens);
        }

        /// <summary>
        /// Pesquisa todos as menssalidades com este id.
        /// </summary>
        /// <param name="idCli">id do cliente em especifico</param>
        /// <returns>lista com todos os clientes da busca</returns>
        public List<MO_Menssalidade> pesquisaTodasCli(int idCli)
        {
            if (idCli != null)
                return mDAL.procurar(string.Format("{0}={1}", MO_NomesBanco.fkCliMen, idCli), null);
            else throw new Exception("ERROR, tente novamente mais tarde.");
        }

        /// <summary>
        /// Ultima linha inserida no banco de dados..
        /// </summary>
        /// <returns>objeto com informações de mensalidade</returns>
        public MO_Menssalidade ultimaLinhaInserida(int idcli)
        {
            return mDAL.selecionarUltimaLinhaInserida(idcli);
        }

        /// <summary>
        /// Seleciona todas
        /// </summary>
        /// <returns>lista com objeto</returns>
        public List<MO_Menssalidade> selecionarTodas()
        {
            return mDAL.procurar(null, null);
        }

        /// <summary>
        /// filtra mais de uma vez os valores..
        /// </summary>
        /// <param name="mens">dados da menssalidade</param>
        /// <returns>true se tudo ok</returns>
        private bool verificaFiltros(MO_Menssalidade mens)
        {
            if (mens.idCli != null)
                if (mens.idUsu != null)
                    if (mens.dataVenc != null)
                        if (mens.dataPago != null)
                            return true;
                        else throw new Exception("ERROR, tente novamente mais tarde.");
                    else throw new Exception("ERROR, tente novamente mais tarde.");
                else throw new Exception("ERROR, tente novamente mais tarde.");
            else throw new Exception("ERROR, tente novamente mais tarde.");
        }
    }
}
