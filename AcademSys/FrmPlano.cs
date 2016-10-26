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
    public partial class FrmPlano : Form
    {
        public FrmPlano()
        {
            InitializeComponent();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Atualiza o grid todo
        /// </summary>
        private void refreshGrid()
        {
            BLL_Plano pBLL = new BLL_Plano();
            List<MO_Plano> lP = new List<MO_Plano>();
            string[] row = new string[5];

            lP = pBLL.procurarTodasAtivas();
            this.DGPlanos.Rows.Clear();

            foreach (MO_Plano p in lP)
            {
                row[0] = p.id.ToString();
                row[1] = p.idUsu.ToString();
                row[2] = p.nome;
                row[3] = p.valor.ToString();
                row[4] = p.qtdAula.ToString();

                this.DGPlanos.Rows.Add(row);
            }
        }

        private void FrmPlano_Load(object sender, EventArgs e)
        {
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
                FrmAddPlano ap = new FrmAddPlano();
                ap.ShowDialog(this);

                refreshGrid();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void BtnPesquisa_Click(object sender, EventArgs e)
        {
            try
            {
                MO_Plano p = new MO_Plano();
                p.id = int.Parse(this.DGPlanos.CurrentRow.Cells[0].Value.ToString());
                p.idUsu = int.Parse(this.DGPlanos.CurrentRow.Cells[1].Value.ToString());
                p.nome = this.DGPlanos.CurrentRow.Cells[2].Value.ToString();
                p.valor = double.Parse(this.DGPlanos.CurrentRow.Cells[3].Value.ToString());
                p.qtdAula = int.Parse(this.DGPlanos.CurrentRow.Cells[4].Value.ToString());

                FrmEditarPlano ep = new FrmEditarPlano(p);
                ep.ShowDialog(this);
                refreshGrid();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnExc_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Deseja mesmo excluir plano?", "Atenção!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    BLL_Plano pBLL = new BLL_Plano();
                    MO_Plano p = new MO_Plano();
                    p.id = int.Parse(this.DGPlanos.CurrentRow.Cells[0].Value.ToString());
                    p.idUsu = int.Parse(this.DGPlanos.CurrentRow.Cells[1].Value.ToString());
                    p.nome = this.DGPlanos.CurrentRow.Cells[2].Value.ToString();
                    p.valor = double.Parse(this.DGPlanos.CurrentRow.Cells[3].Value.ToString());
                    p.qtdAula = int.Parse(this.DGPlanos.CurrentRow.Cells[4].Value.ToString());
                    p.stat = Status.inativo;

                    pBLL.editar(p);
                    refreshGrid();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
