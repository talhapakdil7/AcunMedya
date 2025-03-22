using contrucodev;
using contrucodev.Matenatk;

Marka marka= new Marka("bmw x5");

Kasa kasa = new Kasa("sedan");

Kapi kapi = new Kapi(4);

Pencere pencere = new Pencere(4);

Araba araba = new Araba(marka,kasa,pencere,kapi);

araba.BilgiYazdir();    




Islemler islemler = new Islemler();

int sonuc = islemler.Topla(5, 6);
double sonuc2 = islemler.Topla(2.3, 43.3, 21.3);

Console.WriteLine(sonuc + " " + sonuc2);

//📌 1.Garbage Collector(GC) Nedir?
//Garbage Collector (Çöp Toplayıcı), C#’ta kullanılmayan nesneleri otomatik olarak bellekten temizleyen bir mekanizmadır.
//Bu sayede geliştiriciler manuel bellek yönetimiyle uğraşmak zorunda kalmazlar ve bellek sızıntıları (memory leaks) azalır.

//📌 2.Garbage Collector Nasıl Çalışır?
//C#’ta GC, .NET CLR (Common Language Runtime) tarafından yönetilir ve otomatik olarak çalışır.
//GC’nin temel çalışma prensipleri şunlardır:

//✅ Heap Belleği Temizler → Kullanılmayan nesneleri bellekten kaldırır.
//✅ Root Nesneleri Kontrol Eder → Hala erişilebilir nesneleri belirler.
//✅ Nesneleri Üç Jenerasyona Böler → Daha iyi performans sağlar.
//✅ Sadece Gerektiğinde Çalışır → Bellek azaldığında veya sistem boşta olduğunda devreye girer.

//📌 3. Garbage Collector’in Bellek Yönetimindeki Rolü
//Garbage Collector, heap bellek yönetimini yapar. Heap belleği 3 jenerasyona (Generation 0, 1, 2) ayırarak yönetir:

//1️⃣ Generation 0 → Yeni nesneler burada oluşturulur. Küçük ve kısa ömürlü nesneler burada kalır.
//2️⃣ Generation 1 → Generation 0’daki nesneler uzun süre hayatta kalırsa buraya taşınır.
//3️⃣ Generation 2 → Büyük ve uzun ömürlü nesneler buradadır.

//🔹 GC en çok Generation 0’ı temizler, çünkü yeni nesnelerin çoğu hızlı bir şekilde yok edilir.
//🔹 Generation 2’deki nesneler daha nadiren temizlenir, çünkü uzun ömürlü nesneler burada bulunur.

