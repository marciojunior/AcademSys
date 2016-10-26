namespace AcademSys
{
    partial class FrmAvaliacoes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAvaliacoes));
            this.LblTitulo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DgAva = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idUsu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnAdicionar = new System.Windows.Forms.Button();
            this.BtnPesquisa = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.btnExc = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgAva)).BeginInit();
            this.SuspendLayout();
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblTitulo.Location = new System.Drawing.Point(28, 44);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(297, 25);
            this.LblTitulo.TabIndex = 1;
            this.LblTitulo.Text = "Controle de Agendamentos";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.panel1.Controls.Add(this.LblTitulo);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(583, 97);
            this.panel1.TabIndex = 10;
            // 
            // DgAva
            // 
            this.DgAva.AllowUserToAddRows = false;
            this.DgAva.AllowUserToDeleteRows = false;
            this.DgAva.AllowUserToOrderColumns = true;
            this.DgAva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgAva.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.idCli,
            this.idUsu,
            this.data,
            this.hora});
            this.DgAva.Location = new System.Drawing.Point(12, 113);
            this.DgAva.Name = "DgAva";
            this.DgAva.ReadOnly = true;
            this.DgAva.Size = new System.Drawing.Size(444, 308);
            this.DgAva.TabIndex = 11;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // idCli
            // 
            this.idCli.HeaderText = "idCli";
            this.idCli.Name = "idCli";
            this.idCli.ReadOnly = true;
            this.idCli.Visible = false;
            // 
            // idUsu
            // 
            this.idUsu.HeaderText = "idUsu";
            this.idUsu.Name = "idUsu";
            this.idUsu.ReadOnly = true;
            this.idUsu.Visible = false;
            // 
            // data
            // 
            this.data.HeaderText = "Data";
            this.data.Name = "data";
            this.data.ReadOnly = true;
            this.data.Width = 200;
            // 
            // hora
            // 
            this.hora.HeaderText = "Hora";
            this.hora.Name = "hora";
            this.hora.ReadOnly = true;
            this.hora.Width = 200;
            // 
            // BtnAdicionar
            // 
            this.BtnAdicionar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnAdicionar.BackgroundImage")));
            this.BtnAdicionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnAdicionar.Location = new System.Drawing.Point(483, 112);
            this.BtnAdicionar.Name = "BtnAdicionar";
            this.BtnAdicionar.Size = new System.Drawing.Size(80, 65);
            this.BtnAdicionar.TabIndex = 20;
            this.BtnAdicionar.UseVisualStyleBackColor = true;
            this.BtnAdicionar.Click += new System.EventHandler(this.BtnAdicionar_Click);
            // 
            // BtnPesquisa
            // 
            this.BtnPesquisa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnPesquisa.BackgroundImage")));
            this.BtnPesquisa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnPesquisa.Location = new System.Drawing.Point(483, 194);
            this.BtnPesquisa.Name = "BtnPesquisa";
            this.BtnPesquisa.Size = new System.Drawing.Size(80, 65);
            this.BtnPesquisa.TabIndex = 19;
            this.BtnPesquisa.UseVisualStyleBackColor = true;
            this.BtnPesquisa.Click += new System.EventHandler(this.BtnPesquisa_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnCancelar.BackgroundImage")));
            this.BtnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnCancelar.Location = new System.Drawing.Point(484, 356);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(80, 65);
            this.BtnCancelar.TabIndex = 18;
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // btnExc
            // 
            this.btnExc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExc.BackgroundImage")));
            this.btnExc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExc.Location = new System.Drawing.Point(483, 274);
            this.btnExc.Name = "btnExc";
            this.btnExc.Size = new System.Drawing.Size(80, 65);
            this.btnExc.TabIndex = 21;
            this.btnExc.UseVisualStyleBackColor = true;
            this.btnExc.Click += new System.EventHandler(this.btnExc_Click);
            // 
            // FrmAvaliacoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 433);
            this.Controls.Add(this.btnExc);
            this.Controls.Add(this.BtnAdicionar);
            this.Controls.Add(this.BtnPesquisa);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.DgAva);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAvaliacoes";
            this.Text = "Avaliações";
            this.Load += new System.EventHandler(this.FrmAvaliacoes_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgAva)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView DgAva;
        private System.Windows.Forms.Button BtnAdicionar;
        private System.Windows.Forms.Button BtnPesquisa;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button btnExc;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCli;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUsu;
        private System.Windows.Forms.DataGridViewTextBoxColumn data;
        private System.Windows.Forms.DataGridViewTextBoxColumn hora;
    }
}