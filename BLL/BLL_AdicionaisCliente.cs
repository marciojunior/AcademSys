using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Models;
using DAL;

namespace BLL
{
    public class BLL_AdicionaisCliente
    {
        DAL_AdicionaisCliente adDAL;

        /// <summary>
        /// Inserir adicionais do cliente, para complementar o cadastro do cliente
        /// </summary>
        /// <param name="ad">informações adicionais do cliente</param>
        public void inserir(MO_AdicionaisCliente ad)
        {
            if (ad != null)
            {
                if (filtros(ad))
                {
                    adDAL = new DAL_AdicionaisCliente();
                    adDAL.inserirAdicionais(ad);
                }
            }
            else throw new Exception("Error, tente novamente mais tarde!");
        }

        /// <summary>
        /// atualiza os adicionais do cliente
        /// </summary>
        /// <param name="ad">informações dos adicionais para ser atualizado</param>
        public void atualizar(MO_AdicionaisCliente ad)
        {
            if (ad != null)
            {
                if (filtros(ad))
                {
                    adDAL = new DAL_AdicionaisCliente();
                    adDAL.atualizaAdicionail(ad);
                }
            }
            else throw new Exception("Error, tente novamente mais tarde!");
        }

        /// <summary>
        /// Busca as informações de um modo especifico, então so existe um modo de buscar, um de cada vez
        /// pois a tabela é de relação com cliente de 1 pra 1
        /// </summary>
        /// <param name="ad">informações de ad, em especifico(idCli)</param>
        /// <returns>Informações correspondentes aquele cliente em especifico</returns>
        public MO_AdicionaisCliente buscar(MO_AdicionaisCliente ad)
        {
            if (ad != null)
            {
                if (ad.idCli != null)
                {
                    adDAL = new DAL_AdicionaisCliente();
                    return adDAL.selecionar(ad);
                }
                else throw new Exception("Error, tente novamente mais tarde!");
            }
            else throw new Exception("Error, tente novamente mais tarde!");
        }

        /// <summary>
        /// Filtros essenciais de cliente
        /// </summary>
        /// <param name="ad">adicionais dos clientes a serem carregados</param>
        /// <returns>filtros contendo clientes</returns>
        private bool filtros(MO_AdicionaisCliente ad)
        {
            if (ad.nomeMae.Length > 0)
                if (ad.nomePai.Length > 0)
                    if (ad.idCli != null)
                        return true;
                    else throw new Exception("Error, tente novamante mais tarde!");
                else throw new Exception("Preencha o nome do pai!");
            else throw new Exception("Preencha o nome da mãe!");
        }
    }
}
