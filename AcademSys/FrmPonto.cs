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
    public partial class FrmPonto : Form
    {
        public FrmPonto()
        {
            InitializeComponent();
        }

        private void FrmPonto_Load(object sender, EventArgs e)
        {
            try
            {
                BLL_Ponto pBLL = new BLL_Ponto();
                List<MO_Ponto> lP = new List<MO_Ponto>();
                string[] row = new string[4];

                lP = pBLL.buscaTodosU((int)Program.userLogado.id);
                foreach (MO_Ponto p in lP)
                {
                    row[0] = p.dataEntrada.ToString("dd/MM/yyyy");
                    row[1] = p.hrEntrada.ToString("HH:mm:ss");
                    row[2] = p.dataSaida != DateTime.MinValue ? p.dataSaida.ToString("dd/MM/yyyy") : "";
                    row[3] = p.hrSaida != DateTime.MinValue ? p.hrSaida.ToString("HH:mm:ss") : "";

                    this.DGP.Rows.Add(row);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
