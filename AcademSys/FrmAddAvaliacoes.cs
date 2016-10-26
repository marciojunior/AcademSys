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
    public partial class FrmAddAvaliacoes : Form
    {
        public FrmAddAvaliacoes()
        {
            InitializeComponent();
        }

        private void FrmAddAvaliacoes_Load(object sender, EventArgs e)
        {
            //fazer a busca de usuarios e preencher combo
            preencheCli();
        }

        /// <summary>
        /// preenche os clientes que existem no banco..
        /// </summary>
        private void preencheCli()
        {
            BLL_Cliente cliBLL = new BLL_Cliente();
            List<MO_Cliente> listCli = new List<MO_Cliente>();

            listCli = cliBLL.buscaTodosClientesAtivos();


            this.CbmCli.DataSource = listCli;
            this.CbmCli.ValueMember = MO_NomesBanco.nomeCli;
            this.CbmCli.DisplayMember = MO_NomesBanco.idCli;
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
                MO_Avaliacao ava = new MO_Avaliacao();

                ava.idCli = ((MO_Cliente)this.CbmCli.SelectedItem).idCli;
                ava.idUsu = Program.userLogado.id;
                ava.data = (Convert.ToDateTime(this.DtData.Text)).ToString("dd/MM/yyyy");
                ava.hora = this.MskHora.Text.ToString();

                avaBLL.inserir(ava);
                MessageBox.Show("Avaliação inserida com sucesso!", "Atenção");
                this.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}