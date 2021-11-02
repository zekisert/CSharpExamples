using System;

namespace _2_StringVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            string isim = "Zeki SERT";
            Console.WriteLine(isim);
            isim = "Asel SERT";
            Console.WriteLine(isim);

            string buyukKarakter = isim.ToUpper();
            string kucukKarakter = isim.ToLower();
            string belirliBirBolum = isim.Substring(2, 4);

            Console.ReadLine();
        }
    }
}
