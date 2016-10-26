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
    public partial class FrmEditarCP : Form
    {
        BLL_Contas conBLL = new BLL_Contas();
        MO_ContasPagar cpU = new MO_ContasPagar();

        public FrmEditarCP(MO_ContasPagar cp)
        {
            InitializeComponent();
            cpU = cp;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmEditarCP_Load(object sender, EventArgs e)
        {
            try
            {
                this.TxtValor.Text = cpU.valor.ToString().Replace(".", ",");
                this.TxtMotivo.Text = cpU.motivo;
                this.CbmPago.Text = (int)cpU.pag == 0 ? "Sim" : "Não";
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); } 
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            try
            {
                cpU.idUsu = Program.userLogado.id;
                cpU.valor = double.Parse(this.TxtValor.Text);
                cpU.motivo = this.TxtMotivo.Text;
                cpU.pag = this.CbmPago.Text == "Sim" ? Pago.sim : Pago.nao;

                conBLL.atualizarCP(cpU);

                MessageBox.Show("Conta atualizada com sucesso!", "Atenção!");
                this.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
