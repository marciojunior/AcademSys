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
    public partial class FrmUsuarios : Form
    {
        BLL_Usuarios usuBLL = new BLL_Usuarios();
        List<MO_Usuario> usuMO = new List<MO_Usuario>();

        public FrmUsuarios()
        {
            InitializeComponent();
        }

        private void BtnDeletar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAtualizar_Click(object sender, EventArgs e)
        {
            FrmEditarUsuario edU;
            MO_Usuario u = new MO_Usuario();

            if (this.GdUsuario.CurrentRow.Cells.Count > 0)
            {
                try
                {
                    u.id = int.Parse(this.GdUsuario.CurrentRow.Cells["id"].Value.ToString());
                    u.nome = (string)this.GdUsuario.CurrentRow.Cells["nome"].Value;
                    u.login = (string)this.GdUsuario.CurrentRow.Cells["login"].Value;
                    u.senha = (string)this.GdUsuario.CurrentRow.Cells["senha"].Value;

                    edU = new FrmEditarUsuario(u);
                    edU.ShowDialog(this);
                    refreshGrid();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
            else
                MessageBox.Show("Selecione uma linha!!", "Atenção");
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            FrmAddUsuario addU = new FrmAddUsuario();
            addU.ShowDialog(this);
            refreshGrid();
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            refreshGrid();
        }

        private void refreshGrid()
        {
            string[] linha = new string[4];
            try
            {
                this.GdUsuario.Rows.Clear();
                usuMO = usuBLL.pesquisar();
                foreach (MO_Usuario usu in usuMO)
                {
                    linha[0] = usu.id.ToString();
                    linha[1] = usu.nome;
                    linha[2] = usu.login;
                    linha[3] = usu.senha;

                    this.GdUsuario.Rows.Add(linha);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnExc_Click(object sender, EventArgs e)
        {
            if (this.GdUsuario.CurrentRow.Cells.Count > 0)
            {
                if (MessageBox.Show("Deseja realmente excluir o usuário? ", "Atenção!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    MO_Usuario usu = new MO_Usuario();

                    usu.id = int.Parse(this.GdUsuario.CurrentRow.Cells[0].Value.ToString());
                    usu.nome = (string)this.GdUsuario.CurrentRow.Cells[1].Value;
                    usu.login = (string)this.GdUsuario.CurrentRow.Cells[2].Value;
                    usu.senha = (string)this.GdUsuario.CurrentRow.Cells[3].Value;
                    usu.status = Status.inativo;
                    usuBLL.atualiza(usu);

                    MessageBox.Show("Usuário excluido com sucesso!!", "Atenção");
                    refreshGrid();
                }
            }
            else
                MessageBox.Show("Selecione um usuário", "Atenção!");
        }
    }
}
