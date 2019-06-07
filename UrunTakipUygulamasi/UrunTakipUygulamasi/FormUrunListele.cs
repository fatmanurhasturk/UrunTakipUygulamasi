using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UrunTakipUygulamasi.Database;
using UrunTakipUygulamasi.Entities;

namespace UrunTakipUygulamasi
{
    public partial class FormUrunListele : Form
    {
        public FormUrunListele()
        {
            InitializeComponent();
            FormUrunEkle.UrunEkledim += UrunlerdeDegisiklikYapilirsaGuncelle;
        }

        private void UrunlerdeDegisiklikYapilirsaGuncelle(object sender, EventArgs e)
        {
            UrunListesiniYukle();
        }

        private void FormUrunListele_Load(object sender, EventArgs e)
        {
            UrunListesiniYukle();
        }
        private void UrunListesiniYukle()
        {
            lstUrunler.Items.Clear();
            foreach (var urun in Db_Context.Urunler)
            {
                string[] degerlerim =
            {
                urun.UrunAdi,
                urun.Barkod,
                urun.UrunFiyati+" TL",
                urun.UrunAdeti.ToString(),
            };
                ListViewItem satir = new ListViewItem(degerlerim);
                satir.Tag = urun;
                lstUrunler.Items.Add(satir);
            }

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            FormUrunEkle form = new FormUrunEkle();
            form.MdiParent = this.MdiParent;
            form.Show();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lstUrunler.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Herhangi Bir Veri Seçilmedi !");
                return;
            }
            ListViewItem secilmis = lstUrunler.SelectedItems[0];
            Urun urun = (Urun)secilmis.Tag;
            DialogResult result = MessageBox.Show(urun.UrunAdi + " adındaki ürün silinecektir. " +
                "Emin misiniz?", "Dikkat", MessageBoxButtons.YesNo);
            if (result != DialogResult.Yes)
            {
                return;
            }
            try
            {
                Db_Context.Urunler.Remove(urun);
                UrunListesiniYukle();
                MessageBox.Show("Silme İşlemi Başarıyla Tamamlanmıştır");
            }
            catch (Exception)
            {
                MessageBox.Show("SBir Hata Nedeniyle Silme İşlemi Yapılamamıştır.");

            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (lstUrunler.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Herhangi Bir Güncellenecek Veri Seçilmedi !");
                return;
            }
            ListViewItem secilmis = lstUrunler.SelectedItems[0];
            Urun urun = (Urun)secilmis.Tag;

            FormUrunGuncelle frm = new FormUrunGuncelle(urun);
            frm.MdiParent = this.MdiParent;
            frm.UrunGuncellendi += UrunlerdeDegisiklikYapilirsaGuncelle;
            this.FormClosed += frm.FormuKapat;
            frm.Show();
        }

        private void lstUrunler_DoubleClick(object sender, EventArgs e)
        {
            if (lstUrunler.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Detay Görüntülemek İçin Bir Satır Seçmelisiniz");
                return;
            }
            ListViewItem secilmis = lstUrunler.SelectedItems[0];
            Urun urun = (Urun)secilmis.Tag;

            FormUrunDetay frm = new FormUrunDetay(urun);
            this.FormClosed += frm.FormuKapat;
            frm.MdiParent = MdiParent;
            frm.Show();
        }
    }
}
