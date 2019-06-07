namespace UrunTakipUygulamasi
{
    partial class FormUrunListele
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
            this.btnEkle = new System.Windows.Forms.Button();
            this.lstUrunler = new System.Windows.Forms.ListView();
            this.chUrunAdi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chUrunBarkodu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chUrunAdeti = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chUrunFiyati = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.LawnGreen;
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEkle.Location = new System.Drawing.Point(518, 14);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(105, 35);
            this.btnEkle.TabIndex = 5;
            this.btnEkle.Text = "Ürün Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // lstUrunler
            // 
            this.lstUrunler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chUrunAdi,
            this.chUrunBarkodu,
            this.chUrunAdeti,
            this.chUrunFiyati});
            this.lstUrunler.FullRowSelect = true;
            this.lstUrunler.GridLines = true;
            this.lstUrunler.Location = new System.Drawing.Point(8, 55);
            this.lstUrunler.MultiSelect = false;
            this.lstUrunler.Name = "lstUrunler";
            this.lstUrunler.Size = new System.Drawing.Size(615, 363);
            this.lstUrunler.TabIndex = 4;
            this.lstUrunler.UseCompatibleStateImageBehavior = false;
            this.lstUrunler.View = System.Windows.Forms.View.Details;
            this.lstUrunler.DoubleClick += new System.EventHandler(this.lstUrunler_DoubleClick);
            // 
            // chUrunAdi
            // 
            this.chUrunAdi.Text = "Ürün Adı";
            this.chUrunAdi.Width = 146;
            // 
            // chUrunBarkodu
            // 
            this.chUrunBarkodu.Text = "Ürün Barkodu";
            this.chUrunBarkodu.Width = 159;
            // 
            // chUrunAdeti
            // 
            this.chUrunAdeti.Text = "Ürün Adeti";
            this.chUrunAdeti.Width = 147;
            // 
            // chUrunFiyati
            // 
            this.chUrunFiyati.Text = "Ürün Fiyatı";
            this.chUrunFiyati.Width = 159;
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Red;
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSil.Location = new System.Drawing.Point(8, 424);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(105, 35);
            this.btnSil.TabIndex = 7;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuncelle.Location = new System.Drawing.Point(518, 424);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(105, 35);
            this.btnGuncelle.TabIndex = 6;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // FormUrunListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 465);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.lstUrunler);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Name = "FormUrunListele";
            this.Text = "Ürün Listele";
            this.Load += new System.EventHandler(this.FormUrunListele_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.ListView lstUrunler;
        private System.Windows.Forms.ColumnHeader chUrunAdi;
        private System.Windows.Forms.ColumnHeader chUrunBarkodu;
        private System.Windows.Forms.ColumnHeader chUrunAdeti;
        private System.Windows.Forms.ColumnHeader chUrunFiyati;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
    }
}