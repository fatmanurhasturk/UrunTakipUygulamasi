using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using UrunTakipUygulamasi.Database;
using UrunTakipUygulamasi.Entities;

namespace UrunTakipUygulamasi
{
    static class Program
    {
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DatabaseYukle();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormAnasayfa());
        }

        private static void DatabaseYukle()
        {
            Urun urun1 = new Urun()
            {
                UrunAdi = "Elektrikli Süpürge",
                Barkod = "elsu300",
                UrunAdeti = 300,
                UrunFiyati = 2500
            };

            Urun urun2 = new Urun()
            {
                UrunAdi = "Buzdolabı",
                Barkod = "buz300",
                UrunAdeti = 100,
                UrunFiyati = 1850
            };

            Urun urun3 = new Urun()
            {
                UrunAdi = "Televizyon",
                Barkod = "tele300",
                UrunAdeti = 150,
                UrunFiyati = 1600
            };

            Urun urun4 = new Urun()
            {
                UrunAdi = "Çamaşır Makinesi",
                Barkod = "cama300",
                UrunAdeti = 100,
                UrunFiyati = 1100
            };

            Urun urun5 = new Urun()
            {
                UrunAdi = "Bulaşık Makinesi",
                Barkod = "buma300",
                UrunAdeti = 100,
                UrunFiyati = 900
            };

            Urun urun6 = new Urun()
            {
                UrunAdi = "Köşe Takımı",
                Barkod = "kota300",
                UrunAdeti = 700,
                UrunFiyati = 1650
            };

            Db_Context.Urunler.Add(urun1);
            Db_Context.Urunler.Add(urun2);
            Db_Context.Urunler.Add(urun3);
            Db_Context.Urunler.Add(urun4);
            Db_Context.Urunler.Add(urun5);
            Db_Context.Urunler.Add(urun6);

        }
    }
}
