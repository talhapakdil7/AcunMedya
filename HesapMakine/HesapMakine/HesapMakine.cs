using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematik
{
    internal class HesapMakine
    {


        public int sayi1;
        public int sayi2;

        public string islem;



        public void Topla()
        {

            Console.WriteLine();

            Console.WriteLine("Toplam:" + (sayi1 + sayi2));
        }

        public void Cikar()
        {
            Console.WriteLine();
            Console.WriteLine("Fark:" + (sayi1 - sayi2));
        }   

        public void Carp()
        {
            Console.WriteLine();
            Console.WriteLine("Carpim:" + (sayi1 * sayi2));
        }

        public void Bol()
        {
            Console.WriteLine();
            Console.WriteLine("Bolum:" + (sayi1 / sayi2));
        }













    }
}
