using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializationOrnek
{

    //attribute
    [Serializable]
    public class Employee
    {
        public string adi { get; set; }
        public string soyadi { get; set; }
        public DateTime dogumTarihi { get; set; } 
        public string departman { get; set; }   
        public int maas { get; set; }    

    }
}
