using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Models;
using DAL;

namespace BLL
{
    public class BLL_Plano
    {
        DAL_Plano plDAL;

        /// <summary>
        /// inserindo um certo plano//
        /// </summary>
        /// <param name="p">objeto com informações do plano</param>
        public void inserir(MO_Plano p)
        {
            if (verificaFiltros(p))
            {
                plDAL = new DAL_Plano();
                plDAL.inserirPlano(p);
            }
        }

        /// <summary>
        /// Editando um plano
        /// </summary>
        /// <param name="p">objeto com informações de plano</param>
        public void editar(MO_Plano p)
        {
            if (verificaFiltros(p))
            {
                plDAL = new DAL_Plano();
                plDAL.editarPlano(p);
            }
        }

        /// <summary>
        /// Procura todos os planos que estão ativos =D
        /// </summary>
        /// <returns>lista com o objeto de planos</returns>
        public List<MO_Plano> procurarTodasAtivas()
        {
            plDAL = new DAL_Plano();
            return plDAL.procurarPlano(string.Format("{0}={1}", MO_NomesBanco.statPlan, (int)Status.ativo), string.Empty);
        }

        /// <summary>
        /// Faz as verificações de filtros, está aqui porque faz mais de uma vez.
        /// </summary>
        /// <param name="p">objeto contendo informações do plano em questao</param>
        /// <returns>true se ok</returns>
        private bool verificaFiltros(MO_Plano p)
        {
            if (p != null)
                if (p.nome != string.Empty)
                    if (p.qtdAula != 0)
                        return true;
                    else throw new Exception("ERROR, quantidade de aulas tem que ser maior.");
                else throw new Exception("ERROR, insira um nome.");
            else throw new Exception("ERROR, tente novamente mais tarde.");
        }
    }
}
