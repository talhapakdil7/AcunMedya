using abstraction_odev.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace abstraction_odev
{
    internal class Mercedes : Araclar, IDeniz, Ihava
    {
        public void denizOzellik(string marka)
        {
            Console.WriteLine(marka + " " +  " denizde yüzer");
        }

        public void havaOzellik(string marka)
        {
            Console.WriteLine(marka + " "+ "havada ucar");
        }
    }
}
