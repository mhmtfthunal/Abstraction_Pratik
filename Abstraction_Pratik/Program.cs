using System;

namespace Abstraction_Pratik
{
    public abstract class Calisan
    {
        public string Ad { get; }
        public string Soyad { get; }
        public string Departman { get; }

        protected Calisan(string ad, string soyad, string departman)
        {
            Ad = ad;
            Soyad = soyad;
            Departman = departman;
        }

        public abstract string Pozisyon { get; }
        public abstract void Gorev();

        public override string ToString() => $"{Ad} {Soyad} — {Departman} / {Pozisyon}";
    }

    public class YazilimGelistirici : Calisan
    {
        public YazilimGelistirici(string ad, string soyad, string departman)
            : base(ad, soyad, departman) { }

        public override string Pozisyon => "Yazılım Geliştirici";
        public override void Gorev() => Console.WriteLine("Yazılım geliştirici olarak çalışıyorum.");
    }

    public class ProjeYoneticisi : Calisan
    {
        public ProjeYoneticisi(string ad, string soyad, string departman)
            : base(ad, soyad, departman) { }

        public override string Pozisyon => "Proje Yöneticisi";
        public override void Gorev() => Console.WriteLine("Proje yöneticisi olarak çalışıyorum.");
    }

    public class SatisTemsilcisi : Calisan
    {
        public SatisTemsilcisi(string ad, string soyad, string departman)
            : base(ad, soyad, departman) { }

        public override string Pozisyon => "Satış Temsilcisi";
        public override void Gorev() => Console.WriteLine("Satış temsilcisi olarak çalışıyorum.");
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ad: ");
            string ad = Console.ReadLine();

            Console.Write("Soyad: ");
            string soyad = Console.ReadLine();

            Console.Write("Departman: ");
            string departman = Console.ReadLine();

            Console.WriteLine("\nPozisyon Seçiniz:");
            Console.WriteLine("1 - Yazılım Geliştirici");
            Console.WriteLine("2 - Proje Yöneticisi");
            Console.WriteLine("3 - Satış Temsilcisi");
            Console.Write("Seçiminiz: ");
            string secim = Console.ReadLine();

            Calisan calisan = secim switch
            {
                "1" => new YazilimGelistirici(ad, soyad, departman),
                "2" => new ProjeYoneticisi(ad, soyad, departman),
                "3" => new SatisTemsilcisi(ad, soyad, departman),
                _ => null
            };

            if (calisan != null)
            {
                Console.WriteLine($"\n{calisan}");
                calisan.Gorev();
            }
            else
            {
                Console.WriteLine("Geçersiz seçim yaptınız.");
            }

            Console.WriteLine("\nProgram bitti. Devam etmek için tuşa basın...");
            Console.ReadKey();
        }
    }
}
