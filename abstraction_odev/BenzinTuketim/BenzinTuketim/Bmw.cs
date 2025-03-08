using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenzinTuketim
{
    internal class Bmw : Araba, IYakit

    {
        public int yakitTuketim()
        {
            return 80;
        }
    }
}
