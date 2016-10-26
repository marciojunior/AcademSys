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
    public partial class FrmAddCR : Form
    {
        BLL_Contas contaBLL;

        public FrmAddCR()
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
                MO_ContasReceber cr = new MO_ContasReceber();

                cr.idUsu = Program.userLogado.id;
                cr.idCli = null;
                cr.valor = double.Parse(this.TxtValor.Text);
                cr.motivo = this.TxtMotivo.Text;
                cr.fp = (FormaP)this.CbmForma.SelectedIndex;

                contaBLL.inserirCR(cr);

                MessageBox.Show("Conta inserida com sucesso!", "Atenção!");
                this.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
