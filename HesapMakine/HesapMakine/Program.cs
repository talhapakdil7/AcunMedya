using Matematik;

HesapMakine hm = new HesapMakine();




Console.WriteLine("merhaba bir sayi gir:");

hm.sayi1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ikinci sayi gir:");
hm.sayi2 = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("islemi gir:");
hm.islem = Console.ReadLine();






    if (hm.islem == "+")
    {

        hm.Topla();

    }

    else if (hm.islem == "-")
    {

        hm.Cikar();
    }
    else if (hm.islem == "*")
    {
        hm.Carp();
    }
    else if (hm.islem == "/")
    {
        hm.Bol();
    }
    else
    {
        Console.WriteLine("yanlis islem girdiniz");
    }










