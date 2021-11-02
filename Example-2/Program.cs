using System;

namespace Example_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Merhaba
             * İsminiz :
             * Soyisim :
             * Şehir :
             * Yaş :
             * Ekran Temizle
             */

            Console.WriteLine("Merhaba");

            Console.Write("İsminizi Giriniz : ");
            string isim = Console.ReadLine();

            Console.Write("Soyisminizi Giriniz : ");
            string soyisim = Console.ReadLine();

            Console.Write("Şehrinizi Giriniz : ");
            string sehir = Console.ReadLine();

            Console.Write("Yaşınızı Giriniz");
            string yas = Console.ReadLine();

            yas = Convert.ToString(yas);

            Console.Clear();

            Console.WriteLine("Ad : " + isim);
            Console.WriteLine("Soyad : " + soyisim);
            Console.WriteLine("Şehir : " + sehir);
            Console.WriteLine("Yaş : " + yas);

            Console.ReadLine();

        }
    }
}
