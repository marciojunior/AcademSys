using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Models;
using DAL;

namespace BLL
{
    public class BLL_MensalidadePlano
    {
        DAL_MensalidadePlano mpDAL;

        /// <summary>
        /// Inserir Mensalidade - Plano
        /// </summary>
        /// <param name="mp">Obejto de mensalidade - plano</param>
        public void inserir(MO_MensalidadePlano mp)
        {
            if (mp != null)
            {
                mpDAL = new DAL_MensalidadePlano();
                mpDAL.inserirMP(mp);
            }
            else throw new Exception("ERROR, tente novamente mais tarde.");
        }

        /// <summary>
        /// Método para editar a relação de uma mensalidade/plano
        /// </summary>
        /// <param name="mp">Obejto de mensalidade - plano</param>
        public void editar(MO_MensalidadePlano mp)
        {
            if (mp != null)
            {
                mpDAL = new DAL_MensalidadePlano();
                mpDAL.editarMP(mp);
            }
            else throw new Exception("ERROR, tente novamente mais tarde.");
        }

        /// <summary>
        /// Excluindo uma relação
        /// </summary>
        /// <param name="mp">OBJETO</param>
        public void excluir(MO_MensalidadePlano mp)
        {
            if (mp != null)
            {
                mpDAL = new DAL_MensalidadePlano();
                mpDAL.excluir(mp);
            }
            else throw new Exception("ERROR, tente novamente mais tarde.");
        }

        /// <summary>
        /// Procura relação daquela mensalidade
        /// </summary>
        /// <param name="idM">id da mensalidade</param>
        /// <returns>lista com todas as relações.</returns>
        public List<MO_MensalidadePlano> procurarPorIdMens(int idM)
        {
            if (idM != null)
            {
                mpDAL = new DAL_MensalidadePlano();
                return mpDAL.pesquisarMP(string.Format("{0}={1}", MO_NomesBanco.fkMenMenPlan, idM), string.Empty);
            }
            else throw new Exception("ERROR, tente novamente mais tarde.");
        }
    }
}
