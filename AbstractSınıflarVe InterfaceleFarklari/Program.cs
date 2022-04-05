using System;

namespace AbstractSınıflarVe_InterfaceleFarklari
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            MevzuatBase[] mevzuatlar = new MevzuatBase[2] { new AMevzuat(), new BMevzuat() };
            foreach (MevzuatBase mevzuat in mevzuatlar)
            {
                mevzuat.Degerlendir();
                mevzuat.Kaydet();
            }
        }
    }
}
/*Abstract Class 
 * Yapı olarak interface görümüne sahiptir ve bir class degildir
 * sadece refarans type dir ve referance tutar
 * ama classlarda referans tiptir ama tamamen somut bir yapıya sahiptir
 * o somut yapılardan kastığımız classların içinde yapıalrın bulunmasıdır;
 * class birbiriyle ilgili operasyonlar tutar
 * 
 * class CustomerManager{
 *  public void Add()
    {
      
    }
    public void Delete()
    {

    }
}

aynı zamanda classlar field yani property de tutabilir.

class Customer
{
    public int Id { get; set; }
    public string Name { get; set; }
}

İnterface de neydi her şey yarımdı tamamlanmış operasyon yoktu
peki Abstract Sınıf neydi?
Abstract sınıflar hem tamamlanmış hem de tamamlanmamış operasyonlar içeriyor.
aslında tamamlanmamış operasyondan kasıt ve çok daha farklı yapısal olarak farklılık
 * örneğin
 * class CustomerManager
    {
    public void Add()
    {
        Console.WriteLine("Added");
    }
    public void Delete();
    
 *
 *İnterface lerdeki gibi yarım ve classlardaki gibi tamamlanmış operasyonlar içeriyoruz.
 *Abstract class içindeki metotları kim kullanıyorsa onu kendine göre tanımlamak zorunda
 *
 *Bide mesala onu implemente eden classlarda ortak bir kod olsun
 *Kaydet içini abstract classda yazıyoruz 
 *ve yukarda yaptığım örnekte 2 si içinde oldugunu görüyoruz.
 *abstract classlar newlenemez unutma
 *bir sınıf sadece bir abstract class ı inherit edebilir.
 *abstract classlar constructor içerebilir ve constructoru protected olması lazım
 *
 *
 */
class CustomerManager
{
    public void Add()
    {
        Console.WriteLine("Added");
    }
    public void Delete()
    {
        Console.WriteLine("Deleted");
    }
}
abstract class MevzuatBase
{
   public abstract void Degerlendir();
   public void Kaydet()
    {
        Console.WriteLine("Kaydedildi");
    }

}
class AMevzuat : MevzuatBase
{
    public override void Degerlendir()
    {
        Console.WriteLine("A mevzuatına göre degerlendirme ");

    }
}
class BMevzuat : MevzuatBase
{
    public override void Degerlendir()
    {
        Console.WriteLine("B mevzuatına göre degerlendirildi");
    }
}