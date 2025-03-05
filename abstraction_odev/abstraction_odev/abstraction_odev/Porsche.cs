using abstraction_odev.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstraction_odev
{
    internal class Porsche : Araclar, Ihava

    {
        public void havaOzellik(string marka)
        {
            Console.WriteLine(marka +"Havada uçar");
        }
    }
}
