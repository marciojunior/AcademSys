namespace AcademSys
{
    partial class FrmAgenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAgenda));
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.DtAgenda = new System.Windows.Forms.DateTimePicker();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.DgAgenda = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnPesquisa = new System.Windows.Forms.Button();
            this.ChkTodos = new System.Windows.Forms.CheckBox();
            this.BtnAdicionar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgAgenda)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.panel1.Controls.Add(this.LblTitulo);
            this.panel1.Location = new System.Drawing.Point(-9, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(705, 109);
            this.panel1.TabIndex = 8;
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblTitulo.Location = new System.Drawing.Point(27, 48);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(156, 25);
            this.LblTitulo.TabIndex = 1;
            this.LblTitulo.Text = "Agendamento";
            // 
            // DtAgenda
            // 
            this.DtAgenda.Location = new System.Drawing.Point(181, 123);
            this.DtAgenda.Name = "DtAgenda";
            this.DtAgenda.Size = new System.Drawing.Size(400, 20);
            this.DtAgenda.TabIndex = 9;
            this.DtAgenda.ValueChanged += new System.EventHandler(this.DtAgenda_ValueChanged);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnCancelar.BackgroundImage")));
            this.BtnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnCancelar.Location = new System.Drawing.Point(603, 348);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(80, 65);
            this.BtnCancelar.TabIndex = 12;
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // DgAgenda
            // 
            this.DgAgenda.AllowUserToAddRows = false;
            this.DgAgenda.AllowUserToDeleteRows = false;
            this.DgAgenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgAgenda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.titulo,
            this.data,
            this.desc});
            this.DgAgenda.Location = new System.Drawing.Point(23, 170);
            this.DgAgenda.Name = "DgAgenda";
            this.DgAgenda.ReadOnly = true;
            this.DgAgenda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.DgAgenda.Size = new System.Drawing.Size(558, 243);
            this.DgAgenda.TabIndex = 14;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // titulo
            // 
            this.titulo.HeaderText = "Titulo";
            this.titulo.Name = "titulo";
            this.titulo.ReadOnly = true;
            this.titulo.Width = 400;
            // 
            // data
            // 
            this.data.HeaderText = "Data";
            this.data.Name = "data";
            this.data.ReadOnly = true;
            this.data.Width = 120;
            // 
            // desc
            // 
            this.desc.HeaderText = "desc";
            this.desc.Name = "desc";
            this.desc.ReadOnly = true;
            this.desc.Visible = false;
            // 
            // BtnPesquisa
            // 
            this.BtnPesquisa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnPesquisa.BackgroundImage")));
            this.BtnPesquisa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnPesquisa.Location = new System.Drawing.Point(603, 258);
            this.BtnPesquisa.Name = "BtnPesquisa";
            this.BtnPesquisa.Size = new System.Drawing.Size(80, 65);
            this.BtnPesquisa.TabIndex = 15;
            this.BtnPesquisa.UseVisualStyleBackColor = true;
            this.BtnPesquisa.Click += new System.EventHandler(this.BtnPesquisa_Click);
            // 
            // ChkTodos
            // 
            this.ChkTodos.AutoSize = true;
            this.ChkTodos.Location = new System.Drawing.Point(23, 126);
            this.ChkTodos.Name = "ChkTodos";
            this.ChkTodos.Size = new System.Drawing.Size(130, 17);
            this.ChkTodos.TabIndex = 16;
            this.ChkTodos.Text = "Todos Agendamentos";
            this.ChkTodos.UseVisualStyleBackColor = true;
            this.ChkTodos.CheckedChanged += new System.EventHandler(this.ChkTodos_CheckedChanged);
            // 
            // BtnAdicionar
            // 
            this.BtnAdicionar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnAdicionar.BackgroundImage")));
            this.BtnAdicionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnAdicionar.Location = new System.Drawing.Point(603, 170);
            this.BtnAdicionar.Name = "BtnAdicionar";
            this.BtnAdicionar.Size = new System.Drawing.Size(80, 65);
            this.BtnAdicionar.TabIndex = 17;
            this.BtnAdicionar.UseVisualStyleBackColor = true;
            this.BtnAdicionar.Click += new System.EventHandler(this.BtnAdicionar_Click);
            // 
            // FrmAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 441);
            this.Controls.Add(this.BtnAdicionar);
            this.Controls.Add(this.ChkTodos);
            this.Controls.Add(this.BtnPesquisa);
            this.Controls.Add(this.DgAgenda);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.DtAgenda);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAgenda";
            this.Text = "Agendamento usuário";
            this.Load += new System.EventHandler(this.FrmAgenda_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgAgenda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.DateTimePicker DtAgenda;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.DataGridView DgAgenda;
        private System.Windows.Forms.Button BtnPesquisa;
        private System.Windows.Forms.CheckBox ChkTodos;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn data;
        private System.Windows.Forms.Button BtnAdicionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn desc;
    }
}