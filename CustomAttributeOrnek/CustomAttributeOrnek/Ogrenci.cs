using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomAttributeOrnek
{
    public class Ogrenci
    {
        [ZorunluAlan]
        public string isim;

        [ZorunluAlan]

        public string soyisim;
        [ZorunluAlan]
        public string bolum;
    }
}
