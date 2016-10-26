namespace AcademSys
{
    partial class FrmMenssalidade
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenssalidade));
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.DgMens = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idUsu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnDeletar = new System.Windows.Forms.Button();
            this.BtnPesquisa = new System.Windows.Forms.Button();
            this.BtnPagar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgMens)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.panel1.Controls.Add(this.LblTitulo);
            this.panel1.Location = new System.Drawing.Point(-8, -15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(575, 97);
            this.panel1.TabIndex = 30;
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblTitulo.Location = new System.Drawing.Point(27, 48);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(260, 25);
            this.LblTitulo.TabIndex = 1;
            this.LblTitulo.Text = "Mensalidade do Cliente";
            // 
            // DgMens
            // 
            this.DgMens.AllowUserToAddRows = false;
            this.DgMens.AllowUserToDeleteRows = false;
            this.DgMens.AllowUserToOrderColumns = true;
            this.DgMens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgMens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.idUsu,
            this.idCli,
            this.valor,
            this.dataV,
            this.dataP});
            this.DgMens.Location = new System.Drawing.Point(12, 98);
            this.DgMens.Name = "DgMens";
            this.DgMens.ReadOnly = true;
            this.DgMens.Size = new System.Drawing.Size(444, 279);
            this.DgMens.TabIndex = 31;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // idUsu
            // 
            this.idUsu.HeaderText = "idUsu";
            this.idUsu.Name = "idUsu";
            this.idUsu.Visible = false;
            // 
            // idCli
            // 
            this.idCli.HeaderText = "idCli";
            this.idCli.Name = "idCli";
            this.idCli.Visible = false;
            // 
            // valor
            // 
            this.valor.HeaderText = "Valor";
            this.valor.Name = "valor";
            // 
            // dataV
            // 
            this.dataV.HeaderText = "Data de Vencimento";
            this.dataV.Name = "dataV";
            this.dataV.Width = 150;
            // 
            // dataP
            // 
            this.dataP.HeaderText = "Data Pagamento";
            this.dataP.Name = "dataP";
            this.dataP.Width = 150;
            // 
            // BtnDeletar
            // 
            this.BtnDeletar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnDeletar.BackgroundImage")));
            this.BtnDeletar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnDeletar.Location = new System.Drawing.Point(472, 267);
            this.BtnDeletar.Name = "BtnDeletar";
            this.BtnDeletar.Size = new System.Drawing.Size(80, 65);
            this.BtnDeletar.TabIndex = 34;
            this.BtnDeletar.UseVisualStyleBackColor = true;
            this.BtnDeletar.Click += new System.EventHandler(this.BtnDeletar_Click);
            // 
            // BtnPesquisa
            // 
            this.BtnPesquisa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnPesquisa.BackgroundImage")));
            this.BtnPesquisa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnPesquisa.Location = new System.Drawing.Point(472, 181);
            this.BtnPesquisa.Name = "BtnPesquisa";
            this.BtnPesquisa.Size = new System.Drawing.Size(80, 65);
            this.BtnPesquisa.TabIndex = 33;
            this.BtnPesquisa.UseVisualStyleBackColor = true;
            this.BtnPesquisa.Click += new System.EventHandler(this.BtnPesquisa_Click);
            // 
            // BtnPagar
            // 
            this.BtnPagar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnPagar.BackgroundImage")));
            this.BtnPagar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnPagar.Location = new System.Drawing.Point(472, 98);
            this.BtnPagar.Name = "BtnPagar";
            this.BtnPagar.Size = new System.Drawing.Size(80, 65);
            this.BtnPagar.TabIndex = 32;
            this.BtnPagar.UseVisualStyleBackColor = true;
            this.BtnPagar.Click += new System.EventHandler(this.BtnPagar_Click);
            // 
            // FrmMenssalidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 389);
            this.Controls.Add(this.BtnDeletar);
            this.Controls.Add(this.BtnPesquisa);
            this.Controls.Add(this.BtnPagar);
            this.Controls.Add(this.DgMens);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMenssalidade";
            this.Text = "Mensalidades";
            this.Load += new System.EventHandler(this.FrmMenssalidade_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgMens)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.DataGridView DgMens;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUsu;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCli;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataP;
        private System.Windows.Forms.Button BtnPagar;
        private System.Windows.Forms.Button BtnPesquisa;
        private System.Windows.Forms.Button BtnDeletar;
    }
}