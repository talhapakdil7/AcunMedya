// See https://aka.ms/new-console-template for more information

//Ödev 4: Diziler ve Döngüler 🚀📊

//Ödev: Kullanıcıdan 5 adet sayı alarak bu sayıların ortalamasını hesaplayan bir program yazın.

//Yapılması Gerekenler:

//Kullanıcıdan 5 tane sayı girişi alın ve bir diziye kaydedin.
//for veya foreach döngüsünü kullanarak tüm sayıların toplamını bulun.
//Toplamı 5’e bölerek ortalamayı hesaplayın.
//Sonucu ekrana yazdırın.

int[] dizi =new int[5];
int toplam=0;
for (int i=0;i<5;i++)
{


    Console.WriteLine("bir sayi gir");
int sayi=Convert.ToInt32(Console.ReadLine());
   
    dizi[i] = sayi;
   toplam += sayi;


}

Console.WriteLine("ortalama=" + toplam / 5);



