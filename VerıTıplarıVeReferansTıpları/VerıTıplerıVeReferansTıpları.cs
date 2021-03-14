using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÖĞRENİM
{
    class VerıTıplerıVeReferansTıpları
    {
        static void Main(string[] args)
        {
            int number1 = 12;
            int number2 = 16;
            number1 = number2;
            number2 = 30;

            // number1 kaçtır? 16
            //int , decimal , double... veri tipleridir. 
            //Bunlara atanan değerler sonrasında başka bir şeye eşitlese de asıl atanan değer sabit kalır.
            //Yani tek seferelik eşitler

            int[] sayılar = new int[] {10, 230,32 };
            int[] sayılar1 = new int[] { 103, 226, 39 };
            sayılar = sayılar1;
            sayılar1[0] = 999;

            // sayılar ? 999

            Console.WriteLine(sayılar1);
            Console.ReadKey();





        }



    }
}
