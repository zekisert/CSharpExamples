using System;

namespace Example___1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Değişkenler Konusu Alıştırması");

            Console.Write("İsminizi Giriniz ");
            string isim = Console.ReadLine();

            Console.Write("Sipariş Miktarını Giriniz ");
            string miktar = Console.ReadLine();

            Console.Write("E-mail Adresini Giriniz ");
            string email = Console.ReadLine();

            Console.Clear();

            Console.WriteLine("Musteri Adi : " + isim);
            Console.WriteLine("Siparis Miktari : " + miktar);
            Console.WriteLine("E-Mail : " + email);

            Console.ReadLine();
        }
    }
}
