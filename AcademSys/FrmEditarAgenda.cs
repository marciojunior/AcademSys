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
    public partial class FrmEditarAgenda : Form
    {
        MO_Agenda agendaMO = new MO_Agenda();
        public FrmEditarAgenda(MO_Agenda ag)
        {
            agendaMO.id = ag.id;
            agendaMO.data = ag.data;
            agendaMO.idUsu = Program.userLogado.id;
            agendaMO.titulo = ag.titulo;
            agendaMO.descricao = ag.descricao;

            InitializeComponent();
        }

        private void FrmEditarAgenda_Load(object sender, EventArgs e)
        {
            this.DtAgenda.Enabled = false;

            this.DtAgenda.Text = agendaMO.data.ToString();
            this.TxtTitulo.Text = agendaMO.titulo;
            this.TxtDesc.Text = agendaMO.descricao;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            BLL_Agenda agBLL = new BLL_Agenda();
            try
            {
                agendaMO.titulo = this.TxtTitulo.Text;
                agendaMO.descricao = this.TxtDesc.Text;

                agBLL.editarDado(agendaMO);
                MessageBox.Show("Agenda editada!", "Atenção!");
                this.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
