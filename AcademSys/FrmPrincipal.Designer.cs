namespace AcademSys
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.TSLPonto = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TSLSobre = new System.Windows.Forms.ToolStripLabel();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnAvaliacao = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnSair = new System.Windows.Forms.Button();
            this.BtnTurmas = new System.Windows.Forms.Button();
            this.BtnCliente = new System.Windows.Forms.Button();
            this.BtnCaixa = new System.Windows.Forms.Button();
            this.BtnAgenda = new System.Windows.Forms.Button();
            this.BtnUsuario = new System.Windows.Forms.Button();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.TLNome = new System.Windows.Forms.ToolStripStatusLabel();
            this.DgAgenda = new System.Windows.Forms.DataGridView();
            this.titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.DgAva = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnPlanos = new System.Windows.Forms.Button();
            this.lbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgAgenda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgAva)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.panel1.Controls.Add(this.lbl);
            this.panel1.Controls.Add(this.BtnPlanos);
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.BtnAvaliacao);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.BtnSair);
            this.panel1.Controls.Add(this.BtnTurmas);
            this.panel1.Controls.Add(this.BtnCliente);
            this.panel1.Controls.Add(this.BtnCaixa);
            this.panel1.Controls.Add(this.BtnAgenda);
            this.panel1.Controls.Add(this.BtnUsuario);
            this.panel1.Controls.Add(this.LblTitulo);
            this.panel1.Location = new System.Drawing.Point(0, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1471, 243);
            this.panel1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSLPonto,
            this.toolStripSeparator1,
            this.TSLSobre});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1471, 25);
            this.toolStrip1.TabIndex = 15;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // TSLPonto
            // 
            this.TSLPonto.Name = "TSLPonto";
            this.TSLPonto.Size = new System.Drawing.Size(39, 22);
            this.TSLPonto.Text = "Ponto";
            this.TSLPonto.Click += new System.EventHandler(this.TSLPonto_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // TSLSobre
            // 
            this.TSLSobre.Name = "TSLSobre";
            this.TSLSobre.Size = new System.Drawing.Size(37, 22);
            this.TSLSobre.Text = "Sobre";
            this.TSLSobre.Click += new System.EventHandler(this.TSLSobre_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(876, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Avaliação";
            // 
            // BtnAvaliacao
            // 
            this.BtnAvaliacao.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnAvaliacao.BackgroundImage")));
            this.BtnAvaliacao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnAvaliacao.Location = new System.Drawing.Point(852, 104);
            this.BtnAvaliacao.Name = "BtnAvaliacao";
            this.BtnAvaliacao.Size = new System.Drawing.Size(122, 84);
            this.BtnAvaliacao.TabIndex = 13;
            this.BtnAvaliacao.UseVisualStyleBackColor = true;
            this.BtnAvaliacao.Click += new System.EventHandler(this.BtnAvaliacao_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(1206, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Sair";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(714, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Turmas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(546, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Clientes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(347, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Controle de Caixa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(212, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Agenda";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(38, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Usuários";
            // 
            // BtnSair
            // 
            this.BtnSair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnSair.BackgroundImage")));
            this.BtnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnSair.Location = new System.Drawing.Point(1160, 104);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(122, 84);
            this.BtnSair.TabIndex = 6;
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // BtnTurmas
            // 
            this.BtnTurmas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnTurmas.BackgroundImage")));
            this.BtnTurmas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnTurmas.Location = new System.Drawing.Point(685, 104);
            this.BtnTurmas.Name = "BtnTurmas";
            this.BtnTurmas.Size = new System.Drawing.Size(122, 84);
            this.BtnTurmas.TabIndex = 5;
            this.BtnTurmas.UseVisualStyleBackColor = true;
            this.BtnTurmas.Click += new System.EventHandler(this.BtnTurmas_Click);
            // 
            // BtnCliente
            // 
            this.BtnCliente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnCliente.BackgroundImage")));
            this.BtnCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnCliente.Location = new System.Drawing.Point(518, 104);
            this.BtnCliente.Name = "BtnCliente";
            this.BtnCliente.Size = new System.Drawing.Size(122, 84);
            this.BtnCliente.TabIndex = 4;
            this.BtnCliente.UseVisualStyleBackColor = true;
            this.BtnCliente.Click += new System.EventHandler(this.BtnCliente_Click);
            // 
            // BtnCaixa
            // 
            this.BtnCaixa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnCaixa.BackgroundImage")));
            this.BtnCaixa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnCaixa.Location = new System.Drawing.Point(351, 104);
            this.BtnCaixa.Name = "BtnCaixa";
            this.BtnCaixa.Size = new System.Drawing.Size(122, 84);
            this.BtnCaixa.TabIndex = 3;
            this.BtnCaixa.UseVisualStyleBackColor = true;
            this.BtnCaixa.Click += new System.EventHandler(this.BtnCaixa_Click);
            // 
            // BtnAgenda
            // 
            this.BtnAgenda.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnAgenda.BackgroundImage")));
            this.BtnAgenda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnAgenda.Location = new System.Drawing.Point(184, 104);
            this.BtnAgenda.Name = "BtnAgenda";
            this.BtnAgenda.Size = new System.Drawing.Size(122, 84);
            this.BtnAgenda.TabIndex = 2;
            this.BtnAgenda.UseVisualStyleBackColor = true;
            this.BtnAgenda.Click += new System.EventHandler(this.BtnAgenda_Click);
            // 
            // BtnUsuario
            // 
            this.BtnUsuario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnUsuario.BackgroundImage")));
            this.BtnUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnUsuario.Location = new System.Drawing.Point(17, 104);
            this.BtnUsuario.Name = "BtnUsuario";
            this.BtnUsuario.Size = new System.Drawing.Size(122, 84);
            this.BtnUsuario.TabIndex = 1;
            this.BtnUsuario.UseVisualStyleBackColor = true;
            this.BtnUsuario.Click += new System.EventHandler(this.BtnUsuario_Click);
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblTitulo.Location = new System.Drawing.Point(37, 43);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(390, 25);
            this.LblTitulo.TabIndex = 0;
            this.LblTitulo.Text = "SEJA BEM VINDO AO ACADEMSYS";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TLNome});
            this.statusStrip1.Location = new System.Drawing.Point(0, 704);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1294, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // TLNome
            // 
            this.TLNome.Name = "TLNome";
            this.TLNome.Size = new System.Drawing.Size(95, 17);
            this.TLNome.Text = "Nome da pessoa";
            // 
            // DgAgenda
            // 
            this.DgAgenda.AllowUserToAddRows = false;
            this.DgAgenda.AllowUserToDeleteRows = false;
            this.DgAgenda.AllowUserToOrderColumns = true;
            this.DgAgenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgAgenda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titulo,
            this.descricao});
            this.DgAgenda.Location = new System.Drawing.Point(665, 281);
            this.DgAgenda.Name = "DgAgenda";
            this.DgAgenda.ReadOnly = true;
            this.DgAgenda.Size = new System.Drawing.Size(602, 176);
            this.DgAgenda.TabIndex = 2;
            // 
            // titulo
            // 
            this.titulo.HeaderText = "Titulo";
            this.titulo.Name = "titulo";
            this.titulo.ReadOnly = true;
            this.titulo.Width = 200;
            // 
            // descricao
            // 
            this.descricao.HeaderText = "Descrição";
            this.descricao.Name = "descricao";
            this.descricao.ReadOnly = true;
            this.descricao.Width = 400;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(675, 253);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(202, 25);
            this.label8.TabIndex = 3;
            this.label8.Text = "Lembretes de hoje: ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(52, 267);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(512, 375);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(675, 467);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(206, 25);
            this.label9.TabIndex = 5;
            this.label9.Text = "Avaliações de hoje: ";
            // 
            // DgAva
            // 
            this.DgAva.AllowUserToAddRows = false;
            this.DgAva.AllowUserToDeleteRows = false;
            this.DgAva.AllowUserToOrderColumns = true;
            this.DgAva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgAva.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.DgAva.Location = new System.Drawing.Point(665, 495);
            this.DgAva.Name = "DgAva";
            this.DgAva.ReadOnly = true;
            this.DgAva.Size = new System.Drawing.Size(602, 171);
            this.DgAva.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Cliente";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 470;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Hora";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // BtnPlanos
            // 
            this.BtnPlanos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnPlanos.BackgroundImage")));
            this.BtnPlanos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnPlanos.Location = new System.Drawing.Point(1005, 104);
            this.BtnPlanos.Name = "BtnPlanos";
            this.BtnPlanos.Size = new System.Drawing.Size(122, 84);
            this.BtnPlanos.TabIndex = 16;
            this.BtnPlanos.UseVisualStyleBackColor = true;
            this.BtnPlanos.Click += new System.EventHandler(this.BtnPlanos_Click);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl.Location = new System.Drawing.Point(1039, 204);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(57, 20);
            this.lbl.TabIndex = 17;
            this.lbl.Text = "Planos";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1294, 726);
            this.Controls.Add(this.DgAva);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.DgAgenda);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPrincipal";
            this.Text = "Principal - AcademSys";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgAgenda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgAva)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.Button BtnTurmas;
        private System.Windows.Forms.Button BtnCliente;
        private System.Windows.Forms.Button BtnCaixa;
        private System.Windows.Forms.Button BtnAgenda;
        private System.Windows.Forms.Button BtnUsuario;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel TLNome;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtnAvaliacao;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel TSLPonto;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel TSLSobre;
        private System.Windows.Forms.DataGridView DgAgenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView DgAva;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Button BtnPlanos;
    }
}