using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorOrnek
{
    internal class Matematik
    {
        
        public int topla(int[] dizi)
        {


            int toplam = 0;

            foreach (int i in dizi)
            {
                toplam += i;
            }
            return toplam;




        }
    }
}