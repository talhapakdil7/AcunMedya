// See https://aka.ms/new-console-template for more information
using ClassLibrary1;
using CustomAttributeOrnek;

Console.WriteLine("Hello, World!");



Ogrenci ogr= new Ogrenci();
ogr.bolum = "sklfjs"
    ;
ogr.isim = "slkdfj";
ogr.soyisim = "kelfj";

ZorunlulukKontrolu.Dogrula(ogr);


if (!ZorunlulukKontrolu.Dogrula(ogr))
{
    Console.WriteLine("bos alanları doldur");
}

else
{
    Console.WriteLine("form basarılı");
}



Matematik mt= new Matematik();
int sonuc=mt.topla(3, 2);
Console.WriteLine(sonuc);






