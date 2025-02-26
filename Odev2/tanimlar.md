# Abstract Class (Soyut Sınıf) Nedir?

**Abstract Class (Soyut Sınıf)**, nesne yönelimli programlamada (OOP) doğrudan nesne oluşturulamayacak ve genellikle başka sınıflar tarafından miras alınarak kullanılacak sınıflardır. Soyut sınıflar, genel bir şablon sunar ve alt sınıfların bu şablona uygun şekilde davranmasını sağlar. Soyut sınıflar, sadece ortak özellikleri ve genel metotları tanımlar, ancak bazı metotların gerçek implementasyonu alt sınıflara bırakılabilir.

## Bir soyut sınıfın bazı özellikleri şunlardır:

### 1. Soyut Metotlar:

Soyut sınıf içinde implementasyonu olmayan metodlar bulunabilir. Bu metodlar alt sınıflar tarafından **override** edilerek implement edilir.

### 2. Soyut Olmayan Metotlar:

Soyut sınıflarda implementasyonu yapılmış metotlar da bulunabilir. Bu metotlar alt sınıflar tarafından değiştirilebilir ya da olduğu gibi kalabilir.

### 3. Nesne Oluşturulamaz:

Soyut sınıf bir nesne oluşturulamaz, sadece onu miras alan sınıflar üzerinden nesne oluşturulabilir.
`
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
}`
