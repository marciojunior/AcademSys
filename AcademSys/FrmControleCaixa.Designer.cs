namespace AcademSys
{
    partial class FrmControleCaixa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmControleCaixa));
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.DgReceber = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idUsu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgPagar = new System.Windows.Forms.DataGridView();
            this.idR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idUsuP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motivoP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnPesquisaP = new System.Windows.Forms.Button();
            this.BtnPesquisaR = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.BtnDeletar = new System.Windows.Forms.Button();
            this.BtnPagar = new System.Windows.Forms.Button();
            this.BtnReceber = new System.Windows.Forms.Button();
            this.LblCR = new System.Windows.Forms.Label();
            this.LblCP = new System.Windows.Forms.Label();
            this.CbmFiltros = new System.Windows.Forms.ComboBox();
            this.fp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgReceber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgPagar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.panel1.Controls.Add(this.LblTitulo);
            this.panel1.Location = new System.Drawing.Point(-2, -8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1185, 97);
            this.panel1.TabIndex = 1;
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblTitulo.Location = new System.Drawing.Point(27, 48);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(201, 25);
            this.LblTitulo.TabIndex = 1;
            this.LblTitulo.Text = "Controle de Caixa";
            // 
            // DgReceber
            // 
            this.DgReceber.AllowUserToAddRows = false;
            this.DgReceber.AllowUserToDeleteRows = false;
            this.DgReceber.AllowUserToOrderColumns = true;
            this.DgReceber.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgReceber.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.idUsu,
            this.idCli,
            this.valor,
            this.motivo,
            this.Tipo,
            this.fp});
            this.DgReceber.Location = new System.Drawing.Point(12, 124);
            this.DgReceber.Name = "DgReceber";
            this.DgReceber.ReadOnly = true;
            this.DgReceber.Size = new System.Drawing.Size(468, 337);
            this.DgReceber.TabIndex = 2;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // idUsu
            // 
            this.idUsu.HeaderText = "idUsu";
            this.idUsu.Name = "idUsu";
            this.idUsu.ReadOnly = true;
            this.idUsu.Visible = false;
            // 
            // idCli
            // 
            this.idCli.HeaderText = "idCli";
            this.idCli.Name = "idCli";
            this.idCli.ReadOnly = true;
            this.idCli.Visible = false;
            // 
            // valor
            // 
            this.valor.HeaderText = "Valor";
            this.valor.Name = "valor";
            this.valor.ReadOnly = true;
            this.valor.Width = 150;
            // 
            // motivo
            // 
            this.motivo.HeaderText = "Motivo";
            this.motivo.Name = "motivo";
            this.motivo.ReadOnly = true;
            this.motivo.Width = 300;
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            // 
            // DgPagar
            // 
            this.DgPagar.AllowUserToAddRows = false;
            this.DgPagar.AllowUserToDeleteRows = false;
            this.DgPagar.AllowUserToOrderColumns = true;
            this.DgPagar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgPagar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idR,
            this.idUsuP,
            this.pago,
            this.valorR,
            this.motivoP});
            this.DgPagar.Location = new System.Drawing.Point(603, 124);
            this.DgPagar.Name = "DgPagar";
            this.DgPagar.ReadOnly = true;
            this.DgPagar.Size = new System.Drawing.Size(468, 337);
            this.DgPagar.TabIndex = 3;
            // 
            // idR
            // 
            this.idR.HeaderText = "idR";
            this.idR.Name = "idR";
            this.idR.ReadOnly = true;
            this.idR.Visible = false;
            // 
            // idUsuP
            // 
            this.idUsuP.HeaderText = "idUsuP";
            this.idUsuP.Name = "idUsuP";
            this.idUsuP.ReadOnly = true;
            this.idUsuP.Visible = false;
            // 
            // pago
            // 
            this.pago.HeaderText = "Pago";
            this.pago.Name = "pago";
            this.pago.ReadOnly = true;
            // 
            // valorR
            // 
            this.valorR.HeaderText = "Valor";
            this.valorR.Name = "valorR";
            this.valorR.ReadOnly = true;
            this.valorR.Width = 150;
            // 
            // motivoP
            // 
            this.motivoP.HeaderText = "Motivo";
            this.motivoP.Name = "motivoP";
            this.motivoP.ReadOnly = true;
            this.motivoP.Width = 300;
            // 
            // BtnPesquisaP
            // 
            this.BtnPesquisaP.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnPesquisaP.BackgroundImage")));
            this.BtnPesquisaP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnPesquisaP.Location = new System.Drawing.Point(1088, 217);
            this.BtnPesquisaP.Name = "BtnPesquisaP";
            this.BtnPesquisaP.Size = new System.Drawing.Size(80, 65);
            this.BtnPesquisaP.TabIndex = 24;
            this.BtnPesquisaP.UseVisualStyleBackColor = true;
            this.BtnPesquisaP.Click += new System.EventHandler(this.BtnPesquisaP_Click);
            // 
            // BtnPesquisaR
            // 
            this.BtnPesquisaR.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnPesquisaR.BackgroundImage")));
            this.BtnPesquisaR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnPesquisaR.Location = new System.Drawing.Point(500, 217);
            this.BtnPesquisaR.Name = "BtnPesquisaR";
            this.BtnPesquisaR.Size = new System.Drawing.Size(80, 65);
            this.BtnPesquisaR.TabIndex = 22;
            this.BtnPesquisaR.UseVisualStyleBackColor = true;
            this.BtnPesquisaR.Click += new System.EventHandler(this.BtnPesquisaR_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnClose.BackgroundImage")));
            this.BtnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnClose.Location = new System.Drawing.Point(1088, 311);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(80, 65);
            this.BtnClose.TabIndex = 12;
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnDeletar
            // 
            this.BtnDeletar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnDeletar.BackgroundImage")));
            this.BtnDeletar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnDeletar.Location = new System.Drawing.Point(500, 311);
            this.BtnDeletar.Name = "BtnDeletar";
            this.BtnDeletar.Size = new System.Drawing.Size(80, 65);
            this.BtnDeletar.TabIndex = 11;
            this.BtnDeletar.UseVisualStyleBackColor = true;
            this.BtnDeletar.Click += new System.EventHandler(this.BtnDeletar_Click);
            // 
            // BtnPagar
            // 
            this.BtnPagar.BackgroundImage = global::AcademSys.Properties.Resources.Arrow_red_48;
            this.BtnPagar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnPagar.Location = new System.Drawing.Point(1088, 124);
            this.BtnPagar.Name = "BtnPagar";
            this.BtnPagar.Size = new System.Drawing.Size(75, 67);
            this.BtnPagar.TabIndex = 5;
            this.BtnPagar.UseVisualStyleBackColor = true;
            this.BtnPagar.Click += new System.EventHandler(this.BtnPagar_Click);
            // 
            // BtnReceber
            // 
            this.BtnReceber.BackgroundImage = global::AcademSys.Properties.Resources.Arrow_green_48;
            this.BtnReceber.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnReceber.Location = new System.Drawing.Point(500, 124);
            this.BtnReceber.Name = "BtnReceber";
            this.BtnReceber.Size = new System.Drawing.Size(75, 67);
            this.BtnReceber.TabIndex = 4;
            this.BtnReceber.UseVisualStyleBackColor = true;
            this.BtnReceber.Click += new System.EventHandler(this.BtnReceber_Click);
            // 
            // LblCR
            // 
            this.LblCR.AutoSize = true;
            this.LblCR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCR.Location = new System.Drawing.Point(139, 484);
            this.LblCR.Name = "LblCR";
            this.LblCR.Size = new System.Drawing.Size(64, 20);
            this.LblCR.TabIndex = 25;
            this.LblCR.Text = "Total:    ";
            // 
            // LblCP
            // 
            this.LblCP.AutoSize = true;
            this.LblCP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCP.Location = new System.Drawing.Point(743, 484);
            this.LblCP.Name = "LblCP";
            this.LblCP.Size = new System.Drawing.Size(64, 20);
            this.LblCP.TabIndex = 26;
            this.LblCP.Text = "Total:    ";
            // 
            // CbmFiltros
            // 
            this.CbmFiltros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbmFiltros.FormattingEnabled = true;
            this.CbmFiltros.Items.AddRange(new object[] {
            "Todos",
            "Mensalidades",
            "Contas a Pagar"});
            this.CbmFiltros.Location = new System.Drawing.Point(12, 97);
            this.CbmFiltros.Name = "CbmFiltros";
            this.CbmFiltros.Size = new System.Drawing.Size(191, 21);
            this.CbmFiltros.TabIndex = 27;
            this.CbmFiltros.SelectedIndexChanged += new System.EventHandler(this.CbmFiltros_SelectedIndexChanged);
            // 
            // fp
            // 
            this.fp.HeaderText = "fp";
            this.fp.Name = "fp";
            this.fp.ReadOnly = true;
            this.fp.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 484);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 28;
            this.label1.Text = "Total:    ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(599, 484);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 29;
            this.label2.Text = "Total:    ";
            // 
            // FrmControleCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 517);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CbmFiltros);
            this.Controls.Add(this.LblCP);
            this.Controls.Add(this.LblCR);
            this.Controls.Add(this.BtnPesquisaP);
            this.Controls.Add(this.BtnPesquisaR);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnDeletar);
            this.Controls.Add(this.BtnPagar);
            this.Controls.Add(this.BtnReceber);
            this.Controls.Add(this.DgPagar);
            this.Controls.Add(this.DgReceber);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmControleCaixa";
            this.Text = "Controle de Caixa";
            this.Load += new System.EventHandler(this.FrmControleCaixa_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgReceber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgPagar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.DataGridView DgReceber;
        private System.Windows.Forms.DataGridView DgPagar;
        private System.Windows.Forms.Button BtnReceber;
        private System.Windows.Forms.Button BtnPagar;
        private System.Windows.Forms.Button BtnDeletar;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUsu;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCli;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn motivo;
        private System.Windows.Forms.Button BtnPesquisaR;
        private System.Windows.Forms.Button BtnPesquisaP;
        private System.Windows.Forms.DataGridViewTextBoxColumn idR;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUsuP;
        private System.Windows.Forms.DataGridViewTextBoxColumn pago;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorR;
        private System.Windows.Forms.DataGridViewTextBoxColumn motivoP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.Label LblCR;
        private System.Windows.Forms.Label LblCP;
        private System.Windows.Forms.ComboBox CbmFiltros;
        private System.Windows.Forms.DataGridViewTextBoxColumn fp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}