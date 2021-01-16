using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Yusuf";
            int age = 36;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmeni = "Engin demiroğ";
            kurs1.IzlenmeOrani = 68;
        
    
            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmeni = "Kerem Varış";
            kurs2.IzlenmeOrani = 64;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.Egitmeni = "Berkay Bilgin";
            kurs3.IzlenmeOrani = 80;

            //  Console.WriteLine(kurs1.KursAdi + " : " + kurs1.Egitmeni + " : " + kurs1.IzlenmeOrani);

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3};
            foreach (var kurs in kurslar)
            {
                Console.WriteLine("Kurs adı : " + kurs.KursAdi + " " + "Kurs eğitmeni : " + kurs.Egitmeni + " " + "Izlenme orani : " + kurs.IzlenmeOrani);
            }
        
        }
    }
    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmeni{ get; set; }
        public int IzlenmeOrani { get; set; }
    }
}
