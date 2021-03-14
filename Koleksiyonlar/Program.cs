using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> isimler = new List<string>();

            isimler.Add("berka");
            isimler.Add("faruk");
            isimler.Add("tekin");

            foreach (var isim in isimler)
            {
                Console.WriteLine(isim);
            }
            Console.WriteLine(isimler.Count);
            Console.ReadKey();


        }
    }
}
