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
    public partial class FrmLogin : Form
    {
        BLL_Usuarios usuBLL = new BLL_Usuarios();

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmPrincipal p = new FrmPrincipal();
            MO_Usuario usu = new MO_Usuario();

            try
            {
                usu.login = this.TxtLogin.Text;
                usu.senha = this.TxtSenha.Text;
                usu = usuBLL.logar(usu);
                if (usu != null)
                {
                    Program.userLogado = usu;
                    p.ShowDialog(this);
                }
                else
                {
                    MessageBox.Show("Usuário ou senha incorretos!", "Atenção!");
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
