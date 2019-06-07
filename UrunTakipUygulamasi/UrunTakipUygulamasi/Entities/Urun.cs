using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrunTakipUygulamasi.Entities
{
    public class Urun
    {
        public string UrunAdi { get; set; }
        public string Barkod { get; set; }
        public int UrunAdeti { get; set; }
        public double UrunFiyati { get; set; }
    }
}
