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
    public partial class FrmPrincipal : Form
    {
        BLL_Ponto pBLL = new BLL_Ponto();

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void BtnUsuario_Click(object sender, EventArgs e)
        {
            FrmUsuarios usu = new FrmUsuarios();
            usu.ShowDialog(this);
            atualizaAgenda();
        }

        private void BtnAgenda_Click(object sender, EventArgs e)
        {
            FrmAgenda agenda = new FrmAgenda();
            agenda.ShowDialog(this);
            atualizaAgenda();
        }

        private void BtnCaixa_Click(object sender, EventArgs e)
        {
            FrmControleCaixa caixa = new FrmControleCaixa();
            caixa.ShowDialog(this);
            atualizaAgenda();
        }

        private void BtnCliente_Click(object sender, EventArgs e)
        {
            FmrClientes cli = new FmrClientes();
            cli.ShowDialog(this);
            atualizaAgenda();
        }

        private void BtnTurmas_Click(object sender, EventArgs e)
        {
            FrmTurma tur = new FrmTurma();
            tur.ShowDialog(this);
            atualizaAgenda();
        }

        private void BtnAvaliacao_Click(object sender, EventArgs e)
        {
            FrmAvaliacoes ava = new FrmAvaliacoes();
            ava.ShowDialog(this);
            atualizaAgenda();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            try
            {
                MO_Ponto p = new MO_Ponto();
                p.hrSaida = DateTime.Now;
                p.dataSaida = DateTime.Now;

                pBLL.fecharPonto(p);
                Application.Exit();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            try
            {
                MO_Ponto p = new MO_Ponto();

                p.idUsu = Program.userLogado.id;
                p.hrEntrada = DateTime.Now;
                p.dataEntrada = DateTime.Now;
                this.TLNome.Text = "Bem vindo, " + Program.userLogado.nome;

                pBLL.inserirPonto(p);
                atualizaAgenda();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void TSLPonto_Click(object sender, EventArgs e)
        {
            FrmPonto p = new FrmPonto();
            p.ShowDialog(this);
            atualizaAgenda();
        }

        private void atualizaAgenda()
        {
            try
            {
                MO_Agenda p = new MO_Agenda();
                MO_Cliente c = new MO_Cliente();

                BLL_Cliente cliBLL = new BLL_Cliente();
                BLL_Avaliacoes avaBLL = new BLL_Avaliacoes();
                BLL_Agenda aBLL = new BLL_Agenda();

                List<MO_Agenda> lA = new List<MO_Agenda>();
                List<MO_Avaliacao> lAva = new List<MO_Avaliacao>();
                string[] row = new string[2];

                p.idUsu = Program.userLogado.id;
                p.data = DateTime.Now;

                lA = aBLL.procurar(p);

                this.DgAgenda.Rows.Clear();
                foreach (MO_Agenda a in lA)
                {
                    row[0] = a.titulo;
                    row[1] = a.descricao;

                    this.DgAgenda.Rows.Add(row);
                }

                lAva = avaBLL.buscaDia(DateTime.Now.ToString("dd/MM/yyyy"));

                this.DgAva.Rows.Clear();
                foreach (MO_Avaliacao a in lAva)
                {
                    c = new MO_Cliente();
                    c.idCli = a.idCli;

                    row[0] = cliBLL.buscaClienteId(c)[0].nome;
                    row[1] = a.hora;

                    this.DgAva.Rows.Add(row);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void TSLSobre_Click(object sender, EventArgs e)
        {
            ajuda a = new ajuda();
            a.ShowDialog(this);
        }

        private void BtnPlanos_Click(object sender, EventArgs e)
        {
            try
            {
                FrmPlano p = new FrmPlano();
                p.ShowDialog(this);
                atualizaAgenda();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
