// See https://aka.ms/new-console-template for more information








Random rnd = new Random();


int sayi = rnd.Next(1, 100);


Console.WriteLine("1 ile 100 arasında sayi tutun");

int tahminSayisi = 0;

while (true)
{
    tahminSayisi++;
    Console.WriteLine("tahmin gir");
    int tahmin =Convert.ToInt32(Console.ReadLine());

    if (tahmin > sayi) { Console.WriteLine("kücük sayi gir"); }

    if(tahmin < sayi) { Console.WriteLine("büyük sayi gir"); }

    if (tahmin == sayi) { Console.WriteLine("tebrikler"); break; }



}

Console.WriteLine("tahmin sayisi:"+tahminSayisi);