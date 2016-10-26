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
    public partial class FrmTurma : Form
    {
        BLL_Turma turBLL = new BLL_Turma();

        public FrmTurma()
        {
            InitializeComponent();
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                FrmAddTurma addTurma = new FrmAddTurma();
                addTurma.ShowDialog(this);
                refreshGrid();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmTurma_Load(object sender, EventArgs e)
        {
            try { refreshGrid(); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        /// <summary>
        /// coloca tudo dentro do maltito grid
        /// </summary>
        private void refreshGrid()
        {
            List<MO_Turma> listTur = new List<MO_Turma>();
            listTur = turBLL.procurarTurmasAtivas();
            string[] row = new string[6];

            //limpa as linhas
            this.DgAva.Rows.Clear();
            foreach (MO_Turma tur in listTur)
            {
                row[0] = tur.id.ToString();
                row[1] = tur.idUsu.ToString();
                row[2] = tur.nome;
                row[3] = tur.local;
                row[4] = tur.sex;
                row[5] = tur.maxAlunos.ToString();

                this.DgAva.Rows.Add(row);
            }
        }

        private void BtnPesquisa_Click(object sender, EventArgs e)
        {
            try
            {
                MO_Turma tur = new MO_Turma();

                tur.id = int.Parse(this.DgAva.CurrentRow.Cells[0].Value.ToString());
                tur.idUsu = int.Parse(this.DgAva.CurrentRow.Cells[1].Value.ToString());
                tur.nome = this.DgAva.CurrentRow.Cells[2].Value.ToString();
                tur.local = this.DgAva.CurrentRow.Cells[3].Value.ToString();
                tur.sex = this.DgAva.CurrentRow.Cells[4].Value.ToString();
                tur.maxAlunos = int.Parse(this.DgAva.CurrentRow.Cells[5].Value.ToString());
                tur.status = Status.ativo;

                FrmVisualizarTurma visuTurma = new FrmVisualizarTurma(tur);
                visuTurma.ShowDialog(this);
                refreshGrid();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnExc_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Deseja realmente excluir turma?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    MO_Turma tur = new MO_Turma();

                    tur.id = int.Parse(this.DgAva.CurrentRow.Cells[0].Value.ToString());
                    tur.idUsu = int.Parse(this.DgAva.CurrentRow.Cells[1].Value.ToString());
                    tur.nome = this.DgAva.CurrentRow.Cells[2].Value.ToString();
                    tur.local = this.DgAva.CurrentRow.Cells[3].Value.ToString();
                    tur.sex = this.DgAva.CurrentRow.Cells[4].Value.ToString();
                    tur.maxAlunos = int.Parse(this.DgAva.CurrentRow.Cells[5].Value.ToString());
                    tur.status = Status.inativo;

                    turBLL.atualizar(tur);
                    MessageBox.Show("Turma excluida com sucesso!");
                    refreshGrid();
                }
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
    }
}
