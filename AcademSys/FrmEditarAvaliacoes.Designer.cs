﻿namespace AcademSys
{
    partial class FrmEditarAvaliacoes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditarAvaliacoes));
            this.BtnOk = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.MskHora = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DtData = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.CbmCli = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnOk
            // 
            this.BtnOk.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnOk.BackgroundImage")));
            this.BtnOk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnOk.Location = new System.Drawing.Point(278, 207);
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
            this.BtnCancelar.Location = new System.Drawing.Point(392, 207);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(80, 65);
            this.BtnCancelar.TabIndex = 27;
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // MskHora
            // 
            this.MskHora.Location = new System.Drawing.Point(124, 184);
            this.MskHora.Mask = "99:99";
            this.MskHora.Name = "MskHora";
            this.MskHora.Size = new System.Drawing.Size(121, 20);
            this.MskHora.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Informe a hora:";
            // 
            // DtData
            // 
            this.DtData.Location = new System.Drawing.Point(124, 150);
            this.DtData.Name = "DtData";
            this.DtData.Size = new System.Drawing.Size(243, 20);
            this.DtData.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Selecione a data:";
            // 
            // CbmCli
            // 
            this.CbmCli.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbmCli.FormattingEnabled = true;
            this.CbmCli.Location = new System.Drawing.Point(124, 118);
            this.CbmCli.Name = "CbmCli";
            this.CbmCli.Size = new System.Drawing.Size(348, 21);
            this.CbmCli.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Selecione o cliente:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.panel1.Controls.Add(this.LblTitulo);
            this.panel1.Location = new System.Drawing.Point(-4, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(490, 97);
            this.panel1.TabIndex = 20;
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblTitulo.Location = new System.Drawing.Point(28, 44);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(221, 25);
            this.LblTitulo.TabIndex = 1;
            this.LblTitulo.Text = "Adicionar Avaliação";
            // 
            // FrmEditarAvaliacoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 278);
            this.Controls.Add(this.BtnOk);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.MskHora);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DtData);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CbmCli);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmEditarAvaliacoes";
            this.Text = "Editar Avaliações";
            this.Load += new System.EventHandler(this.FrmEditarAvaliacoes_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnOk;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.MaskedTextBox MskHora;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker DtData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CbmCli;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblTitulo;
    }
}