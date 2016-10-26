using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Models;

namespace DAL
{
    public class DAL_Turma : IRepository
    {
        DAL_MontaComando monta;
        MO_DB db;
        string sql = "";

        /// <summary>
        /// Inseri uma turma, Status ja ativo..
        /// </summary>
        /// <param name="tur">dados essencias para a turma</param>
        public void inserirTurma(MO_Turma tur)
        {
            if (tur != null)
            {
                monta = new DAL_MontaComando();
                db = new MO_DB();
                sql = "";

                db.tabela = MO_NomesBanco.tabelaTr;
                db.campos = string.Format("{0},{1},{2},{3},{4},{5},{6}", MO_NomesBanco.idTr, MO_NomesBanco.fkUsuTr, MO_NomesBanco.nomTr, MO_NomesBanco.locTr,
                    MO_NomesBanco.sexTr, MO_NomesBanco.maxTr, MO_NomesBanco.statTr);
                db.valores = string.Format("null,{0},'{1}','{2}','{3}',{4},{5}", tur.idUsu, tur.nome, tur.local, tur.sex, tur.maxAlunos, (int)Status.ativo);

                sql = monta.montaInserir(db);
                executar(sql);
            }
            else throw new Exception("ERROR, tente novamente mais tarde!");
        }

        /// <summary>
        /// Editar a turma, com os seus dados, também serve para deletar, pois á pra manter a consistencia
        /// </summary>
        /// <param name="tur">dados essencias da turma</param>
        public void editarTurma(MO_Turma tur)
        {
            if (tur != null)
            {
                monta = new DAL_MontaComando();
                db = new MO_DB();
                sql = "";

                db.tabela = MO_NomesBanco.tabelaTr;
                db.campos = string.Format("{0}={6},{1}='{7}',{2}='{8}',{3}='{9}',{4}={10},{5}={11}", MO_NomesBanco.fkUsuTr, MO_NomesBanco.nomTr, MO_NomesBanco.locTr, 
                    MO_NomesBanco.sexTr, MO_NomesBanco.maxTr, MO_NomesBanco.statTr, tur.idUsu, tur.nome, tur.local, tur.sex, tur.maxAlunos, (int)tur.status);
                db.adicionais = string.Format("{0}={1}", MO_NomesBanco.idTr, tur.id);

                sql = monta.montaEditar(db);
                executar(sql);
            }
            else throw new Exception("ERROR, tente novamente mais tarde!");
        }

        /// <summary>
        /// efetua a pesquisa de turma de acordo com os parametros enviados pela BLL
        /// exemplo para selecionar todas: pesquisaTurma(null, null, null);
        /// </summary>
        /// <param name="where">clausula where para ser feita</param>
        /// <param name="orderBy">ordena a tabela</param>
        /// <param name="like">like utilizavel para nome e essas coisas.. não utilizar com where</param>
        /// <returns>lista com todas as turmas</returns>
        public List<MO_Turma> pesquisaTurma(string where, string orderBy, string like)
        {
            db = new MO_DB();
            monta = new DAL_MontaComando();
            sql = "";

            db.tabela = MO_NomesBanco.tabelaTr;
            db.campos = "*";
            if (where != null)
                db.adicionais = " WHERE " + where;
            if (orderBy != null)
                db.adicionais += " ORDER BY " + orderBy;
            if (like != null)
                db.adicionais += string.Format(" LIKE '%{0}%'", like);

            sql = monta.montaSelecionar(db);
            return montaListaTurma(executaRetorno(sql));
        }

        /// <summary>
        /// aloca um aluno em uma turma, assim pois a relação é de N para M
        /// </summary>
        /// <param name="idCli">id do cliente a ser alocado</param>
        /// <param name="idTurma">id da turma para alocar cliente</param>
        public void alocaAlunoTurma(int idCli, int idTurma)
        {
            if (idCli != null && idTurma != null)
            {
                monta = new DAL_MontaComando();
                db = new MO_DB();
                sql = "";

                db.tabela = MO_NomesBanco.tabelaAlTr;
                db.campos = string.Format("{0},{1},{2}", MO_NomesBanco.idAlTr, MO_NomesBanco.fkCliAlTr, MO_NomesBanco.fkTrAlTr);
                db.valores = string.Format("null,{0},{1}", idCli, idTurma);

                sql = monta.montaInserir(db);
                executar(sql);
            }
            else throw new Exception("ERROR, tente novamente mais tarde!");
        }

