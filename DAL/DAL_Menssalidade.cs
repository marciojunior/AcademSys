using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Models;

namespace DAL
{
    public class DAL_Menssalidade : IRepository
    {
        DAL_MontaComando monta;
        MO_DB db;
        string sql = "";

        /// <summary>
        /// inserindo uma menssalidade em determinado cliente
        /// </summary>
        /// <param name="mens">dados de menssalidade</param>
        public void inserirMenssalidade(MO_Menssalidade mens)
        {
            if (mens != null)
            {
                monta = new DAL_MontaComando();
                db = new MO_DB();
                sql = "";

                db.tabela = MO_NomesBanco.tabelaMen;
                db.campos = string.Format("{0},{1},{2},{3},{4},{5}", MO_NomesBanco.idMen, MO_NomesBanco.fkUsuMen, MO_NomesBanco.fkCliMen,
                    MO_NomesBanco.dtVencMen, MO_NomesBanco.dtPagMen, MO_NomesBanco.valMen);
                db.valores = string.Format("null,{0},{1},'{2}','{3}',{4}", mens.idUsu, mens.idCli, mens.dataVenc.ToString("dd/MM/yyyy"), mens.dataPago.ToString("dd/MM/yyyy"),
                    mens.valor.ToString().Replace(",","."));

                sql = monta.montaInserir(db);
                executar(sql);
            }
            else throw new Exception("ERROR, tente novamente mais tarde.");
        }

        /// <summary>
        /// atualiza a mensalidade do cliente com a data que fora pago..
        /// </summary>
        /// <param name="mens">dados de menssalidade</param>
        public void atualizarMenssalidade(MO_Menssalidade mens)
        {
            if (mens != null)
            {
                monta = new DAL_MontaComando();
                db = new MO_DB();
                sql = "";

                db.tabela = MO_NomesBanco.tabelaMen;
                db.campos = string.Format("{0}={5},{1}={6},{2}='{7}',{3}='{8}',{4}={9}", MO_NomesBanco.fkUsuMen, MO_NomesBanco.fkCliMen, MO_NomesBanco.dtVencMen, MO_NomesBanco.dtPagMen,
                    MO_NomesBanco.valMen, mens.idUsu, mens.idCli, mens.dataVenc.ToString("dd/MM/yyyy"), mens.dataPago.ToString("dd/MM/yyyy"), mens.valor.ToString().Replace(",", "."));
                db.adicionais = string.Format("{0}={1}", MO_NomesBanco.idMen, mens.id);

                sql = monta.montaEditar(db);
                executar(sql);
            }
            else throw new Exception("ERROR, tente novamente mais tarde.");
        }

        /// <summary>
        /// procurar todo tipo de menssalidade, exemplo de uso:
        /// procurar(null, null);
        /// </summary>
        /// <param name="where">condição</param>
        /// <param name="orderBy">ordenação</param>
        /// <returns>lista com o resultados do banco</returns>
        public List<MO_Menssalidade> procurar(string where, string orderBy)
        {
            monta = new DAL_MontaComando();
            db = new MO_DB();
            sql = "";

            db.tabela = MO_NomesBanco.tabelaMen;
            db.campos = "*";
            if (where != null)
                db.adicionais = " WHERE " + where;
            if (orderBy != null)
                db.adicionais += " ORDER BY " + orderBy;

            sql = monta.montaSelecionar(db);
            return montaListaMens(executaRetorno(sql));
        }

        /// <summary>
        /// seleciona a ultima linha para obter o id..
        /// </summary>
        /// <returns>Modelo de Mensalidade com as suas informações inseridas</returns>
        public MO_Menssalidade selecionarUltimaLinhaInserida(int idCli)
        {
            db = new MO_DB();
            monta = new DAL_MontaComando();
            sql = "";

            db.tabela = MO_NomesBanco.tabelaMen;
            db.campos = "*";
            db.adicionais = string.Format(" WHERE {0}={1} ORDER BY id DESC LIMIT 1", MO_NomesBanco.fkCliMen, idCli);

            sql = monta.montaSelecionar(db);
            return montaListaMens(executaRetorno(sql))[0];
        }

        /// <summary>
        /// preenche  uma lista com todas as menssalidades existentes
        /// </summary>
        /// <param name="dt">data table com resultados do banco da menssalidade</param>
        /// <returns>lista com todas as mensalidade</returns>
        private List<MO_Menssalidade> montaListaMens(DataTable dt)
        {
            List<MO_Menssalidade> listM = new List<MO_Menssalidade>();
            MO_Menssalidade men;

            for (int i = dt.Rows.Count-1; i >= 0; i--)
            {
                men = new MO_Menssalidade();

                men.id = int.Parse(dt.Rows[i][MO_NomesBanco.idMen].ToString());
                men.idUsu = int.Parse(dt.Rows[i][MO_NomesBanco.fkUsuMen].ToString());
                men.idCli = int.Parse(dt.Rows[i][MO_NomesBanco.fkCliMen].ToString());
                men.dataVenc = Convert.ToDateTime(dt.Rows[i][MO_NomesBanco.dtVencMen].ToString());
                men.dataPago = Convert.ToDateTime(dt.Rows[i][MO_NomesBanco.dtPagMen].ToString());
                men.valor = double.Parse(dt.Rows[i][MO_NomesBanco.valMen].ToString().Replace(".", ","));

                listM.Add(men);
            }
            return listM;
        }
    }
}
