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
    public partial class FrmEditarMensalidade : Form
    {
        BLL_MensalidadePlano mpBLL = new BLL_MensalidadePlano();
        BLL_Menssalidade mBLL = new BLL_Menssalidade();
        MO_Menssalidade mU = new MO_Menssalidade();
        List<MO_MensalidadePlano> lpm = new List<MO_MensalidadePlano>();
        List<MO_Plano> lP = new List<MO_Plano>();

        public FrmEditarMensalidade(MO_Menssalidade m)
        {
            InitializeComponent();
            mU = m;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmEditarMensalidade_Load(object sender, EventArgs e)
        {
            try
            {
                lpm = mpBLL.procurarPorIdMens((int)mU.id);

                BLL_Plano pBLL = new BLL_Plano();
                List<MO_Plano> lP = new List<MO_Plano>();
                string[] row = new string[5];

                lP = pBLL.procurarTodasAtivas();
                this.DGPlano.Rows.Clear();
                foreach (MO_Plano p in lP)
                {
                    row[0] = p.id.ToString();
                    row[1] = verificaSelecionado((int)p.id) ? "v" : "f";
                    row[2] = p.nome;
                    row[3] = p.valor.ToString();
                    row[4] = p.qtdAula.ToString();

                    this.DGPlano.Rows.Add(row);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            try
            {
                deletaRelaçoesAntigas();
                atualizaMensalidade();
                
                //inserir
                inserirMensalidadePlano();
                this.Close();
                MessageBox.Show("Mensalidade atualizada com sucesso!", "Atenção!");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            /*try
            {
                mU.dataPago = Convert.ToDateTime(this.DtPag.Text);
                mU.dataVenc = Convert.ToDateTime(this.DtVenc.Text);
                mU.valor = double.Parse(this.TxtVal.Text);
                mU.idUsu = Program.userLogado.id;

                mBLL.atualizar(mU);
                MessageBox.Show("Pagamento atualizado com sucesso!", "Atenção!");
                this.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            */
        }

        private bool verificaSelecionado(int idPlan)
        {
            bool retorno = false;
            foreach (MO_MensalidadePlano mp in lpm)
            {
                if (mp.idPlano == idPlan)
                {
                    retorno = true;
                    break;
                }
            }
            return retorno;
        }

        private void atualizaMensalidade()
        {
            MO_Menssalidade m = new MO_Menssalidade();
            m.id = mU.id;
            m.idUsu = Program.userLogado.id;
            m.idCli = mU.idCli;
            m.dataVenc = mU.dataVenc;
            m.dataPago = DateTime.Now;
            m.valor = somaValoresSelecionados();

            mBLL.atualizar(m);
        }

        private double somaValoresSelecionados()
        {
            MO_Plano p;
            double valor = 0;
            //pegar todos os planos e somar os valores
            for (int i = 0; i < this.DGPlano.Rows.Count; i++)
            {
                //se marcado..
                if (this.DGPlano.Rows[i].Cells[1].Value != null)
                {
                    p = new MO_Plano();
                    p.id = int.Parse(this.DGPlano.Rows[i].Cells[0].Value.ToString());
                    p.valor = double.Parse(this.DGPlano.Rows[i].Cells[3].Value.ToString());
                    //valor para ser usado
                    valor += p.valor;
                    //adicionando na lista
                    lP.Add(p);
                }
            }
            return valor;
        }

        private void deletaRelaçoesAntigas()
        {
            foreach (MO_MensalidadePlano mp in lpm)
            {
                mpBLL.excluir(mp);
            }
        }

        private void inserirMensalidadePlano()
        {
            MO_MensalidadePlano mp;

            foreach (MO_Plano p in lP)
            {
                mp = new MO_MensalidadePlano();
                mp.idMens = mU.id;
                mp.idPlano = p.id;
                mpBLL.inserir(mp);
            }
        }
    }
}
