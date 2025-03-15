// See https://aka.ms/new-console-template for more information
using matematikselislem;
using System.ComponentModel;



namespace arastirma
{
    //C#'da Namespace Nedir?
    //Namespace, C# programlarında isim çakışmalarını önlemek ve kodu daha düzenli
    //    hale getirmek için kullanılan bir yapıdır. Bir namespace, içinde sınıflar (class), arayüzler (interface), yapılar (struct),
    //    numaralandırmalar (enum) ve diğer öğeleri barındırabilir.

    //İsim Çakışmalarını Önler

    //Farklı kütüphanelerde veya büyük projelerde aynı isimde sınıflar olabilir. Namespace kullanımı, bu sınıfların birbirine karışmasını önler.
    //Örneğin, hem System.Collections hem de System.Collections.Generic içinde List sınıfı vardır ama namespace sayesinde çakışmazlar.
    //Kod Düzenini ve Modülerliği Artırır

    //Büyük projelerde, ilgili sınıfları ve bileşenleri gruplamak için namespace kullanılır.



    //    Aynı İsimli Sınıfların Kullanılmasını Sağlar

    //Aynı isimde iki farklı sınıf kullanmak gerekebilir.Namespace kullanarak hangi sınıfın kullanılacağını belirtebiliriz.



    //Daha Kolay Yönetilebilir Kütüphaneler ve DLL Dosyaları

    //Harici kütüphaneler ve API'ler ile çalışırken, farklı namespace'ler sayesinde çakışmaları önleyerek yönetimi kolaylaştırır.


    //Kodun Okunabilirliğini Artırır

    //Büyük projelerde, hangi sınıfın neyle ilgili olduğunu anlamak kolaylaşır. Örneğin, MyApp.Database,
    //MyApp.UI, MyApp.Services gibi namespace'ler, bileşenlerin amacını netleştirir.



    //GENİŞLETİLEBİLİRLİK 

    //Genişletilebilirlik(Extensibility), bir yazılımın veya sistemin mevcut kodu değiştirmeden veya minimum değişiklikle yeni özellikler,
    //işlevler veya bileşenler eklenmesine olanak tanıyan tasarım prensibidir.

    //SOLİD PRENSİPLERİNE uyarak genısletılebılır bır yazılım olusturabılırrız.
    //1:AÇIK KAPALI PRENSİBİ (OPEN/CLOSED PRINCIPLE)
    // abstract sınıf ve ınterface kullanbılmeyız genıslemeye acık degısıme kapalı olmalıdır bır sınıfa tum ozellıklerı yuklememelıyız

    //Bagımlılıgı azaltr(Depencency Inversion Principle)
    //bır sınıfın dogrudan baska sınıflara baglı olması yerıne ınterfaceler aracılıgıyla bagımlılıkları azaltmalıyız

    // design pattern kullan.

}


namespace ProgramTest
{


    class Program
    {
        static void Main(string[] args)
        {
           
            Hesaplama hesap= new Hesaplama();

            int sonuc = hesap.Topla(2, 3);

            Console.WriteLine(sonuc);
            
            int sonuc2 = hesap.Carp(2, 3);
            Console.WriteLine(sonuc2);



        }
    }

}