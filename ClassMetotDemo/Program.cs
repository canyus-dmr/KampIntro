using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Musteri musteri1 = new Musteri();
            Musteri musteri2 = new Musteri();
            Musteri musteri3 = new Musteri();

            musteri1.Ad = "Yusuf";
            musteri1.Soyad = "Demir";
            musteri1.Yas = 39;

            musteri2.Ad = "Sezgin";
            musteri2.Soyad = "Bezgin";
            musteri2.Yas = 19;

            musteri3.Ad = "Asli";
            musteri3.Soyad = "Saatçi";
            musteri3.Yas = 29;

            

            Musteri[] musteriler = new Musteri[]{ musteri1, musteri2, musteri3 };

            MusteriManager musteriManager = new MusteriManager();
            

            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);
            Console.WriteLine("-----------------------");
            musteriManager.Sil(musteri2);
            Console.WriteLine("-----------------------");
            musteriManager.Listele(musteri1);
            musteriManager.Listele(musteri2);
            musteriManager.Listele(musteri3);

            
        }
    }
}
