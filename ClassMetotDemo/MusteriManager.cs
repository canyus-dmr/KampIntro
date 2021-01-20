using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Müşteri ekle:" + musteri.Ad + " " + musteri.Soyad);
            Console.WriteLine("Müşteri Yaş:" + musteri.Yas);
        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Müşteri silindi:" + musteri.Ad + " " + musteri.Soyad);
        }
        public void Listele(Musteri musteri)
        {
            Console.WriteLine("Müşteri listele:" + musteri.Ad + " " + musteri.Soyad);
        }
    }
}
