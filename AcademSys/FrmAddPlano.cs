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
    public partial class FrmAddPlano : Form
    {
        public FrmAddPlano()
        {
            InitializeComponent();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            try
            {
                BLL_Plano pBLL = new BLL_Plano();

                MO_Plano p = new MO_Plano();
                p.idUsu = Program.userLogado.id;
                p.nome = this.TxtNome.Text;
                p.valor = Convert.ToDouble(this.TxtValor.Text);
                p.qtdAula = int.Parse(this.TxtQuantidade.Text);

                pBLL.inserir(p);
                MessageBox.Show("Plano adicionado com sucesso!", "Atenção!");
                this.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
