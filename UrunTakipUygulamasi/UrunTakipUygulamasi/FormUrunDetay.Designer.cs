﻿namespace UrunTakipUygulamasi
{
    partial class FormUrunDetay
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
            this.label1 = new System.Windows.Forms.Label();
            this.nupUrunAdedi = new System.Windows.Forms.NumericUpDown();
            this.lblUrunAdeti = new System.Windows.Forms.Label();
            this.lblUrunFiyati = new System.Windows.Forms.Label();
            this.txtUrunFiyati = new System.Windows.Forms.TextBox();
            this.lblBarkod = new System.Windows.Forms.Label();
            this.txtBarkod = new System.Windows.Forms.TextBox();
            this.lblUrunAdi = new System.Windows.Forms.Label();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nupUrunAdedi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(278, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 20);
            this.label1.TabIndex = 33;
            this.label1.Text = "TL";
            // 
            // nupUrunAdedi
            // 
            this.nupUrunAdedi.Enabled = false;
            this.nupUrunAdedi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nupUrunAdedi.Location = new System.Drawing.Point(134, 136);
            this.nupUrunAdedi.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nupUrunAdedi.Name = "nupUrunAdedi";
            this.nupUrunAdedi.Size = new System.Drawing.Size(171, 26);
            this.nupUrunAdedi.TabIndex = 32;
            // 
            // lblUrunAdeti
            // 
            this.lblUrunAdeti.AutoSize = true;
            this.lblUrunAdeti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUrunAdeti.Location = new System.Drawing.Point(22, 136);
            this.lblUrunAdeti.Name = "lblUrunAdeti";
            this.lblUrunAdeti.Size = new System.Drawing.Size(85, 20);
            this.lblUrunAdeti.TabIndex = 28;
            this.lblUrunAdeti.Text = "Ürün Adeti";
            // 
            // lblUrunFiyati
            // 
            this.lblUrunFiyati.AutoSize = true;
            this.lblUrunFiyati.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUrunFiyati.Location = new System.Drawing.Point(22, 98);
            this.lblUrunFiyati.Name = "lblUrunFiyati";
            this.lblUrunFiyati.Size = new System.Drawing.Size(85, 20);
            this.lblUrunFiyati.TabIndex = 29;
            this.lblUrunFiyati.Text = "Ürün Fiyatı";
            // 
            // txtUrunFiyati
            // 
            this.txtUrunFiyati.Enabled = false;
            this.txtUrunFiyati.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUrunFiyati.Location = new System.Drawing.Point(134, 92);
            this.txtUrunFiyati.Name = "txtUrunFiyati";
            this.txtUrunFiyati.Size = new System.Drawing.Size(138, 26);
            this.txtUrunFiyati.TabIndex = 25;
            // 
            // lblBarkod
            // 
            this.lblBarkod.AutoSize = true;
            this.lblBarkod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBarkod.Location = new System.Drawing.Point(22, 62);
            this.lblBarkod.Name = "lblBarkod";
            this.lblBarkod.Size = new System.Drawing.Size(108, 20);
            this.lblBarkod.TabIndex = 30;
            this.lblBarkod.Text = "Ürün Barkodu";
            // 
            // txtBarkod
            // 
            this.txtBarkod.Enabled = false;
            this.txtBarkod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBarkod.Location = new System.Drawing.Point(134, 56);
            this.txtBarkod.Name = "txtBarkod";
            this.txtBarkod.Size = new System.Drawing.Size(171, 26);
            this.txtBarkod.TabIndex = 26;
            // 
            // lblUrunAdi
            // 
            this.lblUrunAdi.AutoSize = true;
            this.lblUrunAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUrunAdi.Location = new System.Drawing.Point(22, 25);
            this.lblUrunAdi.Name = "lblUrunAdi";
            this.lblUrunAdi.Size = new System.Drawing.Size(71, 20);
            this.lblUrunAdi.TabIndex = 31;
            this.lblUrunAdi.Text = "Ürün Adı";
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Enabled = false;
            this.txtUrunAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUrunAdi.Location = new System.Drawing.Point(134, 19);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(171, 26);
            this.txtUrunAdi.TabIndex = 27;
            // 
            // FormUrunDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 174);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nupUrunAdedi);
            this.Controls.Add(this.lblUrunAdeti);
            this.Controls.Add(this.lblUrunFiyati);
            this.Controls.Add(this.txtUrunFiyati);
            this.Controls.Add(this.lblBarkod);
            this.Controls.Add(this.txtBarkod);
            this.Controls.Add(this.lblUrunAdi);
            this.Controls.Add(this.txtUrunAdi);
            this.Name = "FormUrunDetay";
            this.Text = "Ürün Detay";
            this.Load += new System.EventHandler(this.FormUrunDetay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nupUrunAdedi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nupUrunAdedi;
        private System.Windows.Forms.Label lblUrunAdeti;
        private System.Windows.Forms.Label lblUrunFiyati;
        private System.Windows.Forms.TextBox txtUrunFiyati;
        private System.Windows.Forms.Label lblBarkod;
        private System.Windows.Forms.TextBox txtBarkod;
        private System.Windows.Forms.Label lblUrunAdi;
        private System.Windows.Forms.TextBox txtUrunAdi;
    }
}