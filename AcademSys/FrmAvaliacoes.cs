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
    public partial class FrmAvaliacoes : Form
    {
        BLL_Avaliacoes avaBLL;

        public FrmAvaliacoes()
        {
            InitializeComponent();
            try
            {
                refreshGrid();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                FrmAddAvaliacoes avaADD = new FrmAddAvaliacoes();
                avaADD.ShowDialog(this);
                refreshGrid();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        /// <summary>
        /// da um refresh no grid...
        /// </summary>
        private void refreshGrid()
        {
            avaBLL = new BLL_Avaliacoes();
            List<MO_Avaliacao> listAva = new List<MO_Avaliacao>();
            string[] row = new string[5];

            listAva = avaBLL.buscarTodas();

            //limpando grid
            this.DgAva.Rows.Clear();
            foreach (MO_Avaliacao ava in listAva)
            {
                row[0] = ava.id.ToString();
                row[1] = ava.idCli.ToString();
                row[2] = ava.idUsu.ToString();
                row[3] = ava.data;
                row[4] = ava.hora;

                this.DgAva.Rows.Add(row);
            }
        }

        private void BtnPesquisa_Click(object sender, EventArgs e)
        {
            try
            {
                MO_Avaliacao ava = new MO_Avaliacao();

                ava.id = int.Parse(this.DgAva.CurrentRow.Cells[MO_NomesBanco.idAva].Value.ToString());
                ava.idCli = int.Parse(this.DgAva.CurrentRow.Cells[MO_NomesBanco.fkCliAva].Value.ToString());
                ava.idUsu = int.Parse(this.DgAva.CurrentRow.Cells[MO_NomesBanco.fkUsuAva].Value.ToString());
                ava.data = (string)this.DgAva.CurrentRow.Cells["data"].Value;
                ava.hora = (string)this.DgAva.CurrentRow.Cells["hora"].Value;

                FrmEditarAvaliacoes frmEditar = new FrmEditarAvaliacoes(ava);
                frmEditar.ShowDialog(this);
                refreshGrid();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExc_Click(object sender, EventArgs e)
        {
            try
            {
                //perguntar se essa porra quer excluir
                if (MessageBox.Show("Deseja mesmo excluir avaliação?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    BLL_Avaliacoes avaBLL = new BLL_Avaliacoes();
                    MO_Avaliacao ava = new MO_Avaliacao();

                    ava.id = int.Parse(this.DgAva.CurrentRow.Cells[MO_NomesBanco.idAva].Value.ToString());
                    avaBLL.deletar(ava);
                    refreshGrid();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void FrmAvaliacoes_Load(object sender, EventArgs e)
        {
            //refreshGrid();
        }
    }
}
