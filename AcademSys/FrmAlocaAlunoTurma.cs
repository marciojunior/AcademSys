using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL;
using Models;

namespace AcademSys
{
    public partial class FrmAlocaAlunoTurma : Form
    {
        List<MO_AlunoTurma> listAlTrU = new List<MO_AlunoTurma>();
        string sexoU;
        int turmaU;
        BLL_Cliente cliBLL;
        BLL_Turma turBLL;

        public FrmAlocaAlunoTurma(List<MO_AlunoTurma> listAlTr, string sexo, int turma)
        {
            InitializeComponent();
            listAlTrU = listAlTr;
            sexoU = sexo;
            turmaU = turma;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmAlocaAlunoTurma_Load(object sender, EventArgs e)
        {
            try 
            {
                refreshGrid();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void refreshGrid()
        {
            string[] linha = new string[3];
            List<MO_Cliente> listCli = new List<MO_Cliente>();
            cliBLL = new BLL_Cliente();

            listCli = sexoU != "MF" ? cliBLL.buscaClienteParaTurma(sexoU) : cliBLL.buscaClienteParaTurma(null);
            this.DgAluno.Rows.Clear();

            foreach (MO_Cliente cli in listCli)
            {
                if (!clienteAlocado((int)cli.idCli))
                {
                    linha[0] = cli.idCli.ToString();
                    linha[1] = cli.matricula.ToString();
                    linha[2] = cli.nome;

                    this.DgAluno.Rows.Add(linha);
                }
            }
        }

        private bool clienteAlocado(int id)
        {
            bool ret = false;
            foreach (MO_AlunoTurma alT in listAlTrU)
            {
                if (alT.idCli == id)
                {
                    ret = true;
                    break;
                }
            }
            return ret;
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            try
            {
                MO_AlunoTurma alTr = new MO_AlunoTurma();
                turBLL = new BLL_Turma();

                alTr.idCli = int.Parse(this.DgAluno.CurrentRow.Cells[0].Value.ToString());
                alTr.idTurma = turmaU;

                turBLL.alocaAlunoTurma(alTr);
                MessageBox.Show("Aluno alocado na turma com sucesso!", "Atenção!");
                this.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
