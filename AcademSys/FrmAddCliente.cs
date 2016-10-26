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
    public partial class FrmAddCliente : Form
    {
        public FrmAddCliente()
        {
            InitializeComponent();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            MO_Cliente cli = new MO_Cliente();
            BLL_Cliente cliBLL = new BLL_Cliente();
            BLL_AdicionaisCliente adBLL = new BLL_AdicionaisCliente();
            MO_AdicionaisCliente adCli = new MO_AdicionaisCliente();
            int id = 0;

            try 
            {
                cli = montaCli();
                //parte de adicionais do cliente(outra tabela)
                adCli = montaAdCli(id);

                if (verificaCamposPreenchidos(cli, adCli))
                {
                    //inserindo de fato
                    adCli.idCli = cliBLL.inserir(cli);
                    adBLL.inserir(adCli);


                    //inserindo a primeira mensalidade deste cliente.
                    inserirPrimeiraMensalidade((int)adCli.idCli);

                    this.Close();
                    MessageBox.Show("Cliente inserido com sucesso!", "Atenção");
                }
                else MessageBox.Show("Favor preencher todos os campos!", "Atenção");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        /// <summary>
        /// Monta o cliente--
        /// </summary>
        /// <returns>cliente</returns>
        private MO_Cliente montaCli()
        {
            MO_Cliente cli = new MO_Cliente();

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

        /// <summary>
        /// remove todos caracteres especiais dessa bosta.
        /// </summary>
        /// <param name="texto">recebe o texto das mascaras</param>
        /// <returns>texto limpo =)</returns>
        private string retiraCaracteresMascaras(string texto)
        {
            texto = texto.Replace(".", "");
            texto = texto.Replace("(", "");
            texto = texto.Replace(")", "");
            texto = texto.Replace("-", "");
            texto = texto.Replace(",", "");
            texto = texto.Replace(" ", "");

            return texto;
        }

        /// <summary>
        /// Quando inserimos um cliente, ele já tem que pagar o mes seguinte.
        /// </summary>
        /// <param name="idCli">id do cliente em questão</param>
        private void inserirPrimeiraMensalidade(int idCli)
        {
            BLL_Menssalidade mBLL = new BLL_Menssalidade();
            MO_Menssalidade m = new MO_Menssalidade();
            m.idUsu = Program.userLogado.id;
            m.idCli = idCli;
            m.dataVenc = DateTime.Now.AddMonths(1);
            mBLL.inserir(m);
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
