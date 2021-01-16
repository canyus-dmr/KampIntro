using System;

namespace OdevClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.UrunAdi = "Ymc Kulaklık ";
            urun1.UrunTuru = "Elektronik Eşyalar ve Aksesüar";
            urun1.UrunFiyati = 30;

            Urun urun2 = new Urun();
            urun2.UrunAdi = "Programlamaya giriş ";
            urun2.UrunTuru = "Kitap";
            urun2.UrunFiyati = 40;
           
            Urun urun3 = new Urun();
            urun3.UrunAdi = "Klasik Gitar ";
            urun3.UrunTuru = "Müzik Aletleri";
            urun3.UrunFiyati = 120;

            Urun[] urunler = new Urun[]{ urun1, urun2, urun3 };
            
            foreach (var urun in urunler)
            {
                Console.WriteLine("Urun Adı : "  + urun.UrunAdi + " " + "Urun Turu : " + urun.UrunTuru + " " + "Urun Fiyatı : "  + urun.UrunFiyati + " tl ");
            }
            
            Console.WriteLine("----------------------Foreach bitti-----------------------");
            
            for (int i = 0; i < urunler.Length; i++)
            {
                Console.WriteLine("Urun Adı : " + urunler[i].UrunAdi + " " + "Urun Turu : " + urunler[i].UrunTuru + " " + "Urun Fiyatı : " + urunler[i].UrunFiyati + " tl ");
            }
            Console.WriteLine("----------------------For bitti-----------------------");

            int j = 0;
            while (j < urunler.Length)
            {
                Console.WriteLine("Urun Adı : " + urunler[j].UrunAdi + " " + "Urun Turu : " + urunler[j].UrunTuru + " " + "Urun Fiyatı : " + urunler[j].UrunFiyati + " tl ");
                j++;
            }
            Console.WriteLine("----------------------While bitti-----------------------");
        }
    }
    class Urun
    {
        public string UrunAdi { get; set; }
        public string UrunTuru { get; set; }

        public int UrunFiyati { get; set; }



    }
}
