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
    public partial class FrmControleCaixa : Form
    {
        double totalR, totalP;
        BLL_Contas contaBLL = new BLL_Contas();

        public FrmControleCaixa()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnDeletar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnPagar_Click(object sender, EventArgs e)
        {
            try
            {
                FrmAddCP addCP = new FrmAddCP();
                addCP.ShowDialog(this);
                refreshGridP();
                this.LblCP.Text = totalP.ToString();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void refreshGridP()
        {
            contaBLL = new BLL_Contas();
            List<MO_ContasPagar> listContP = new List<MO_ContasPagar>();
            string[] row = new string[5];
            totalP = 0;
            listContP = contaBLL.pesquisaTodasCP();

            this.DgPagar.Rows.Clear();
            foreach (MO_ContasPagar cp in listContP)
            {
                row[0] = cp.id.ToString();
                row[1] = cp.idUsu.ToString();
                row[2] = cp.pag == Pago.sim ? "Sim" : "Não";
                row[3] = cp.valor.ToString();
                row[4] = cp.motivo;

                totalP += cp.valor;

                this.DgPagar.Rows.Add(row);
            }
        }

        private void FrmControleCaixa_Load(object sender, EventArgs e)
        {
            try
            {
                refreshGridP();
                refreshGridGR();
                ComplementoGridMensalidades();
                this.LblCR.Text = totalR.ToString();
                this.LblCP.Text = totalP.ToString();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void BtnPesquisaP_Click(object sender, EventArgs e)
        {
            try
            {
                MO_ContasPagar cp = new MO_ContasPagar();
                cp.id = int.Parse(this.DgPagar.CurrentRow.Cells[0].Value.ToString());
                cp.idUsu = int.Parse(this.DgPagar.CurrentRow.Cells[1].Value.ToString());
                cp.pag = (Pago)(this.DgPagar.CurrentRow.Cells[2].Value.ToString() == "Sim" ? 0 : 1);
                cp.valor = double.Parse(this.DgPagar.CurrentRow.Cells[3].Value.ToString());
                cp.motivo = this.DgPagar.CurrentRow.Cells[4].Value.ToString();

                FrmEditarCP editCP = new FrmEditarCP(cp);
                editCP.ShowDialog(this);
                refreshGridP();
                this.LblCP.Text = totalP.ToString();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        /// <summary>
        /// atualiza o grid de contas a receber
        /// </summary>
        private void refreshGridGR()
        {
            List<MO_ContasReceber> listCR = new List<MO_ContasReceber>();
            string[] row = new string[7];
            totalR = 0;
            listCR = contaBLL.pesquisaTodasCR();

            this.DgReceber.Rows.Clear();
            foreach (MO_ContasReceber cr in listCR)
            {
                row[0] = cr.id.ToString();
                row[1] = cr.idUsu.ToString();
                row[2] = "null";
                row[3] = cr.valor.ToString();
                row[4] = cr.motivo;
                row[5] = "Conta Recebida";
                row[6] = ((int)cr.fp).ToString();

                //somando
                totalR += cr.valor;

                this.DgReceber.Rows.Add(row);
            }
        }

        private void BtnReceber_Click(object sender, EventArgs e)
        {
            try
            {
                FrmAddCR addCR = new FrmAddCR();
                addCR.ShowDialog(this);
                refreshGridGR();
                ComplementoGridMensalidades();
                this.LblCR.Text = totalR.ToString();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void BtnPesquisaR_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.DgReceber.CurrentRow.Cells[5].Value.ToString() != "Mensalidade")
                {
                    MO_ContasReceber cr = new MO_ContasReceber();
                    cr.id = int.Parse(this.DgReceber.CurrentRow.Cells[0].Value.ToString());
                    cr.idUsu = int.Parse(this.DgReceber.CurrentRow.Cells[1].Value.ToString());
                    cr.valor = double.Parse(this.DgReceber.CurrentRow.Cells[3].Value.ToString());
                    cr.motivo = this.DgReceber.CurrentRow.Cells[4].Value.ToString();
                    cr.fp = (FormaP)int.Parse(this.DgReceber.CurrentRow.Cells[6].Value.ToString());

                    FrmEditarCR editarCR = new FrmEditarCR(cr);
                    editarCR.ShowDialog(this);
                }
                else throw new Exception("Mensalidade, não pode ser alterada aqui.");
                refreshGridGR();
                ComplementoGridMensalidades();
                this.LblCR.Text = totalR.ToString();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void carregaGridMensalidades()
        {
            BLL_Menssalidade mBLL = new BLL_Menssalidade();
            List<MO_Menssalidade> lm = new List<MO_Menssalidade>();
            string[] row = new string[6];

            totalR = 0;

            lm = mBLL.selecionarTodas();
            this.DgReceber.Rows.Clear();
            foreach (MO_Menssalidade m in lm)
            {
                if (m.valor != 0)
                {
                    row[0] = m.id.ToString();
                    row[1] = m.idUsu.ToString();
                    row[2] = m.idCli.ToString();
                    row[3] = m.valor.ToString();
                    row[4] = string.Format("Mensalidade paga no dia: {0} ", m.dataPago.ToString("dd/MM/yyyy"));
                    row[5] = "Mensalidade";

                    totalR += m.valor;

                    this.DgReceber.Rows.Add(row);
                }
            }
        }

        private void ComplementoGridMensalidades()
        {
            BLL_Menssalidade mBLL = new BLL_Menssalidade();
            List<MO_Menssalidade> lm = new List<MO_Menssalidade>();
            string[] row = new string[6];

            lm = mBLL.selecionarTodas();
            foreach (MO_Menssalidade m in lm)
            {
                if (m.valor != 0)
                {
                    row[0] = m.id.ToString();
                    row[1] = m.idUsu.ToString();
                    row[2] = m.idCli.ToString();
                    row[3] = m.valor.ToString();
                    row[4] = string.Format("Mensalidade paga no dia: {0} ", m.dataPago.ToString("dd/MM/yyyy"));
                    row[5] = "Mensalidade";

                    totalR += m.valor;

                    this.DgReceber.Rows.Add(row);
                }
            }
        }

        private void CbmFiltros_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.CbmFiltros.Text == "Mensalidades")
                {
                    carregaGridMensalidades();
                    this.LblCR.Text = totalR.ToString();
                }
                else if (this.CbmFiltros.Text == "Contas a Pagar")
                {
                    refreshGridGR();
                    this.LblCR.Text = totalR.ToString();
                }
                else
                {
                    refreshGridGR();
                    ComplementoGridMensalidades();
                    this.LblCR.Text = totalR.ToString();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
