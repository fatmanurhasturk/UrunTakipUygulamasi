using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UrunTakipUygulamasi.Entities;

namespace UrunTakipUygulamasi
{
    public partial class FormUrunGuncelle : Form
    {
        Urun _urun;
        public EventHandler UrunGuncellendi;
        public FormUrunGuncelle(Urun urun)
        {
            _urun = urun;
            InitializeComponent();
        }

        private void FormUrunGuncelle_Load(object sender, EventArgs e)
        {
            txtBarkod.Text = _urun.Barkod;
            txtUrunAdi.Text = _urun.UrunAdi;
            txtUrunFiyati.Text = _urun.UrunFiyati.ToString();
            nupUrunAdedi.Value = _urun.UrunAdeti;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            //validationlar uygulanacak
            DialogResult result = MessageBox.Show("Güncelleme Yapmak İstediğinize Emin Misiniz ?",
                "Uyarı",MessageBoxButtons.YesNo);
            if (result!=DialogResult.Yes)
            {
                return;
            }
            try
            {
                _urun.UrunAdeti = (int)nupUrunAdedi.Value;
                _urun.UrunFiyati = double.Parse(txtUrunFiyati.Text);
                //listeyi güncelle
                UrunGuncellendi(this, EventArgs.Empty);
                MessageBox.Show("Güncelleme İşlemi Başarılı Olmuştur.");
            }
            catch (Exception)
            {
                MessageBox.Show("Hata Sebebiyle İşlem Yapılamamıştır.");
            }
        }
        public void FormuKapat(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
