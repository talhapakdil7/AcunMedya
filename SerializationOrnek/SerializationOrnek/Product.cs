using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializationOrnek
{

    [Serializable]
    public class Product
    {
        public string Name { get; set; }
        public DateTime ExpirationDate { get; set; }

        public decimal price { get; set; }
    }
}
