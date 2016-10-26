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
    public partial class FrmAgenda : Form
    {
        public FrmAgenda()
        {
            InitializeComponent();
        }

        private void FrmAgenda_Load(object sender, EventArgs e)
        {
            inicializa();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChkTodos_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                MO_Agenda a = new MO_Agenda();

                if (this.ChkTodos.Checked)
                {
                    //habilita a parada pra poder fazer a busca..
                    this.DtAgenda.Enabled = false;
                    
                    a.idUsu = Program.userLogado.id;
                    a.data = DateTime.MinValue;
                    refreshGrid(a);
                }
                else
                {
                    this.DtAgenda.Enabled = true;

                    a.idUsu = Program.userLogado.id;
                    a.data = Convert.ToDateTime(this.DtAgenda.Text);
                    refreshGrid(a);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void refreshGrid(MO_Agenda ag)
        {
            BLL_Agenda agendaBLL = new BLL_Agenda();
            List<MO_Agenda> listAgenda = new List<MO_Agenda>();
            string[] linha = new string[4];

            listAgenda = agendaBLL.procurar(ag);
            //limpa grid
            this.DgAgenda.Rows.Clear();
            foreach (MO_Agenda a in listAgenda)
            {
                linha[0] = a.id.ToString();
                linha[1] = a.titulo;
                linha[2] = a.data.ToString();
                linha[3] = a.descricao;

                this.DgAgenda.Rows.Add(linha);
            }
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            FrmAddAgenda addAgenda = new FrmAddAgenda();
            addAgenda.ShowDialog(this);
            inicializa();
        }

        private void DtAgenda_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                MO_Agenda a = new MO_Agenda();

                a.idUsu = Program.userLogado.id;
                a.data = Convert.ToDateTime(this.DtAgenda.Text);
                refreshGrid(a);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void inicializa()
        {
            //quando começar esse vai ser o default
            this.ChkTodos.Checked = true;
            this.DtAgenda.Enabled = false;

            try
            {
                MO_Agenda a = new MO_Agenda();
                a.idUsu = Program.userLogado.id;
                a.data = DateTime.MinValue;
                refreshGrid(a);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void BtnPesquisa_Click(object sender, EventArgs e)
        {
            //montando
            try
            {
                MO_Agenda ag = new MO_Agenda();

                ag.id = int.Parse(this.DgAgenda.CurrentRow.Cells["id"].Value.ToString());
                ag.data = Convert.ToDateTime(this.DgAgenda.CurrentRow.Cells["data"].Value.ToString());
                ag.titulo = this.DgAgenda.CurrentRow.Cells["titulo"].Value.ToString();
                ag.descricao = this.DgAgenda.CurrentRow.Cells["desc"].Value.ToString();

                FrmEditarAgenda ea = new FrmEditarAgenda(ag);
                ea.ShowDialog(this);
                inicializa();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
