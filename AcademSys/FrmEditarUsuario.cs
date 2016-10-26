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
    public partial class FrmEditarUsuario : Form
    {
        MO_Usuario user = new MO_Usuario();

        public FrmEditarUsuario(MO_Usuario u)
        {
            InitializeComponent();
            user = u;
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            BLL_Usuarios usuBLL = new BLL_Usuarios();
            try
            {
                user.nome = this.TxtNome.Text;
                user.login = this.TxtLogin.Text;
                user.senha = this.TxtSenha.Text;
                user.status = Status.ativo;

                usuBLL.atualiza(user);
                MessageBox.Show("Usuário editado com sucesso!", "Atenção!");
                this.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void FrmEditarUsuario_Load(object sender, EventArgs e)
        {
            if (user != null)
            {
                this.TxtNome.Text = user.nome;
                this.TxtLogin.Text = user.login;
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
