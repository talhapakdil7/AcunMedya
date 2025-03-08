using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenzinTuketim
{
    internal class Mercedes : Araba, IYakit
    {
        public int yakitTuketim()
        {
            return 70;
        }
    }
}
