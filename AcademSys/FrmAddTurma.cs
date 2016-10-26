using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Models;
using BLL;

namespace AcademSys
{
    public partial class FrmAddTurma : Form
    {
        BLL_Turma turBLL = new BLL_Turma();

        public FrmAddTurma()
        {
            InitializeComponent();
        }

        private void FrmAddTurma_Load(object sender, EventArgs e)
        {

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            try
            {
                MO_Turma tur = new MO_Turma();

                tur.idUsu = Program.userLogado.id;
                tur.nome = this.TxtNome.Text;
                tur.local = this.TxtLocal.Text;
                tur.sex = this.CbmSexo.Text;
                tur.maxAlunos = int.Parse(this.TxtMaxAlunos.Text);
                tur.status = Status.ativo;

                turBLL.inserir(tur);
                MessageBox.Show("Turma inserida com sucesso!", "Atenção!");
                this.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
