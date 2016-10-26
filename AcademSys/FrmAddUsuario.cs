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
    public partial class FrmAddUsuario : Form
    {
        BLL_Usuarios usuBLL = new BLL_Usuarios();
        MO_Usuario usuMO;

        public FrmAddUsuario()
        {
            InitializeComponent();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            //fechar a parada
            this.Close();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            try
            {
                usuMO = new MO_Usuario();
                usuMO.nome = this.TxtNome.Text;
                usuMO.login = this.TxtLogin.Text;
                usuMO.senha = this.TxtSenha.Text;

                usuBLL.inserir(usuMO);
                //avisa e sai
                MessageBox.Show("Usuário cadastrado com sucesso!!", "Atenção!");
                this.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
