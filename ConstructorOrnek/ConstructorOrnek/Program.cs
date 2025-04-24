// See https://aka.ms/new-console-template for more information
using ConstructorOrnek;

Console.WriteLine("Hello, World!");

int[] sayilar = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };



Matematik matematik = new Matematik();

int sonuc=matematik.topla(sayilar);
Console.WriteLine(sonuc);