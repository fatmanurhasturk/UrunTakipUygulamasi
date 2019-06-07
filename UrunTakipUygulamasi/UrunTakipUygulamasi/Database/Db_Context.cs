using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UrunTakipUygulamasi.Entities;

namespace UrunTakipUygulamasi.Database
{
    public class Db_Context
    {
        public static ICollection<Urun> Urunler = new HashSet<Urun>();
    }
}
