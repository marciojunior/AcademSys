using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Models;
using DAL;

namespace BLL
{
    public class BLL_Turma
    {
        DAL_Turma turmaDAL;

        /// <summary>
        /// Inserir alguma turma, com seus dados
        /// </summary>
        /// <param name="tur">dados de turma, para inseri-la</param>
        public void inserir(MO_Turma tur)
        {
            if (filtraCampos(tur))
            {
                turmaDAL = new DAL_Turma();
                turmaDAL.inserirTurma(tur);
            }
        }

        /// <summary>
        /// procura turmas que estão ativas
        /// </summary>
        /// <returns></returns>
        public List<MO_Turma> procurarTurmasAtivas()
        {
            DAL_Turma tur = new DAL_Turma();
            return tur.pesquisaTurma(string.Format("{0}={1}", MO_NomesBanco.statTr, (int)Status.ativo), null, null);
        }

        /// <summary>
        /// Atualiza alguma turma em questão
        /// </summary>
        /// <param name="tur">dados de turma</param>
        public void atualizar(MO_Turma tur)
        {
            if (filtraCampos(tur))
            {
                turmaDAL = new DAL_Turma();
                turmaDAL.editarTurma(tur);
            }
        }

        /// <summary>
        /// deleta certo aluno de certa turma
        /// </summary>
        /// <param name="altr">DADOS DO ALUNO E DA TURMA</param>
        public void deletarAlunoTurma(MO_AlunoTurma altr)
        {
            if (altr.idCli != null)
                if (altr.idTurma != null)
                {
                    turmaDAL = new DAL_Turma();
                    turmaDAL.deletaAlunoTurma(altr.idCli, altr.idTurma);
                }
                else throw new Exception("ERROR, tente novamente mais tarde.");
            else throw new Exception("ERROR, tente novamente mais tarde.");
        }

        /// <summary>
        /// procura todos os alunos de uma turma em especifico
        /// </summary>
        /// <param name="tur">turma contendo o id da turma</param>
        /// <returns>lista com todos id's de cliente</returns>
        public List<MO_AlunoTurma> procuraAlunosTurma(MO_Turma tur)
        {
            if (tur != null)
            {
                turmaDAL = new DAL_Turma();
                return turmaDAL.selecionarAlunoTurma(tur);
            }
            else throw new Exception("ERROR, tente novamente mais tarde!");
        }

        /// <summary>
        /// Aloca alguma aluno em alguma turma
        /// </summary>
        /// <param name="alTr">informações da turma e do aluno</param>
        public void alocaAlunoTurma(MO_AlunoTurma alTr)
        {
            if (alTr.idCli != null)
                if (alTr.idTurma != null)
                {
                    turmaDAL = new DAL_Turma();
                    turmaDAL.alocaAlunoTurma(alTr.idCli, alTr.idTurma);
                }
        }

        /// <summary>
        /// Verifica os dados, para serem passados por um filtro
        /// </summary>
        /// <param name="tur">informações da turma para serem precessadas</param>
        /// <returns>true se ok</returns>
        private bool filtraCampos(MO_Turma tur)
        {
            if (tur != null)
                if (tur.idUsu != null)
                    if (tur.nome != null)
                        if (tur.local != null)
                            if (tur.sex != null)
                                if (tur.maxAlunos != null)
                                    return true;
                                else throw new Exception("Máximo de Alunos tem que estar preenchido.");
                            else throw new Exception("Escolha o Sexo.");
                        else throw new Exception("Preencha o local");
                    else throw new Exception("Preencha o nome.");
                else throw new Exception("ERROR, tente novamente mais tarde!");
            else throw new Exception("ERROR, tente novamente mais tarde!");

        }
    }
}
