namespace AcademSys
{
    partial class FrmPonto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPonto));
            this.DGP = new System.Windows.Forms.DataGridView();
            this.dataE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGP)).BeginInit();
            this.SuspendLayout();
            // 
            // DGP
            // 
            this.DGP.AllowUserToAddRows = false;
            this.DGP.AllowUserToDeleteRows = false;
            this.DGP.AllowUserToOrderColumns = true;
            this.DGP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataE,
            this.horaE,
            this.DataS,
            this.HoraS});
            this.DGP.Location = new System.Drawing.Point(3, 1);
            this.DGP.Name = "DGP";
            this.DGP.ReadOnly = true;
            this.DGP.Size = new System.Drawing.Size(445, 384);
            this.DGP.TabIndex = 0;
            // 
            // dataE
            // 
            this.dataE.HeaderText = "Data Entrada";
            this.dataE.Name = "dataE";
            this.dataE.ReadOnly = true;
            // 
            // horaE
            // 
            this.horaE.HeaderText = "Hora Entrada";
            this.horaE.Name = "horaE";
            this.horaE.ReadOnly = true;
            // 
            // DataS
            // 
            this.DataS.HeaderText = "Data Saída";
            this.DataS.Name = "DataS";
            this.DataS.ReadOnly = true;
            // 
            // HoraS
            // 
            this.HoraS.HeaderText = "Hora Saída";
            this.HoraS.Name = "HoraS";
            this.HoraS.ReadOnly = true;
            // 
            // FrmPonto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 387);
            this.Controls.Add(this.DGP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPonto";
            this.Text = "Ponto do Usuário";
            this.Load += new System.EventHandler(this.FrmPonto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGP;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataE;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataS;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraS;
    }
}