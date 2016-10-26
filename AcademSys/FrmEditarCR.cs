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
    public partial class FrmEditarCR : Form
    {
        BLL_Contas contaBLL = new BLL_Contas();
        MO_ContasReceber crU = new MO_ContasReceber();

        public FrmEditarCR(MO_ContasReceber cr)
        {
            InitializeComponent();
            crU = cr;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmEditarCR_Load(object sender, EventArgs e)
        {
            try
            {
                this.TxtValor.Text = crU.valor.ToString();
                this.TxtMotivo.Text = crU.motivo;
                this.CbmForma.SelectedIndex = (int)crU.fp;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            try
            {
                crU.idUsu = Program.userLogado.id;
                crU.valor = double.Parse(this.TxtValor.Text);
                crU.motivo = this.TxtMotivo.Text;
                crU.fp = (FormaP)this.CbmForma.SelectedIndex;

                contaBLL.editarCR(crU);

                MessageBox.Show("Conta atualizada com sucesso!", "Atenção!");
                this.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
