using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using Models;

namespace BLL
{
    public class BLL_Avaliacoes
    {
        DAL_Avaliacoes avaDAL;

        /// <summary>
        /// Inserir avaliação, com todos seus valores
        /// </summary>
        /// <param name="ava">objeto contendo valores de avaliação</param>
        public void inserir(MO_Avaliacao ava)
        {
            if (filtros(ava))
            {
                avaDAL = new DAL_Avaliacoes();
                avaDAL.inserirAvaliacao(ava);
            }
        }

        /// <summary>
        /// Editar uma avaliação em especifico
        /// </summary>
        /// <param name="ava">objeto de avaliação</param>
        public void editar(MO_Avaliacao ava)
        {
            if (filtros(ava))
            {
                avaDAL = new DAL_Avaliacoes();
                avaDAL.editarAvaliacao(ava);
            }
        }

        /// <summary>
        /// Deletar avaliação, pode ser assim, pois ela não é dependente de nenhuma outra tabela..
        /// </summary>
        /// <param name="ava">dados da avaliação</param>
        public void deletar(MO_Avaliacao ava)
        {
            if (ava != null)
            {
                avaDAL = new DAL_Avaliacoes();
                avaDAL.deletarAvaliacao(ava);
            }
            else throw new Exception("ERROR, tente novamente mais tarde.");
        }

        /// <summary>
        /// Faz a busca de todas avaliações existentes
        /// </summary>
        /// <returns>lista com todoas avaliações</returns>
        public List<MO_Avaliacao> buscarTodas()
        {
            avaDAL = new DAL_Avaliacoes();
            return avaDAL.procurarAvaliacoes(null);
        }

        public List<MO_Avaliacao> buscaDia(string dia)
        {
            avaDAL = new DAL_Avaliacoes();
            return avaDAL.procurarAvaliacoes(string.Format("{0}='{1}'", MO_NomesBanco.dtAva, dia));
        }

        /// <summary>
        /// Filtram os dados, sou preguiçoso e não vou fazer essa merda mais de uma vez
        /// </summary>
        /// <param name="ava">objeto contendo as informações de avaliação</param>
        /// <returns>true se beleza</returns>
        private bool filtros(MO_Avaliacao ava)
        {
            if (ava != null)
            {
                if (ava.idCli != null)
                    if (ava.idUsu != null)
                        if (ava.data != string.Empty)
                            if (ava.hora != string.Empty)
                                return true;
                            else throw new Exception("Preencha a hora.");
                        else throw new Exception("Preencha a data.");
                    else throw new Exception("ERROR, tente novamente mais tarde.");
                else throw new Exception("ERROR, tente novamente mais tarde.");
            }
            else throw new Exception("ERROR, tente novamente mais tarde.");
        }
    }
}
