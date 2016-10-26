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
    public partial class FmrClientes : Form
    {
        BLL_Cliente cliBll;

        public FmrClientes()
        {
            InitializeComponent();
        }

        private void FmrClientes_Load(object sender, EventArgs e)
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
                FrmAddCliente add = new FrmAddCliente();
                add.ShowDialog(this);
                refreshGrid();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        /// <summary>
        /// Atualiza o grid, usado em uma porrada de coisa.. 
        /// </summary>
        private void refreshGrid()
        {
            cliBll = new BLL_Cliente();
            List<MO_Cliente> resp = new List<MO_Cliente>();
            string[] rola = new string[14];

            resp = cliBll.buscaTodosClientesAtivos();

            //limpa grid
            this.GdUsuario.Rows.Clear();

            foreach (MO_Cliente cli in resp)
            {
                rola[0] = cli.idCli.ToString();
                rola[1] = cli.idUsu.ToString();
                rola[2] = cli.matricula.ToString();
                rola[3] = cli.nome;
                rola[4] = cli.sexo;
                rola[5] = cli.telefone;
                rola[6] = cli.celular;
                rola[7] = cli.cpf;
                rola[8] = cli.identidade;
                rola[9] = cli.ufIdentidade;
                rola[10] = cli.email;
                rola[11] = cli.nasc.ToString("dd/MM/yyyy");
                rola[12] = cli.status.ToString();
                rola[13] = verificaSituacaoCliente((int)cli.idCli) ? "Mensalidade em dia" : "Mensalidade atrasada";

                //adicionando a rola(linha) kkkkk
                this.GdUsuario.Rows.Add(rola);
            }
        }

        private void BtnPesquisa_Click(object sender, EventArgs e)
        {
            try
            {
                MO_Cliente cli = new MO_Cliente();

                cli.idCli = int.Parse(this.GdUsuario.CurrentRow.Cells["id"].Value.ToString());
                cli.idUsu = int.Parse(this.GdUsuario.CurrentRow.Cells["idUsu"].Value.ToString());
                cli.matricula = int.Parse(this.GdUsuario.CurrentRow.Cells["matricula"].Value.ToString());
                cli.nome = this.GdUsuario.CurrentRow.Cells["nome"].Value.ToString();
                cli.sexo = this.GdUsuario.CurrentRow.Cells["sexo"].Value.ToString();
                cli.telefone = this.GdUsuario.CurrentRow.Cells["tel"].Value.ToString();
                cli.celular = this.GdUsuario.CurrentRow.Cells["cel"].Value.ToString();
                cli.cpf = this.GdUsuario.CurrentRow.Cells["cpf"].Value.ToString();
                cli.identidade = this.GdUsuario.CurrentRow.Cells["identidade"].Value.ToString();
                cli.ufIdentidade = this.GdUsuario.CurrentRow.Cells["ufIdentidade"].Value.ToString();
                cli.email = this.GdUsuario.CurrentRow.Cells["email"].Value.ToString();
                cli.nasc = Convert.ToDateTime(this.GdUsuario.CurrentRow.Cells["dataNasc"].Value.ToString());

                FrmEditarCliente edit = new FrmEditarCliente(cli);
                edit.ShowDialog(this);
                refreshGrid();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnExc_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Deseja realmente excluir o cliente? ", "Atenção!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    MO_Cliente cli = new MO_Cliente();

                    cli.idCli = int.Parse(this.GdUsuario.CurrentRow.Cells["id"].Value.ToString());
                    cli.idUsu = int.Parse(this.GdUsuario.CurrentRow.Cells["idUsu"].Value.ToString());
                    cli.matricula = int.Parse(this.GdUsuario.CurrentRow.Cells["matricula"].Value.ToString());
                    cli.nome = this.GdUsuario.CurrentRow.Cells["nome"].Value.ToString();
                    cli.sexo = this.GdUsuario.CurrentRow.Cells["sexo"].Value.ToString();
                    cli.telefone = this.GdUsuario.CurrentRow.Cells["tel"].Value.ToString();
                    cli.celular = this.GdUsuario.CurrentRow.Cells["cel"].Value.ToString();
                    cli.cpf = this.GdUsuario.CurrentRow.Cells["cpf"].Value.ToString();
                    cli.identidade = this.GdUsuario.CurrentRow.Cells["identidade"].Value.ToString();
                    cli.ufIdentidade = this.GdUsuario.CurrentRow.Cells["ufIdentidade"].Value.ToString();
                    cli.email = this.GdUsuario.CurrentRow.Cells["email"].Value.ToString();
                    cli.nasc = Convert.ToDateTime(this.GdUsuario.CurrentRow.Cells["dataNasc"].Value.ToString());
                    cli.status = Status.inativo;

                    cliBll.atualizar(cli);
                    refreshGrid();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void BtnDeletar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnPagar_Click(object sender, EventArgs e)
        {
            try
            {
                FrmMenssalidade m = new FrmMenssalidade(int.Parse(this.GdUsuario.CurrentRow.Cells[0].Value.ToString()));
                m.ShowDialog(this);
                refreshGrid();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void TxtPesq_TextChanged(object sender, EventArgs e)
        {
            try
            {
                cliBll = new BLL_Cliente();
                List<MO_Cliente> resp = new List<MO_Cliente>();
                string[] rola = new string[13];

                resp = cliBll.buscaClienteNome(this.TxtPesq.Text);

                //limpa grid
                this.GdUsuario.Rows.Clear();

                foreach (MO_Cliente cli in resp)
                {
                    rola[0] = cli.idCli.ToString();
                    rola[1] = cli.idUsu.ToString();
                    rola[2] = cli.matricula.ToString();
                    rola[3] = cli.nome;
                    rola[4] = cli.sexo;
                    rola[5] = cli.telefone;
                    rola[6] = cli.celular;
                    rola[7] = cli.cpf;
                    rola[8] = cli.identidade;
                    rola[9] = cli.ufIdentidade;
                    rola[10] = cli.email;
                    rola[11] = cli.nasc.ToString("dd/MM/yyyy");
                    rola[12] = cli.status.ToString();

                    //adicionando a rola(linha) kkkkk
                    this.GdUsuario.Rows.Add(rola);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private bool verificaSituacaoCliente(int idCli)
        {
            BLL_Menssalidade mBLL = new BLL_Menssalidade();
            MO_Menssalidade mI = new MO_Menssalidade();
            mI = mBLL.ultimaLinhaInserida(idCli);
            return mI.dataVenc >= DateTime.Now ? true : false;
        }
    }
}
