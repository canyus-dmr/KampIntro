using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Gelistirici yetistirme kampı";
            string kurs2 = "Programlamaya baslangic kursu";
            string kurs3 = "Java";

            string[] kurslar = new string[] { "Yazılım Gelistirici yetistirme kampı", "Programlamaya baslangic kursu", "Java","Python" };

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("For bitti");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }


            Console.WriteLine("Sayfa sonu");
        }
    }
}
