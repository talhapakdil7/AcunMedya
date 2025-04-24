using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace GenericList1
{
    internal class Car
    {

        public Marka marka { get; set; }
        public Model model { get; set; }
        public double benzinHarcamasi { get; set; }
        public double toplamMesafe { get; set; }

        public Car(Marka marka, Model model, double benzinHarcamasi, double toplamMesafe)
        {
            this.marka = marka;
            this.model = model;
            this.benzinHarcamasi = benzinHarcamasi;
            this.toplamMesafe = toplamMesafe;
        }


        public double topYakitTuketim()
        {
           return (toplamMesafe/100)*benzinHarcamasi;
        }
    }

}
