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
    public partial class FormAnasayfa : Form
    {
        public FormAnasayfa()
        {
            InitializeComponent();
        }

        private void urunEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUrunEkle frm = new FormUrunEkle();
            frm.MdiParent = this;
            frm.Show();
        }

        private void urunleriListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUrunListele frm = new FormUrunListele();
            frm.MdiParent = this;
            frm.Show();
            //Urun urun = new Urun();
            //ListViewItem lv = UrunListesi(urun);

        }
        //private ListViewItem UrunListesi(Urun urun)
        //{
        //    string[] degerlerim =
        //    {
        //        urun.UrunAdi,
        //        urun.Barkod,
        //        urun.UrunFiyati.ToString(),
        //        urun.UrunAdeti.ToString(),
        //    };
        //    ListViewItem item = new ListViewItem(degerlerim);
        //    item.Tag = urun;
        //    return item;
        //}
    }
}
