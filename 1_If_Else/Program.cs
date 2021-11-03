using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_If_Else
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Sayı 1 değerini giriniz :");
            string sStr1 = Console.ReadLine();
            Console.Write("Sayı 2 değerini giriniz :");
            string sStr2 = Console.ReadLine();

            decimal sayi1 = Convert.ToDecimal(sStr1);
            decimal sayi2 = Convert.ToDecimal(sStr2);
            decimal toplam = sayi1 + sayi2;

            bool toplamKontrol = toplam > 50;

            if (toplamKontrol == true)
            {
                Console.WriteLine("Girmiş olduğunuz değerlerin toplamı 50 den büyük");
            }
            else
            {
                Console.WriteLine("Girmiş olduğunuz değerlerin toplamı 50 den küçük");
            }
        }
    }
}
