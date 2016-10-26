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
    public partial class FrmEditarAvaliacoes : Form
    {
        MO_Avaliacao avaU = new MO_Avaliacao();

        public FrmEditarAvaliacoes(MO_Avaliacao ava)
        {
            InitializeComponent();

            avaU = ava;
        }

        private void FrmEditarAvaliacoes_Load(object sender, EventArgs e)
        {
            try
            {
                MO_Cliente cli = new MO_Cliente();
                BLL_Cliente cliBLL = new BLL_Cliente();

                cli.idCli = avaU.idCli;
                this.CbmCli.DataSource = cliBLL.buscaClienteId(cli);
                this.CbmCli.ValueMember = MO_NomesBanco.nomeCli;
                this.CbmCli.DisplayMember = MO_NomesBanco.idCli;

                this.DtData.Text = avaU.data;
                this.MskHora.Text = avaU.hora.Replace(":", "");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            try
            {
                BLL_Avaliacoes avaBLL = new BLL_Avaliacoes();
                avaU.hora = this.MskHora.Text;
                avaU.data = (Convert.ToDateTime(this.DtData.Text)).ToString("dd/MM/yyyy");

                avaBLL.editar(avaU);
                MessageBox.Show("Avaliação editada com sucesso.", "Atenção");
                this.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
