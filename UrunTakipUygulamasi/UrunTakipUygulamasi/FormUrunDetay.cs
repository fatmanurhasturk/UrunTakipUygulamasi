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
    public partial class FormUrunDetay : Form
    {
        Urun _urun;
        public FormUrunDetay(Urun urun)
        {
            _urun = urun;
            InitializeComponent();
        }

        private void FormUrunDetay_Load(object sender, EventArgs e)
        {
            txtBarkod.Text = _urun.Barkod;
            txtUrunAdi.Text = _urun.UrunAdi;
            txtUrunFiyati.Text = _urun.UrunFiyati.ToString();
            nupUrunAdedi.Value = _urun.UrunAdeti;
        }

        public void FormuKapat(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
