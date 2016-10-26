namespace AcademSys
{
    partial class FrmVisualizarTurma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVisualizarTurma));
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.LblNome = new System.Windows.Forms.Label();
            this.LblLocal = new System.Windows.Forms.Label();
            this.LblSexo = new System.Windows.Forms.Label();
            this.LblMax = new System.Windows.Forms.Label();
            this.DgAlunos = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExc = new System.Windows.Forms.Button();
            this.BtnDeletar = new System.Windows.Forms.Button();
            this.BtnAtualizar = new System.Windows.Forms.Button();
            this.BtnAdicionar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgAlunos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.panel1.Controls.Add(this.LblTitulo);
            this.panel1.Location = new System.Drawing.Point(-9, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(728, 97);
            this.panel1.TabIndex = 23;
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblTitulo.Location = new System.Drawing.Point(28, 44);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(219, 25);
            this.LblTitulo.TabIndex = 1;
            this.LblTitulo.Text = "Controle de Turmas";
            // 
            // LblNome
            // 
            this.LblNome.AutoSize = true;
            this.LblNome.Location = new System.Drawing.Point(21, 116);
            this.LblNome.Name = "LblNome";
            this.LblNome.Size = new System.Drawing.Size(35, 13);
            this.LblNome.TabIndex = 24;
            this.LblNome.Text = "label1";
            // 
            // LblLocal
            // 
            this.LblLocal.AutoSize = true;
            this.LblLocal.Location = new System.Drawing.Point(356, 116);
            this.LblLocal.Name = "LblLocal";
            this.LblLocal.Size = new System.Drawing.Size(35, 13);
            this.LblLocal.TabIndex = 25;
            this.LblLocal.Text = "label2";
            // 
            // LblSexo
            // 
            this.LblSexo.AutoSize = true;
            this.LblSexo.Location = new System.Drawing.Point(21, 140);
            this.LblSexo.Name = "LblSexo";
            this.LblSexo.Size = new System.Drawing.Size(35, 13);
            this.LblSexo.TabIndex = 26;
            this.LblSexo.Text = "label3";
            // 
            // LblMax
            // 
            this.LblMax.AutoSize = true;
            this.LblMax.Location = new System.Drawing.Point(356, 140);
            this.LblMax.Name = "LblMax";
            this.LblMax.Size = new System.Drawing.Size(35, 13);
            this.LblMax.TabIndex = 27;
            this.LblMax.Text = "label4";
            // 
            // DgAlunos
            // 
            this.DgAlunos.AllowUserToAddRows = false;
            this.DgAlunos.AllowUserToDeleteRows = false;
            this.DgAlunos.AllowUserToOrderColumns = true;
            this.DgAlunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgAlunos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.matricula,
            this.nome});
            this.DgAlunos.Location = new System.Drawing.Point(12, 166);
            this.DgAlunos.Name = "DgAlunos";
            this.DgAlunos.ReadOnly = true;
            this.DgAlunos.Size = new System.Drawing.Size(545, 227);
            this.DgAlunos.TabIndex = 28;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // matricula
            // 
            this.matricula.HeaderText = "Matrícula";
            this.matricula.Name = "matricula";
            this.matricula.ReadOnly = true;
            this.matricula.Width = 150;
            // 
            // nome
            // 
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            this.nome.Width = 350;
            // 
            // btnExc
            // 
            this.btnExc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExc.BackgroundImage")));
            this.btnExc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExc.Location = new System.Drawing.Point(575, 257);
            this.btnExc.Name = "btnExc";
            this.btnExc.Size = new System.Drawing.Size(80, 65);
            this.btnExc.TabIndex = 32;
            this.btnExc.UseVisualStyleBackColor = true;
            this.btnExc.Click += new System.EventHandler(this.btnExc_Click);
            // 
            // BtnDeletar
            // 
            this.BtnDeletar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnDeletar.BackgroundImage")));
            this.BtnDeletar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnDeletar.Location = new System.Drawing.Point(575, 328);
            this.BtnDeletar.Name = "BtnDeletar";
            this.BtnDeletar.Size = new System.Drawing.Size(80, 65);
            this.BtnDeletar.TabIndex = 31;
            this.BtnDeletar.UseVisualStyleBackColor = true;
            this.BtnDeletar.Click += new System.EventHandler(this.BtnDeletar_Click);
            // 
            // BtnAtualizar
            // 
            this.BtnAtualizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnAtualizar.BackgroundImage")));
            this.BtnAtualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnAtualizar.Location = new System.Drawing.Point(575, 186);
            this.BtnAtualizar.Name = "BtnAtualizar";
            this.BtnAtualizar.Size = new System.Drawing.Size(80, 65);
            this.BtnAtualizar.TabIndex = 30;
            this.BtnAtualizar.UseVisualStyleBackColor = true;
            this.BtnAtualizar.Click += new System.EventHandler(this.BtnAtualizar_Click);
            // 
            // BtnAdicionar
            // 
            this.BtnAdicionar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnAdicionar.BackgroundImage")));
            this.BtnAdicionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnAdicionar.Location = new System.Drawing.Point(575, 114);
            this.BtnAdicionar.Name = "BtnAdicionar";
            this.BtnAdicionar.Size = new System.Drawing.Size(80, 65);
            this.BtnAdicionar.TabIndex = 29;
            this.BtnAdicionar.UseVisualStyleBackColor = true;
            this.BtnAdicionar.Click += new System.EventHandler(this.BtnAdicionar_Click);
            // 
            // FrmVisualizarTurma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 404);
            this.Controls.Add(this.btnExc);
            this.Controls.Add(this.BtnDeletar);
            this.Controls.Add(this.BtnAtualizar);
            this.Controls.Add(this.BtnAdicionar);
            this.Controls.Add(this.DgAlunos);
            this.Controls.Add(this.LblMax);
            this.Controls.Add(this.LblSexo);
            this.Controls.Add(this.LblLocal);
            this.Controls.Add(this.LblNome);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmVisualizarTurma";
            this.Text = "Visualizar Turma";
            this.Load += new System.EventHandler(this.FrmVisualizarTurma_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgAlunos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Label LblNome;
        private System.Windows.Forms.Label LblLocal;
        private System.Windows.Forms.Label LblSexo;
        private System.Windows.Forms.Label LblMax;
        private System.Windows.Forms.DataGridView DgAlunos;
        private System.Windows.Forms.Button btnExc;
        private System.Windows.Forms.Button BtnDeletar;
        private System.Windows.Forms.Button BtnAtualizar;
        private System.Windows.Forms.Button BtnAdicionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn matricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
    }
}