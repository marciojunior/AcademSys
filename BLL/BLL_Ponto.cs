using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using Models;

namespace BLL
{
    public class BLL_Ponto
    {
        DAL_Ponto pDAL = new DAL_Ponto();

        /// <summary>
        /// inseir essa bosta aqui
        /// </summary>
        /// <param name="p">parametro com o cu da sua mae</param>
        public void inserirPonto(MO_Ponto p)
        {
            if (p != null)
                pDAL.inserirPonto(p);
            else throw new Exception("ERROR, tente novamente mais tarde.");
        }

        /// <summary>
        /// fecha a bosta do ponto
        /// </summary>
        /// <param name="p">k</param>
        public void fecharPonto(MO_Ponto p)
        {
            if (p != null)
                pDAL.fecharPonto(p);
            else throw new Exception("ERROR, tente novamente mais tarde.");
        }

        /// <summary>
        /// la
        /// </summary>
        /// <returns>cu</returns>
        public List<MO_Ponto> buscaTodosU(int id)
        {
            return pDAL.pesquisaPonto(string.Format("{0}={1}", MO_NomesBanco.fkUsuPt, id), null);
        }
    }
}
