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
    public partial class FormUrunEkle : Form
    {
        public static event EventHandler UrunEkledim;
        public FormUrunEkle()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Ürün Eklenecek Emin Misiniz", "Dikkat", MessageBoxButtons.YesNo);
            if (result != DialogResult.Yes)
            {
                return;
            }
            Urun urun = new Urun();
            urun.UrunAdi = txtUrunAdi.Text;
            urun.Barkod = txtBarkod.Text;
            urun.UrunFiyati = double.Parse(txtUrunFiyati.Text);
            urun.UrunAdeti = (int)nupUrunAdedi.Value;
            Db_Context.Urunler.Add(urun);
            if (UrunEkledim!=null)
            {
                UrunEkledim(this, EventArgs.Empty);
            }
            MessageBox.Show("Ürün ekleme işlemi başarıyla tamamlanmıştır.");
            Helper.ControlTemizle(this);
            this.Close();

            //Listeleme üzerinde ürünlerin detaylarıyla beraber herşeyini listeliyor olacak.
            //ListView altında üç tane buton olcak. sil Güncelle ekle.
            //Ekleye basınca ekle formu tekrardan gelcek
            //sadece adet ve fiyat değişcek güncelle yapınca. Diğerleri gözükcek ama pasif olcak

            //Hepsinin mdiform olduğundan emin olmanız lazım.
            //Hint: Personel kayıtı uyguluyor olacaz :)))))

        }
    }
}
