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
    public partial class FrmEditarPlano : Form
    {
        MO_Plano pU = new MO_Plano();

        public FrmEditarPlano(MO_Plano p)
        {
            InitializeComponent();

            pU = p;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmEditarPlano_Load(object sender, EventArgs e)
        {
            try
            {
                this.TxtNome.Text = pU.nome;
                this.TxtValor.Text = pU.valor.ToString();
                this.TxtQuantidade.Text = pU.qtdAula.ToString();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            try
            {
                BLL_Plano pBLL = new BLL_Plano();
                pU.idUsu = Program.userLogado.id;
                pU.nome = this.TxtNome.Text;
                pU.valor = double.Parse(this.TxtValor.Text);
                pU.qtdAula = int.Parse(this.TxtQuantidade.Text);
                pU.stat = Status.ativo;

                pBLL.editar(pU);
                MessageBox.Show("Plano editado com sucesso!", "Atenção!");
                this.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
