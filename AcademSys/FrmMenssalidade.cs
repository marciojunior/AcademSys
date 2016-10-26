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
    public partial class FrmMenssalidade : Form
    {
        BLL_Menssalidade menBLL = new BLL_Menssalidade();
        int idCliU;

        public FrmMenssalidade(int idCli)
        {
            InitializeComponent();
            idCliU = idCli;
        }

        private void BtnDeletar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmMenssalidade_Load(object sender, EventArgs e)
        {
            try
            {
                refreshGrid();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        /// <summary>
        /// atualiza o grid com novos valores
        /// </summary>
        private void refreshGrid()
        {
            List<MO_Menssalidade> listMens = new List<MO_Menssalidade>();
            string[] row = new string[6];

            listMens = menBLL.pesquisaTodasCli(idCliU);

            this.DgMens.Rows.Clear();
            foreach (MO_Menssalidade m in listMens)
            {
                row[0] = m.id.ToString();
                row[1] = m.idUsu.ToString();
                row[2] = m.idCli.ToString();
                row[3] = m.valor.ToString();
                row[4] = m.dataVenc != DateTime.MinValue ? m.dataVenc.ToString("dd/MM/yyyy") : "";
                row[5] = m.dataPago != DateTime.MinValue ? m.dataPago.ToString("dd/MM/yyyy") : "";

                this.DgMens.Rows.Add(row);
            }
        }

        private void BtnPagar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.DgMens.CurrentRow.Cells[3].Value.ToString() == "0")
                {
                    FrmAddMensalidade addM = new FrmAddMensalidade(idCliU, int.Parse(this.DgMens.CurrentRow.Cells[0].Value.ToString()), Convert.ToDateTime(this.DgMens.CurrentRow.Cells[4].Value.ToString()));
                    addM.ShowDialog(this);
                    refreshGrid();
                }
                else throw new Exception("Mensalidade já foi paga.");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void BtnPesquisa_Click(object sender, EventArgs e)
        {
            try
            {
                MO_Menssalidade m = new MO_Menssalidade();
                m.id = int.Parse(this.DgMens.CurrentRow.Cells[0].Value.ToString());
                m.idUsu = int.Parse(this.DgMens.CurrentRow.Cells[1].Value.ToString());
                m.idCli = int.Parse(this.DgMens.CurrentRow.Cells[2].Value.ToString());
                m.valor = double.Parse(this.DgMens.CurrentRow.Cells[3].Value.ToString());
                m.dataVenc = Convert.ToDateTime(this.DgMens.CurrentRow.Cells[4].Value.ToString());
                m.dataPago = Convert.ToDateTime(this.DgMens.CurrentRow.Cells[5].Value.ToString());

                FrmEditarMensalidade editM = new FrmEditarMensalidade(m);
                editM.ShowDialog(this);
                refreshGrid();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
