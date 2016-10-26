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
    public partial class FrmEditarCliente : Form
    {
        MO_Cliente cliU;
        MO_AdicionaisCliente adU;
        BLL_Cliente cliBLL = new BLL_Cliente();
        BLL_AdicionaisCliente adBLL = new BLL_AdicionaisCliente();

        public FrmEditarCliente(MO_Cliente cli)
        {
            InitializeComponent();

            cliU = new MO_Cliente();
            cliU = cli;
        }

        private void FrmEditarCliente_Load(object sender, EventArgs e)
        {
            try
            {
                //primeiro colocar os valores de cliente, depois buscar os adicionais e colocar
                this.TxtMatric.Text = cliU.matricula.ToString();
                this.TxtNome.Text = cliU.nome;
                this.TxtId.Text = cliU.identidade;
                this.TxtUF.Text = cliU.ufIdentidade;
                this.CbmSexo.Text = cliU.sexo;
                this.MskTel.Text = cliU.telefone;
                this.MskCel.Text = cliU.celular;
                this.MskCPF.Text = cliU.cpf;
                this.TxtEmail.Text = cliU.email;
                this.MskDataNasc.Text = cliU.nasc.ToString().Replace("/", "");

                //fazer a busca e agora colocar o retorno da busca nos campos.
                MO_AdicionaisCliente ad = new MO_AdicionaisCliente();
                ad.idCli = cliU.idCli;
                ad = adBLL.buscar(ad);

                adU = new MO_AdicionaisCliente();
                adU.idAdicional = ad.idAdicional;
                this.TxtObj.Text = ad.objetivo;
                this.TxtProfissao.Text = ad.profissao;
                this.CbmEstadoCivil.Text = ad.estadoCivil;
                this.TxtEmpresa.Text = ad.empresa;
                this.MskTelEmpresa.Text = ad.telEmpresa;
                this.TxtNomePai.Text = ad.nomePai;
                this.TxtNomeMae.Text = ad.nomeMae;
                this.TxtResponsavel.Text = ad.responsavel;
                this.MskTelResponsavel.Text = ad.telResponsavel;
                this.TxtEndereco.Text = ad.endereco;
                this.TxtBairro.Text = ad.bairro;
                this.TxtCidade.Text = ad.cidade;
                this.MskCEP.Text = ad.cep;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            MO_Cliente cli = new MO_Cliente();
            MO_AdicionaisCliente adCli = new MO_AdicionaisCliente();

            try 
            {
                cli = montaCli();
                adCli = montaAdCli((int)cliU.idCli);

                if (verificaCamposPreenchidos(cli, adCli))
                {
                    //monta cli
                    cliBLL.atualizar(cli);
                    //monta adCli
                    adBLL.atualizar(adCli);
                    this.Close();
                    MessageBox.Show("Cliente atualizado com sucesso!!", "Atenção");
                }
                else MessageBox.Show("Favor preencher todos os campos", "Atenção");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Monta o cliente--
        /// </summary>
        /// <returns>cliente</returns>
        private MO_Cliente montaCli()
        {
            MO_Cliente cli = new MO_Cliente();

            cli.idCli = cliU.idCli;
            cli.idUsu = Program.userLogado.id;
            cli.matricula = int.Parse(this.TxtMatric.Text);
            cli.nome = this.TxtNome.Text;
            cli.cpf = retiraCaracteresMascaras(this.MskCPF.Text);
            cli.email = this.TxtEmail.Text;
            cli.sexo = this.CbmSexo.Text.ToString();
            cli.identidade = this.TxtId.Text;
            cli.telefone = retiraCaracteresMascaras(this.MskTel.Text);
            cli.celular = retiraCaracteresMascaras(this.MskCel.Text);
            cli.ufIdentidade = this.TxtUF.Text;
            cli.nasc = Convert.ToDateTime(this.MskDataNasc.Text);
            cli.status = Status.ativo;

            return cli;
        }

        /// <summary>
        /// Monta os adicionais do cliente
        /// </summary>
        /// <param name="idCli">precisamos de saber ele atravez de uma busca no db</param>
        /// <returns>retorna o adicional montado</returns>
        private MO_AdicionaisCliente montaAdCli(int idCli)
        {
            MO_AdicionaisCliente ad = new MO_AdicionaisCliente();

            ad.idAdicional = adU.idAdicional;
            ad.idCli = idCli;
            ad.objetivo = this.TxtObj.Text;
            ad.profissao = this.TxtProfissao.Text;
            ad.estadoCivil = this.CbmEstadoCivil.Text;
            ad.empresa = this.TxtEmpresa.Text;
            ad.telEmpresa = retiraCaracteresMascaras(this.MskTelEmpresa.Text);
            ad.nomePai = this.TxtNomePai.Text;
            ad.nomeMae = this.TxtNomeMae.Text;
            ad.responsavel = this.TxtResponsavel.Text;
            ad.telResponsavel = retiraCaracteresMascaras(this.MskTelResponsavel.Text);
            ad.endereco = this.TxtEndereco.Text;
            ad.bairro = this.TxtBairro.Text;
            ad.cep = retiraCaracteresMascaras(this.MskCEP.Text);
            ad.cidade = this.TxtCidade.Text;

            return ad;
        }

        private string retiraCaracteresMascaras(string texto)
        {
            texto = texto.Replace(".", "");
            texto = texto.Replace("(", "");
            texto = texto.Replace(")", "");
            texto = texto.Replace("-", "");
            texto = texto.Replace(",", "");

            return texto;
        }

        private bool verificaCamposPreenchidos(MO_Cliente c, MO_AdicionaisCliente aC)
        {
            bool retorno = false;

            #region ==verificações==
            if (c.matricula != null)
                if (c.nome != "")
                    if (c.telefone != "")
                        if (c.celular != "")
                            if (c.sexo != "")
                                if (c.cpf != "")
                                    if (c.identidade != "")
                                        if (c.ufIdentidade != "")
                                            if (c.email != "")
                                                if (c.nasc != null)
                                                    if (aC.objetivo != "")
                                                        if (aC.profissao != "")
                                                            if (aC.estadoCivil != "")
                                                                if (aC.telEmpresa != "")
                                                                    if (aC.nomePai != "")
                                                                        if (aC.nomeMae != "")
                                                                            if (aC.responsavel != "")
                                                                                if (aC.telResponsavel != "")
                                                                                    if (aC.endereco != "")
                                                                                        if (aC.bairro != "")
                                                                                            if (aC.cep != "")
                                                                                                if (aC.cidade != "")
                                                                                                    retorno = true;
            #endregion

            return retorno;
        }
    }
}
