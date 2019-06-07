namespace UrunTakipUygulamasi
{
    partial class FormAnasayfa
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ekleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.urunEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listelemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.urunleriListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ekleToolStripMenuItem,
            this.listelemeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ekleToolStripMenuItem
            // 
            this.ekleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.urunEkleToolStripMenuItem});
            this.ekleToolStripMenuItem.Name = "ekleToolStripMenuItem";
            this.ekleToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.ekleToolStripMenuItem.Text = "Ekle";
            // 
            // urunEkleToolStripMenuItem
            // 
            this.urunEkleToolStripMenuItem.Name = "urunEkleToolStripMenuItem";
            this.urunEkleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.urunEkleToolStripMenuItem.Text = "Ürün Ekle";
            this.urunEkleToolStripMenuItem.Click += new System.EventHandler(this.urunEkleToolStripMenuItem_Click);
            // 
            // listelemeToolStripMenuItem
            // 
            this.listelemeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.urunleriListeleToolStripMenuItem});
            this.listelemeToolStripMenuItem.Name = "listelemeToolStripMenuItem";
            this.listelemeToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.listelemeToolStripMenuItem.Text = "Listeleme";
            // 
            // urunleriListeleToolStripMenuItem
            // 
            this.urunleriListeleToolStripMenuItem.Name = "urunleriListeleToolStripMenuItem";
            this.urunleriListeleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.urunleriListeleToolStripMenuItem.Text = "Ürünleri Listele";
            this.urunleriListeleToolStripMenuItem.Click += new System.EventHandler(this.urunleriListeleToolStripMenuItem_Click);
            // 
            // FormAnasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormAnasayfa";
            this.Text = "Ürün Takip Uygulaması";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ekleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem urunEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listelemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem urunleriListeleToolStripMenuItem;
    }
}

