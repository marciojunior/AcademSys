﻿namespace AcademSys
{
    partial class FrmEditarCP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditarCP));
            this.CbmPago = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtMotivo = new System.Windows.Forms.TextBox();
            this.TxtValor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.BtnOk = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CbmPago
            // 
            this.CbmPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbmPago.FormattingEnabled = true;
            this.CbmPago.Items.AddRange(new object[] {
            "Sim",
            "Não"});
            this.CbmPago.Location = new System.Drawing.Point(106, 131);
            this.CbmPago.Name = "CbmPago";
            this.CbmPago.Size = new System.Drawing.Size(88, 21);
            this.CbmPago.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Pago: ";
            // 
            // TxtMotivo
            // 
            this.TxtMotivo.Location = new System.Drawing.Point(106, 161);
            this.TxtMotivo.Multiline = true;
            this.TxtMotivo.Name = "TxtMotivo";
            this.TxtMotivo.Size = new System.Drawing.Size(286, 153);
            this.TxtMotivo.TabIndex = 26;
            // 
            // TxtValor
            // 
            this.TxtValor.Location = new System.Drawing.Point(106, 105);
            this.TxtValor.Name = "TxtValor";
            this.TxtValor.Size = new System.Drawing.Size(286, 20);
            this.TxtValor.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Motivo: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Valor: ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.panel1.Controls.Add(this.LblTitulo);
            this.panel1.Location = new System.Drawing.Point(-1, -15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(528, 97);
            this.panel1.TabIndex = 22;
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblTitulo.Location = new System.Drawing.Point(27, 48);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(232, 25);
            this.LblTitulo.TabIndex = 1;
            this.LblTitulo.Text = "Editar Conta a Pagar";
            // 
            // BtnOk
            // 
            this.BtnOk.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnOk.BackgroundImage")));
            this.BtnOk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnOk.Location = new System.Drawing.Point(415, 161);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(80, 65);
            this.BtnOk.TabIndex = 28;
            this.BtnOk.UseVisualStyleBackColor = true;
            this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnCancelar.BackgroundImage")));
            this.BtnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnCancelar.Location = new System.Drawing.Point(415, 249);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(80, 65);
            this.BtnCancelar.TabIndex = 27;
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // FrmEditarCP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 330);
            this.Controls.Add(this.CbmPago);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnOk);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.TxtMotivo);
            this.Controls.Add(this.TxtValor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmEditarCP";
            this.Text = "Editar Conta a Pagar";
            this.Load += new System.EventHandler(this.FrmEditarCP_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CbmPago;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnOk;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.TextBox TxtMotivo;
        private System.Windows.Forms.TextBox TxtValor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblTitulo;
    }
}