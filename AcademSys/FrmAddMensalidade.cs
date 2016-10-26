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
    public partial class FrmAddMensalidade : Form
    {
        List<MO_Plano> lP = new List<MO_Plano>();
        BLL_Menssalidade mBLL = new BLL_Menssalidade();
        BLL_MensalidadePlano mpBLL = new BLL_MensalidadePlano();
        int idCliU;
        int idMenU;
        DateTime dtVencU;

        public FrmAddMensalidade(int idCli, int idMen, DateTime dtVenc)
        {
            InitializeComponent();
            idCliU = idCli;
            idMenU = idMen;
            dtVencU = dtVenc;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            try
            {
                //atualizar a mensalidade
                atualizaMensalidade();
                //inserindo as relações entre os dois.
                inserirMensalidadePlano();
                //avisando essa bosta
                MessageBox.Show("Mesalidade paga com sucesso!", "Atenção!");
                this.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

            //isso é o antigo, o novo além de atualizar algum, vai inserir o do outro mes..
            /*try
            {
                MO_Menssalidade m = new MO_Menssalidade();
                m.idCli = idCliU;
                m.idUsu = Program.userLogado.id;
                m.valor = double.Parse(this.TxtVal.Text);
                m.dataPago = Convert.ToDateTime(this.DtPag.Text);
                m.dataVenc = Convert.ToDateTime(this.DtVenc.Text);

                mBLL.inserir(m);
                MessageBox.Show("Pago com sucesso!", "Atenção");
                this.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
             */
        }

        private void FrmAddMensalidade_Load(object sender, EventArgs e)
        {
            try
            {
                BLL_Plano pBLL = new BLL_Plano();
                List<MO_Plano> lP = new List<MO_Plano>();
                string[] row = new string[5];

                lP = pBLL.procurarTodasAtivas();
                this.DGPlano.Rows.Clear();
                foreach (MO_Plano p in lP)
                {
                    row[0] = p.id.ToString();
                    row[2] = p.nome;
                    row[3] = p.valor.ToString();
                    row[4] = p.qtdAula.ToString();

                    this.DGPlano.Rows.Add(row);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void atualizaMensalidade()
        {
            MO_Menssalidade m = new MO_Menssalidade();
            m.id = idMenU;
            m.idUsu = Program.userLogado.id;
            m.idCli = idCliU;
            m.dataVenc = dtVencU;
            m.dataPago = DateTime.Now;
            m.valor = somaValoresSelecionados();

            mBLL.atualizar(m);
            //apos atualizar ele vai inserir a do proximo mes.
            m = new MO_Menssalidade();
            m.idUsu = Program.userLogado.id;
            m.idCli = idCliU;
            //proximo mes..
            m.dataVenc = dtVencU.AddMonths(1);
            mBLL.inserir(m);
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

        private void inserirMensalidadePlano()
        {
            MO_MensalidadePlano mp;

            foreach (MO_Plano p in lP)
            {
                mp = new MO_MensalidadePlano();
                mp.idMens = idMenU;
                mp.idPlano = p.id;
                mpBLL.inserir(mp);
            }
        }
    }
}
