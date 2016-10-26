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
    public partial class FrmAddCP : Form
    {
        BLL_Contas contaBLL;

        public FrmAddCP()
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
                contaBLL = new BLL_Contas();
                MO_ContasPagar cp = new MO_ContasPagar();

                cp.idUsu = Program.userLogado.id;
                cp.valor = double.Parse(this.TxtValor.Text);
                cp.motivo = this.TxtMotivo.Text;
                cp.pag = this.CbmPago.Text == "Sim" ? Pago.sim : Pago.nao;

                contaBLL.inserirCP(cp);

                MessageBox.Show("Conta inserida com sucesso!", "Atenção!");
                this.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
