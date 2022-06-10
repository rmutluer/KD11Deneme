using System;

namespace OrnekProjeKD11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Merhaba GitHub!");

            string isim = "Bilge Adam";
            EkranaYazdir(isim);
            Console.ReadLine();
        }

        private static void EkranaYazdir(string isim)
        {
            Console.WriteLine("Hoşgeldiniz {0}!", isim);
        }
    }
}
