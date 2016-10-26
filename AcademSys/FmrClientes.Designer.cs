namespace AcademSys
{
    partial class FmrClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmrClientes));
            this.BtnDeletar = new System.Windows.Forms.Button();
            this.BtnAdicionar = new System.Windows.Forms.Button();
            this.GdUsuario = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.BtnPagar = new System.Windows.Forms.Button();
            this.BtnPesquisa = new System.Windows.Forms.Button();
            this.btnExc = new System.Windows.Forms.Button();
            this.TxtPesq = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idUsu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.identidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ufIdentidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataNasc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.devendo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GdUsuario)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnDeletar
            // 
            this.BtnDeletar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnDeletar.BackgroundImage")));
            this.BtnDeletar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnDeletar.Location = new System.Drawing.Point(950, 485);
            this.BtnDeletar.Name = "BtnDeletar";
            this.BtnDeletar.Size = new System.Drawing.Size(80, 65);
            this.BtnDeletar.TabIndex = 10;
            this.BtnDeletar.UseVisualStyleBackColor = true;
            this.BtnDeletar.Click += new System.EventHandler(this.BtnDeletar_Click);
            // 
            // BtnAdicionar
            // 
            this.BtnAdicionar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnAdicionar.BackgroundImage")));
            this.BtnAdicionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnAdicionar.Location = new System.Drawing.Point(549, 485);
            this.BtnAdicionar.Name = "BtnAdicionar";
            this.BtnAdicionar.Size = new System.Drawing.Size(80, 65);
            this.BtnAdicionar.TabIndex = 8;
            this.BtnAdicionar.UseVisualStyleBackColor = true;
            this.BtnAdicionar.Click += new System.EventHandler(this.BtnAdicionar_Click);
            // 
            // GdUsuario
            // 
            this.GdUsuario.AllowUserToAddRows = false;
            this.GdUsuario.AllowUserToDeleteRows = false;
            this.GdUsuario.AllowUserToOrderColumns = true;
            this.GdUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GdUsuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.idUsu,
            this.matricula,
            this.nome,
            this.sexo,
            this.tel,
            this.cel,
            this.cpf,
            this.identidade,
            this.ufIdentidade,
            this.email,
            this.dataNasc,
            this.status,
            this.devendo});
            this.GdUsuario.Location = new System.Drawing.Point(13, 96);
            this.GdUsuario.Name = "GdUsuario";
            this.GdUsuario.ReadOnly = true;
            this.GdUsuario.Size = new System.Drawing.Size(1032, 367);
            this.GdUsuario.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.panel1.Controls.Add(this.LblTitulo);
            this.panel1.Location = new System.Drawing.Point(1, -23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1069, 109);
            this.panel1.TabIndex = 6;
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblTitulo.Location = new System.Drawing.Point(27, 48);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(227, 25);
            this.LblTitulo.TabIndex = 1;
            this.LblTitulo.Text = "Controle de Clientes";
            // 
            // BtnPagar
            // 
            this.BtnPagar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnPagar.BackgroundImage")));
            this.BtnPagar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnPagar.Location = new System.Drawing.Point(750, 485);
            this.BtnPagar.Name = "BtnPagar";
            this.BtnPagar.Size = new System.Drawing.Size(80, 65);
            this.BtnPagar.TabIndex = 11;
            this.BtnPagar.UseVisualStyleBackColor = true;
            this.BtnPagar.Click += new System.EventHandler(this.BtnPagar_Click);
            // 
            // BtnPesquisa
            // 
            this.BtnPesquisa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnPesquisa.BackgroundImage")));
            this.BtnPesquisa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnPesquisa.Location = new System.Drawing.Point(648, 485);
            this.BtnPesquisa.Name = "BtnPesquisa";
            this.BtnPesquisa.Size = new System.Drawing.Size(80, 65);
            this.BtnPesquisa.TabIndex = 12;
            this.BtnPesquisa.UseVisualStyleBackColor = true;
            this.BtnPesquisa.Click += new System.EventHandler(this.BtnPesquisa_Click);
            // 
            // btnExc
            // 
            this.btnExc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExc.BackgroundImage")));
            this.btnExc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExc.Location = new System.Drawing.Point(852, 485);
            this.btnExc.Name = "btnExc";
            this.btnExc.Size = new System.Drawing.Size(80, 65);
            this.btnExc.TabIndex = 13;
            this.btnExc.UseVisualStyleBackColor = true;
            this.btnExc.Click += new System.EventHandler(this.btnExc_Click);
            // 
            // TxtPesq
            // 
            this.TxtPesq.Location = new System.Drawing.Point(33, 498);
            this.TxtPesq.Multiline = true;
            this.TxtPesq.Name = "TxtPesq";
            this.TxtPesq.Size = new System.Drawing.Size(381, 45);
            this.TxtPesq.TabIndex = 14;
            this.TxtPesq.TextChanged += new System.EventHandler(this.TxtPesq_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 466);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Pesquisa rápida(Nome): ";
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
            // matricula
            // 
            this.matricula.HeaderText = "Matricula";
            this.matricula.Name = "matricula";
            this.matricula.ReadOnly = true;
            // 
            // nome
            // 
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            this.nome.Width = 200;
            // 
            // sexo
            // 
            this.sexo.HeaderText = "Sexo";
            this.sexo.Name = "sexo";
            this.sexo.ReadOnly = true;
            // 
            // tel
            // 
            this.tel.HeaderText = "Telefone";
            this.tel.Name = "tel";
            this.tel.ReadOnly = true;
            // 
            // cel
            // 
            this.cel.HeaderText = "Celular";
            this.cel.Name = "cel";
            this.cel.ReadOnly = true;
            // 
            // cpf
            // 
            this.cpf.HeaderText = "cpf";
            this.cpf.Name = "cpf";
            this.cpf.ReadOnly = true;
            this.cpf.Visible = false;
            // 
            // identidade
            // 
            this.identidade.HeaderText = "identidade";
            this.identidade.Name = "identidade";
            this.identidade.ReadOnly = true;
            this.identidade.Visible = false;
            // 
            // ufIdentidade
            // 
            this.ufIdentidade.HeaderText = "ufIdentidade";
            this.ufIdentidade.Name = "ufIdentidade";
            this.ufIdentidade.ReadOnly = true;
            this.ufIdentidade.Visible = false;
            // 
            // email
            // 
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.Width = 200;
            // 
            // dataNasc
            // 
            this.dataNasc.HeaderText = "Data de Nascimento";
            this.dataNasc.Name = "dataNasc";
            this.dataNasc.ReadOnly = true;
            // 
            // status
            // 
            this.status.HeaderText = "status";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            this.status.Visible = false;
            // 
            // devendo
            // 
            this.devendo.HeaderText = "Mensalidades";
            this.devendo.Name = "devendo";
            this.devendo.ReadOnly = true;
            this.devendo.Width = 150;
            // 
            // FmrClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 565);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtPesq);
            this.Controls.Add(this.btnExc);
            this.Controls.Add(this.BtnPesquisa);
            this.Controls.Add(this.BtnPagar);
            this.Controls.Add(this.BtnDeletar);
            this.Controls.Add(this.BtnAdicionar);
            this.Controls.Add(this.GdUsuario);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FmrClientes";
            this.Text = "AcademSys - Clientes";
            this.Load += new System.EventHandler(this.FmrClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GdUsuario)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnDeletar;
        private System.Windows.Forms.Button BtnAdicionar;
        private System.Windows.Forms.DataGridView GdUsuario;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Button BtnPagar;
        private System.Windows.Forms.Button BtnPesquisa;
        private System.Windows.Forms.Button btnExc;
        private System.Windows.Forms.TextBox TxtPesq;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUsu;
        private System.Windows.Forms.DataGridViewTextBoxColumn matricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn cel;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn identidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn ufIdentidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataNasc;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn devendo;
    }
}