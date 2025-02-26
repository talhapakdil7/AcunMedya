# Abstract Class (Soyut Sınıf) Nedir?

**Abstract Class (Soyut Sınıf)**, nesne yönelimli programlamada (OOP) doğrudan nesne oluşturulamayacak ve genellikle başka sınıflar tarafından miras alınarak kullanılacak sınıflardır. Soyut sınıflar, genel bir şablon sunar ve alt sınıfların bu şablona uygun şekilde davranmasını sağlar. Soyut sınıflar, sadece ortak özellikleri ve genel metotları tanımlar, ancak bazı metotların gerçek implementasyonu alt sınıflara bırakılabilir.

## Bir soyut sınıfın bazı özellikleri şunlardır:

### 1. Soyut Metotlar:
Soyut sınıf içinde implementasyonu olmayan metodlar bulunabilir. Bu metodlar alt sınıflar tarafından **override** edilerek implement edilir.

### 2. Soyut Olmayan Metotlar:
Soyut sınıflarda implementasyonu yapılmış metotlar da bulunabilir. Bu metotlar alt sınıflar tarafından değiştirilebilir ya da olduğu gibi kalabilir.

### 3. Nesne Oluşturulamaz:
Soyut sınıf bir nesne oluşturulamaz, sadece onu miras alan sınıflar üzerinden nesne oluşturulabilir.

```csharp
public abstract class Animal
{
    public string Name { get; set; }

    // Soyut metod (alt sınıflar tarafından implement edilmesi gerekir)
    public abstract void MakeSound();
}

public class Dog : Animal
{
    // Soyut metodun implementasyonu
    public override void MakeSound()
    {
        Console.WriteLine("Bark");
    }
}
```

## Abstract Soyutlama (Soyut Sınıflar ve Metodlar),
bir sınıfın veya metodun sadece temel yapısının tanımlandığı, ancak belirli bir işlem veya davranışın detaylarının alt sınıflara bırakıldığı bir kavramdır. Soyutlama, karmaşık sistemlerin daha basit ve anlaşılır hale getirilmesini sağlar. Soyut sınıf ve soyut metod kavramlarını anlamak için, aşağıdaki özellikleri ve mantığı inceleyebiliriz:

## 1. Soyut Sınıf (Abstract Class)
Soyut sınıf, diğer sınıfların türeyeceği bir temel sınıftır. Soyut sınıflar doğrudan örneklendirilemez (instance oluşturulamaz), sadece türemek amacıyla kullanılır. Soyut sınıf, hem somut (concrete) hem de soyut (abstract) metodlar içerebilir.

## Özellikler:
Soyut metotlar içerir (implement edilmesi gereken metotlar).
Somut metotlar da içerebilir (alt sınıflar tarafından kullanılabilir).
Soyut sınıflar doğrudan instansiyalanamaz, yalnızca türetilerek kullanılabilir.
2. Soyut Metod (Abstract Method)
Soyut metodlar, yalnızca başlıkları olan, fakat gövdeleri bulunmayan metotlardır. Bu metotlar, alt sınıflar tarafından implement edilmek zorundadır. Soyut metodlar soyut sınıflar içinde tanımlanır.

## Özellikler:
Bir gövdeye sahip değildir (yalnızca bir imza bulunur).
Alt sınıflar, bu metodun gövdesini sağlamak zorundadır.

# C# Soyutlama Örneği

Aşağıda C# dilinde soyut sınıf ve metodların kullanıldığı bir örnek bulunmaktadır:

```csharp
using System;

// Soyut sınıf
abstract class Animal
{
    // Soyut metod (alt sınıflar implement etmek zorunda)
    public abstract void Speak();

    // Somut metod (alt sınıf bunu kullanabilir, implement etmek zorunda değildir)
    public void Eat()
    {
        Console.WriteLine("Animal is eating.");
    }
}

// Alt sınıf (Concrete class)
class Dog : Animal
{
    // Soyut metodu implement etme zorunluluğu
    public override void Speak()
    {
        Console.WriteLine("Dog says: Woof!");
    }
}

// Alt sınıf (Concrete class)
class Cat : Animal
{
    // Soyut metodu implement etme zorunluluğu
    public override void Speak()
    {
        Console.WriteLine("Cat says: Meow!");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Animal sınıfının örneği alınamaz (soyut olduğu için)
        // Animal animal = new Animal(); // Hata verir
        
        // Alt sınıflardan örnekler alınabilir
        Animal myDog = new Dog();
        Animal myCat = new Cat();

        myDog.Speak(); // Dog says: Woof!
        myCat.Speak(); // Cat says: Meow!

        myDog.Eat();   // Animal is eating.
        myCat.Eat();   // Animal is eating.
    }
}
```
## Polimorfizm (Polymorphism),
 nesne yönelimli programlamanın (OOP) temel prensiplerinden biridir. Türkçede "çok biçimlilik" olarak adlandırılır. Polimorfizm, farklı sınıfların aynı metot veya özelliği kendi ihtiyaçlarına göre farklı şekillerde uygulayabilmesini sağlar. Bu sayede, aynı türdeki nesneler farklı davranışlar sergileyebilir.

Polimorfizm'in Temel Özellikleri:
Aynı Arayüz, Farklı Davranış:

Farklı sınıflar, aynı metot imzasını (isim ve parametreler) kullanarak farklı davranışlar sergileyebilir.

Örneğin, bir "Hayvan" sınıfının "SesCikar" metodu, "Köpek" sınıfında "Hav hav!", "Kedi" sınıfında ise "Miyav!" şeklinde farklı davranabilir.

Esneklik ve Genişletilebilirlik:

Polimorfizm, kodun daha esnek ve genişletilebilir olmasını sağlar. Yeni sınıflar eklenirken mevcut kod değiştirilmeden yeni davranışlar eklenebilir.

Kalıtım ve Arayüzlerle İlişkili:

Polimorfizm, genellikle kalıtım (inheritance) veya arayüzler (interfaces) kullanılarak gerçekleştirilir.

Örneğin, bir temel sınıf veya arayüz üzerinden türetilen sınıflar, aynı metotları farklı şekillerde uygulayabilir.
