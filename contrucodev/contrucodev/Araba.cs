using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contrucodev
{
    internal class Araba
    {

        // composition kullandık baska bır sınıfı nesne gıbı kullandık

        public Marka marka;

        public Kasa kasa;


        public Pencere pencere;

        public Kapi kapi;




        public Araba(Marka marka, Kasa kasa, Pencere pencere, Kapi kapi)
        {
            this.marka = marka;
            this.kasa = kasa;
            this.pencere = pencere;
            this.kapi = kapi;
        }   

        public void BilgiYazdir()
        {


            Console.WriteLine("Arabanın markası: " + marka.Markasi);
            Console.WriteLine("Arabanın kasası: " + kasa.Kasasi);
            Console.WriteLine("Arabanın kapı sayısı: " + kapi.Kapisayisi);
            Console.WriteLine("Arabanın pencere sayısı: " + pencere.PencereSayisi); 
        }

    }
}
