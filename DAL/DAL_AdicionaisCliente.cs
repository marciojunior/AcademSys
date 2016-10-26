using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Models;
using System.Data;

namespace DAL
{
    public class DAL_AdicionaisCliente : IRepository
    {
        MO_DB db;
        DAL_MontaComando monta;
        string sql = "";

        /// <summary>
        /// Inserindo adicionais de determinado cliente
        /// </summary>
        /// <param name="ad">adicionais do cliente</param>
        public void inserirAdicionais(MO_AdicionaisCliente ad)
        {
            if (ad != null)
            {
                sql = "";
                db = new MO_DB();
                monta = new DAL_MontaComando();

                db.tabela = MO_NomesBanco.tabelaAd;
                db.campos = string.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14}",
                    MO_NomesBanco.idAd, MO_NomesBanco.fkCliAd, MO_NomesBanco.objAd, MO_NomesBanco.profAd, MO_NomesBanco.estCivilAd, MO_NomesBanco.empAd,
                    MO_NomesBanco.telEmpAd, MO_NomesBanco.nPaiAd, MO_NomesBanco.nMaeAd, MO_NomesBanco.RespAd, MO_NomesBanco.telRespAd, MO_NomesBanco.enderAd,
                    MO_NomesBanco.bairroAd, MO_NomesBanco.cepAd, MO_NomesBanco.cidadAd);

                db.valores = string.Format("null,{0},'{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}'",
                    ad.idCli, ad.objetivo, ad.profissao, ad.estadoCivil, ad.empresa, ad.telEmpresa, ad.nomePai, ad.nomeMae, ad.responsavel, ad.telResponsavel,
                    ad.endereco, ad.bairro, ad.cep, ad.cidade);

                sql = monta.montaInserir(db);
                executar(sql);
            }
            else throw new Exception("Error, tente novamente mais tarde!");
        }

        /// <summary>
        /// Atualiza determinado cliente...
        /// </summary>
        /// <param name="ad">adicionais do cliente</param>
        public void atualizaAdicionail(MO_AdicionaisCliente ad)
        {
            if (ad != null)
            {
                sql = "";
                db = new MO_DB();
                monta = new DAL_MontaComando();

                db.tabela = MO_NomesBanco.tabelaAd;
                db.campos = string.Format(@"{0}={14},{1}='{15}',{2}='{16}',{3}='{17}',{4}='{18}',{5}='{19}',{6}='{20}',{7}='{21}',{8}='{22}',
                                            {9}='{23}',{10}='{24}',{11}='{25}',{12}='{26}',{13}='{26}'",
                    MO_NomesBanco.fkCliAd, MO_NomesBanco.objAd, MO_NomesBanco.profAd, MO_NomesBanco.estCivilAd, MO_NomesBanco.empAd,
                    MO_NomesBanco.telEmpAd, MO_NomesBanco.nPaiAd, MO_NomesBanco.nMaeAd, MO_NomesBanco.RespAd, MO_NomesBanco.telRespAd, MO_NomesBanco.enderAd,
                    MO_NomesBanco.bairroAd, MO_NomesBanco.cepAd, MO_NomesBanco.cidadAd,
                    ad.idCli, ad.objetivo, ad.profissao, ad.estadoCivil, ad.empresa, ad.telEmpresa, ad.nomePai, ad.nomeMae, ad.responsavel, ad.telResponsavel,
                    ad.endereco, ad.bairro, ad.cep, ad.cidade);

                db.adicionais = string.Format("{0}={1}", MO_NomesBanco.idAd, ad.idAdicional);

                sql = monta.montaEditar(db);
                executar(sql);
            }
            else throw new Exception("Error, tente novamente mais tarde!");
        }

        /// <summary>
        /// seleciona os dados adicionais daquele determinado cliente
        /// </summary>
        /// <param name="ad">dados adicionais de cliente</param>
        /// <returns>lista com cliente</returns>
        public MO_AdicionaisCliente selecionar(MO_AdicionaisCliente ad)
        {
            if (ad != null)
            {
                sql = "";
                db = new MO_DB();
                monta = new DAL_MontaComando();

                db.tabela = MO_NomesBanco.tabelaAd;
                db.campos = "*";
                db.adicionais = string.Format(" WHERE {0}={1}", MO_NomesBanco.fkCliAd, ad.idCli);

                sql = monta.montaSelecionar(db);
                return montaLista(executaRetorno(sql))[0];
            }
            else throw new Exception("Error, tente novamente mais tarde!");
        }

        /// <summary>
        /// monta a lista com todas as informações dos adicionais..
        /// </summary>
        /// <param name="dt">retorno no banco em DataTabel</param>
        /// <returns>lista de adicionais</returns>
        private List<MO_AdicionaisCliente> montaLista(DataTable dt)
        {
            MO_AdicionaisCliente ad;
            List<MO_AdicionaisCliente> listAd = new List<MO_AdicionaisCliente>();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ad = new MO_AdicionaisCliente();

                ad.idAdicional = int.Parse(dt.Rows[i][MO_NomesBanco.idAd].ToString());
                ad.idCli = int.Parse(dt.Rows[i][MO_NomesBanco.fkCliAd].ToString());
                ad.objetivo = dt.Rows[i][MO_NomesBanco.objAd].ToString();
                ad.profissao = dt.Rows[i][MO_NomesBanco.profAd].ToString();
                ad.estadoCivil = dt.Rows[i][MO_NomesBanco.estCivilAd].ToString();
                ad.empresa = dt.Rows[i][MO_NomesBanco.empAd].ToString();
                ad.telEmpresa = dt.Rows[i][MO_NomesBanco.telEmpAd].ToString();
                ad.nomePai = dt.Rows[i][MO_NomesBanco.nPaiAd].ToString();
                ad.nomeMae = dt.Rows[i][MO_NomesBanco.nMaeAd].ToString();
                ad.responsavel = dt.Rows[i][MO_NomesBanco.RespAd].ToString();
                ad.telResponsavel = dt.Rows[i][MO_NomesBanco.telRespAd].ToString();
                ad.endereco = dt.Rows[i][MO_NomesBanco.enderAd].ToString();
                ad.bairro = dt.Rows[i][MO_NomesBanco.bairroAd].ToString();
                ad.cep = dt.Rows[i][MO_NomesBanco.cepAd].ToString();
                ad.cidade = dt.Rows[i][MO_NomesBanco.cidadAd].ToString();

                listAd.Add(ad);
            }

            return listAd;
        }
    }
}