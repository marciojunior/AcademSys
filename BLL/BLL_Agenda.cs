using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Models;
using DAL;

namespace BLL
{
    public class BLL_Agenda
    {
        /// <summary>
        /// Inserindo os dados de forma correta e tratando os erros todos.
        /// </summary>
        /// <param name="ag">todas as informações necessarias de agenda..</param>
        public void inserirDados(MO_Agenda ag)
        {
            DAL_Agenda agendaDAL = new DAL_Agenda();
            if (ag != null)
            {
                if (ag.idUsu != null)
                    if (ag.data != null)
                        if (ag.titulo.Length > 0 && ag.titulo.Length < 100)
                            if (ag.descricao.Length > 0 && ag.descricao.Length < 1000)
                                agendaDAL.inserir(ag);
                            else throw new Exception("Descrição deve conter de 1 a 1000 caracteres");
                        else throw new Exception("Titulo deve conter de 1 a 100 caracteres");
                    else throw new Exception("preencha todos os campos");
                else throw new Exception("Erro, tente novamente mais tarde!");
                
            } else throw new Exception("Por favor preencha os campos!");
        }

        /// <summary>
        /// efetua todos os tipos de bisca necessarios, tratando os erros.
        /// </summary>
        /// <param name="ag">informações da agenda</param>
        /// <returns>retorna uma lista com todas agendas</returns>
        public List<MO_Agenda> procurar(MO_Agenda ag)
        {
            DAL_Agenda agendaDAL = new DAL_Agenda();
            List<MO_Agenda> resp = new List<MO_Agenda>();

            if (ag != null)
            {
                if (ag.idUsu != null)
                    resp = ag.data != DateTime.MinValue ? agendaDAL.pesquisaPorData(ag) : agendaDAL.pesquisaTodas(ag);
            }
            else throw new Exception("Erro, tente novamente mais tarde!");

            return resp;
        }

        /// <summary>
        /// editar determinada agenda
        /// </summary>
        /// <param name="ag">informações necessarias da agenda</param>
        public void editarDado(MO_Agenda ag)
        {
            DAL_Agenda agendaDAL = new DAL_Agenda();
            if (ag != null)
            {
                if (ag.idUsu != null)
                    if (ag.data != null)
                        if (ag.titulo.Length > 0 && ag.titulo.Length < 100)
                            if (ag.descricao.Length > 0 && ag.descricao.Length < 1000)
                                agendaDAL.editarAgenda(ag);
                            else throw new Exception("Descrição deve conter de 1 a 1000 caracteres");
                        else throw new Exception("Titulo deve conter de 1 a 100 caracteres");
                    else throw new Exception("preencha todos os campos");
                else throw new Exception("Erro, tente novamente mais tarde!");

            }
            else throw new Exception("Por favor preencha os campos!");
        }

    }
}
