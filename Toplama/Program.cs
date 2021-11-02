using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toplama
{
    class Program
    {
        static void Main(string[] args)
        {
            int s1 = 10;
            int s2 = 15;
            int toplamInt = s1 + s2;

            byte s3 = 10;
            byte s4 = 10;
            int toplamByte = s3 + s4;

            string metin1 = "Merhaba";
            int s5 = 10;
            string toplamStr = metin1 + s5;

            string toplamStr2 = s5 + metin1;

            string metin2 = " Dünya";
            string toplamstr3 = metin1 + metin2;
        }
    }
}
