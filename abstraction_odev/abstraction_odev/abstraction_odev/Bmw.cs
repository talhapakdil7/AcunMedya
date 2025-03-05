using abstraction_odev.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstraction_odev
{
    internal class Bmw : Araclar, IDeniz, Ihava, IHiz
    {
        public void denizOzellik(string marka)
        {
            Console.WriteLine(marka + "denizde yuzer");
        }

      
        public void havaOzellik(string marka)
        {
            Console.WriteLine(marka +"havada ucar");
        }


        public void hiz(string marka)
        {
            Console.WriteLine(marka+ "cok hızlı gider");
        }

       

        
    }
}
