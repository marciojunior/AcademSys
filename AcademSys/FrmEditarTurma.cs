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
    public partial class FrmEditarTurma : Form
    {
        MO_Turma turU = new MO_Turma();
        BLL_Turma turBLL;

        public FrmEditarTurma(MO_Turma tur)
        {
            InitializeComponent();
            turU = tur;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmEditarTurma_Load(object sender, EventArgs e)
        {
            try
            {
                this.TxtNome.Text = turU.nome;
                this.TxtLocal.Text = turU.local;
                this.TxtMaxAlunos.Text = turU.maxAlunos.ToString();
                this.CbmSexo.Text = turU.sex;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            try
            {
                turU.idUsu = Program.userLogado.id;
                turU.nome = this.TxtNome.Text;
                turU.local = this.TxtLocal.Text;
                turU.maxAlunos = int.Parse(this.TxtMaxAlunos.Text);
                turU.sex = this.CbmSexo.Text;
                turU.status = Status.ativo;

                turBLL = new BLL_Turma();
                turBLL.atualizar(turU);

                MessageBox.Show("Turma editada com sucesso!", "Atenção");
                this.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
