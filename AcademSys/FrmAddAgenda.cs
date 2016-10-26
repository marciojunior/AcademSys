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
    public partial class FrmAddAgenda : Form
    {
        public FrmAddAgenda()
        {
            InitializeComponent();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            BLL_Agenda agBLL = new BLL_Agenda();
            MO_Agenda agMO = new MO_Agenda();
            try
            {
                agMO.idUsu = Program.userLogado.id;
                agMO.data = Convert.ToDateTime(this.DtAgenda.Text);
                agMO.titulo = this.TxtTitulo.Text;
                agMO.descricao = this.TxtDesc.Text;

                agBLL.inserirDados(agMO);
                MessageBox.Show("Adicionado com sucesso!!", "Atenção");
                this.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
