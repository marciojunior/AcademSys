using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using Models;

namespace BLL
{
    public class BLL_Contas
    {
        DAL_Contas con = new DAL_Contas();

        /// <summary>
        /// Inserir uma conta a ser paga..
        /// </summary>
        /// <param name="cp">dados da conta a ser paga</param>
        public void inserirCP(MO_ContasPagar cp)
        {
            if (filtrosCP(cp))
                con.inserirContaPagar(cp);
        }

        /// <summary>
        /// atualizar contas a pagar
        /// </summary>
        /// <param name="cp">dados de conta a pagar</param>
        public void atualizarCP(MO_ContasPagar cp)
        {
            if (cp.id != null)
            {
                if (filtrosCP(cp))
                    con.editarContaPagar(cp);
            }
            else throw new Exception("ERROR, tente novamente mais tarde.");
        }

        /// <summary>
        /// Pesquisa todas as CP, pagas e não pagas
        /// </summary>
        /// <returns>lista com todas as contas</returns>
        public List<MO_ContasPagar> pesquisaTodasCP()
        {
            return con.procurarContasP(null, null);
        }

        /// <summary>
        /// Filtra todos os campos, para ser usado mais de uma vez
        /// </summary>
        /// <param name="cp">dados da conta a pagar</param>
        /// <returns>true se tudo OK</returns>
        private bool filtrosCP(MO_ContasPagar cp)
        {
            if (cp != null)
                if (cp.idUsu != null)
                    if (cp.valor != 0)
                        if (cp.motivo != "" && cp.motivo.Trim().Length < 1000)
                            return true;
                        else throw new Exception("Preencha o motivo, deve conter de 0 a 1000 caracteres.");
                    else throw new Exception("Preencha o valor.");
                else throw new Exception("ERROR, tente de novo mais tarde.");
            else throw new Exception("ERROR, tente de novo mais tarde.");
        }

        /// <summary>
        /// inserir uma conta a receber
        /// </summary>
        /// <param name="cr">dados essencias da conta que vai ser recebida</param>
        public void inserirCR(MO_ContasReceber cr)
        {
            if (filtrosCR(cr))
                con.inserirContasReceber(cr);
        }

        /// <summary>
        /// editar uma conta a receber
        /// </summary>
        /// <param name="cr">dados da conta que será recebida</param>
        public void editarCR(MO_ContasReceber cr)
        {
            if (filtrosCR(cr))
                con.editarContasReceber(cr);
        }

        /// <summary>
        /// procura todas as contas a receber..
        /// </summary>
        /// <returns>lista com todas as contas a receber</returns>
        public List<MO_ContasReceber> pesquisaTodasCR()
        {
            return con.procurarContasReceber(null, null);
        }

        /// <summary>
        /// filtra todos os dados essencias de contas a receber.
        /// </summary>
        /// <param name="cr">dados de contas a receber</param>
        /// <returns>se tudo ok TRUE</returns>
        private bool filtrosCR(MO_ContasReceber cr)
        {
            if (cr.idUsu != null)
                if (cr.valor != 0)
                    if (cr.motivo != "" && cr.motivo.Length < 1000)
                        return true;
                    else throw new Exception("Motivo deve conter entre 1 e 1000 caracteres.");
                else throw new Exception("Valor não pode ser nulo.");
            else throw new Exception("ERROR, tente novamente mais tarde.");
        }
    }
}