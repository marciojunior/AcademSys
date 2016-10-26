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
    public partial class FrmVisualizarTurma : Form
    {
        MO_Turma turU = new MO_Turma();
        List<MO_AlunoTurma> alocados = new List<MO_AlunoTurma>();
        BLL_Cliente cliBLL;
        BLL_Turma turBLL;

        public FrmVisualizarTurma(MO_Turma tur)
        {
            InitializeComponent();
            turU = tur;
        }

        private void BtnDeletar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmVisualizarTurma_Load(object sender, EventArgs e)
        {
            try
            {
                this.LblNome.Text = "Nome: " + turU.nome;
                this.LblLocal.Text = "Local: " + turU.local;
                this.LblSexo.Text = "Sexo: " + turU.sex;
                this.LblMax.Text = "Máximo de alunos: " + turU.maxAlunos.ToString();

                refreshGrid();
                //coisa pra tentar ajudar o usuário
                if (this.DgAlunos.Rows.Count == turU.maxAlunos)
                    this.BtnAdicionar.Enabled = false;
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        /// <summary>
        /// atualiza o grid com os usuarios que pertencem a turma..
        /// </summary>
        private void refreshGrid()
        {
            turBLL = new BLL_Turma();
            cliBLL = new BLL_Cliente();

            List<MO_AlunoTurma> listAlTr = new List<MO_AlunoTurma>();
            MO_Cliente cli;
            string[] linha = new string[3];

            listAlTr = turBLL.procuraAlunosTurma(turU);
            alocados = listAlTr;
            this.DgAlunos.Rows.Clear();
            foreach (MO_AlunoTurma a in listAlTr)
            {
                cli = new MO_Cliente();
                cli.idCli = a.idCli;
                cli = cliBLL.buscaClienteId(cli)[0];

                linha[0] = cli.idCli.ToString();
                linha[1] = cli.matricula.ToString();
                linha[2] = cli.nome;

                this.DgAlunos.Rows.Add(linha);
            }
            if (this.DgAlunos.Rows.Count >= turU.maxAlunos)
                this.BtnAdicionar.Enabled = false;
            else
                this.BtnAdicionar.Enabled = true;
        }

        private void BtnAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                FrmEditarTurma editaTur = new FrmEditarTurma(turU);
                editaTur.ShowDialog(this);
                this.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                FrmAlocaAlunoTurma aloca = new FrmAlocaAlunoTurma(alocados, turU.sex, (int)turU.id);
                aloca.ShowDialog(this);

                refreshGrid();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnExc_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Deseja excluir realmente aluno da turma? ", "Atenção!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    MO_AlunoTurma al = new MO_AlunoTurma();
                    al.idCli = int.Parse(this.DgAlunos.CurrentRow.Cells[0].Value.ToString());
                    al.idTurma = (int)turU.id;

                    turBLL = new BLL_Turma();
                    turBLL.deletarAlunoTurma(al);
                    MessageBox.Show("Aluno excluido da turma com sucesso!", "Atenção!");
                    refreshGrid();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
