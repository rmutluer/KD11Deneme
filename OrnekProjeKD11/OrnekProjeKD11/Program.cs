using System;

namespace OrnekProjeKD11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Merhaba GitHub!");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            int sayi2= Convert.ToInt32(Console.ReadLine());
            int toplam = ToplamaYap(sayi1, sayi2);


            string isim = "Bilge Adam";
            EkranaYazdir(isim);
            Console.ReadLine();
        }

        private static int ToplamaYap(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        private static void EkranaYazdir(string isim)
        {
            Console.WriteLine("Hoşgeldiniz {0}!", isim);
        }
    }
}
