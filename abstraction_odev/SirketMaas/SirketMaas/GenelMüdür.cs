using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SirketMaas
{
    internal class GenelMüdür : Calisan, IMaas
    {
        public double maasinizNedir()
        {
            return 80.000;
        }
    }
}