        /// <summary>
        /// tira o relacionamento de um cliente com uma certa turma.
        /// </summary>
        /// <param name="idCli">id do cliente que pertence a turma</param>
        /// <param name="idTurma">turma que pertence o cliente</param>
        public void deletaAlunoTurma(int idCli, int idTurma)
        {
            if (idCli != null && idTurma != null)
            {
                monta = new DAL_MontaComando();
                db = new MO_DB();
                sql = "";

                db.tabela = MO_NomesBanco.tabelaAlTr;
                db.adicionais = string.Format("{0}={2} AND {1}={3}", MO_NomesBanco.fkCliAlTr, MO_NomesBanco.fkTrAlTr, idCli, idTurma);

                sql = monta.montaExcluir(db);
                executar(sql);
            }
            else throw new Exception("ERROR, tente novamente mais tarde!");
        }

        /// <summary>
        /// Selecionar todos alunos de uma turma em especifico
        /// </summary>
        /// <param name="tur">model de turma para pegar o id da turma</param>
        /// <returns>uma lista com todos alunos desta turma</returns>
        public List<MO_AlunoTurma> selecionarAlunoTurma(MO_Turma tur)
        {
            if (tur != null)
            {
                monta = new DAL_MontaComando();
                db = new MO_DB();
                sql = "";

                db.tabela = MO_NomesBanco.tabelaAlTr;
                db.campos = "*";
                db.adicionais = string.Format(" WHERE {0}={1}", MO_NomesBanco.fkTrAlTr, tur.id);

                sql = monta.montaSelecionar(db);
                return montaListaAlunoTurma(executaRetorno(sql));
            }
            else throw new Exception("ERROR, tente novamente mais tarde!");
        }

        /// <summary>
        /// Monta uma lista de turma para ser retornada.. e faz o que quiseres com ela, seu corno kkkk
        /// </summary>
        /// <param name="dt">Data Table(retorno do banco)</param>
        /// <returns>uma lista com todas as turmas selecionadas</returns>
        private List<MO_Turma> montaListaTurma(DataTable dt)
        {
            List<MO_Turma> listT = new List<MO_Turma>();
            MO_Turma tur;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                tur = new MO_Turma();

                tur.id = int.Parse(dt.Rows[i][MO_NomesBanco.idTr].ToString());
                tur.idUsu = int.Parse(dt.Rows[i][MO_NomesBanco.fkUsuTr].ToString());
                tur.nome = dt.Rows[i][MO_NomesBanco.nomTr].ToString();
                tur.local = dt.Rows[i][MO_NomesBanco.locTr].ToString();
                tur.sex = dt.Rows[i][MO_NomesBanco.sexTr].ToString();
                tur.maxAlunos = int.Parse(dt.Rows[i][MO_NomesBanco.maxTr].ToString());
                tur.status = (Status)int.Parse(dt.Rows[i][MO_NomesBanco.statTr].ToString());

                listT.Add(tur);
            }
            return listT;
        }

        /// <summary>
        /// Monta uma lista que contenha tanto os valores de turma e de cliente para serem procurados
        /// </summary>
        /// <param name="dt">retorno do banco</param>
        /// <returns>lista com todos alunos em alguma turma</returns>
        private List<MO_AlunoTurma> montaListaAlunoTurma(DataTable dt)
        {
            List<MO_AlunoTurma> listAlTur = new List<MO_AlunoTurma>();
            MO_AlunoTurma alTr;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                alTr = new MO_AlunoTurma();
                alTr.id = int.Parse(dt.Rows[i][MO_NomesBanco.idAlTr].ToString());
                alTr.idCli = int.Parse(dt.Rows[i][MO_NomesBanco.fkCliAlTr].ToString());
                alTr.idTurma = int.Parse(dt.Rows[i][MO_NomesBanco.fkTrAlTr].ToString());

                listAlTur.Add(alTr);
            }
            return listAlTur;
        }
    }
}
