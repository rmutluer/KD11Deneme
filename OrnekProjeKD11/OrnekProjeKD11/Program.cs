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
            int toplam = sayi1+ sayi2;
            Console.WriteLine("Gönderilen 2 sayının toplamı: " +toplam);


            string isim = "Bilge Adam";
            string isim2 = "Boost Yıldız Yazılımcı";
            EkranaYazdir(isim);
            Console.ReadLine();
        }

       

        private static void EkranaYazdir(string isim)
        {
            Console.WriteLine("Hoşgeldiniz {0}!", isim);
        }
    }
}
