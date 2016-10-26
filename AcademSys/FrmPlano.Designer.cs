namespace AcademSys
{
    partial class FrmPlano
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPlano));
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.DGPlanos = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idUsu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtdAulas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExc = new System.Windows.Forms.Button();
            this.BtnAdicionar = new System.Windows.Forms.Button();
            this.BtnPesquisa = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGPlanos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.panel1.Controls.Add(this.LblTitulo);
            this.panel1.Location = new System.Drawing.Point(-6, -15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(558, 97);
            this.panel1.TabIndex = 23;
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblTitulo.Location = new System.Drawing.Point(28, 44);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(213, 25);
            this.LblTitulo.TabIndex = 1;
            this.LblTitulo.Text = "Controle de Planos";
            // 
            // DGPlanos
            // 
            this.DGPlanos.AllowUserToAddRows = false;
            this.DGPlanos.AllowUserToDeleteRows = false;
            this.DGPlanos.AllowUserToOrderColumns = true;
            this.DGPlanos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGPlanos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.idUsu,
            this.nome,
            this.valor,
            this.qtdAulas});
            this.DGPlanos.Location = new System.Drawing.Point(12, 88);
            this.DGPlanos.Name = "DGPlanos";
            this.DGPlanos.ReadOnly = true;
            this.DGPlanos.Size = new System.Drawing.Size(429, 284);
            this.DGPlanos.TabIndex = 24;
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
            // nome
            // 
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            this.nome.Width = 200;
            // 
            // valor
            // 
            this.valor.HeaderText = "Valor";
            this.valor.Name = "valor";
            this.valor.ReadOnly = true;
            // 
            // qtdAulas
            // 
            this.qtdAulas.HeaderText = "Quantidade de Aulas";
            this.qtdAulas.Name = "qtdAulas";
            this.qtdAulas.ReadOnly = true;
            // 
            // btnExc
            // 
            this.btnExc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExc.BackgroundImage")));
            this.btnExc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExc.Location = new System.Drawing.Point(447, 234);
            this.btnExc.Name = "btnExc";
            this.btnExc.Size = new System.Drawing.Size(80, 65);
            this.btnExc.TabIndex = 31;
            this.btnExc.UseVisualStyleBackColor = true;
            this.btnExc.Click += new System.EventHandler(this.btnExc_Click);
            // 
            // BtnAdicionar
            // 
            this.BtnAdicionar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnAdicionar.BackgroundImage")));
            this.BtnAdicionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnAdicionar.Location = new System.Drawing.Point(447, 88);
            this.BtnAdicionar.Name = "BtnAdicionar";
            this.BtnAdicionar.Size = new System.Drawing.Size(80, 65);
            this.BtnAdicionar.TabIndex = 30;
            this.BtnAdicionar.UseVisualStyleBackColor = true;
            this.BtnAdicionar.Click += new System.EventHandler(this.BtnAdicionar_Click);
            // 
            // BtnPesquisa
            // 
            this.BtnPesquisa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnPesquisa.BackgroundImage")));
            this.BtnPesquisa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnPesquisa.Location = new System.Drawing.Point(447, 161);
            this.BtnPesquisa.Name = "BtnPesquisa";
            this.BtnPesquisa.Size = new System.Drawing.Size(80, 65);
            this.BtnPesquisa.TabIndex = 29;
            this.BtnPesquisa.UseVisualStyleBackColor = true;
            this.BtnPesquisa.Click += new System.EventHandler(this.BtnPesquisa_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnCancelar.BackgroundImage")));
            this.BtnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnCancelar.Location = new System.Drawing.Point(447, 307);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(80, 65);
            this.BtnCancelar.TabIndex = 28;
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // FrmPlano
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 380);
            this.Controls.Add(this.btnExc);
            this.Controls.Add(this.BtnAdicionar);
            this.Controls.Add(this.BtnPesquisa);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.DGPlanos);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmPlano";
            this.Text = "Planos";
            this.Load += new System.EventHandler(this.FrmPlano_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGPlanos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.DataGridView DGPlanos;
        private System.Windows.Forms.Button btnExc;
        private System.Windows.Forms.Button BtnAdicionar;
        private System.Windows.Forms.Button BtnPesquisa;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUsu;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtdAulas;
    }
}