using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyLisrt<string> isimler = new MyLisrt<string>();
            isimler.Add("berka");
            isimler.Add("torun");

            foreach (var isim in isimler.Items)
            {
                Console.WriteLine(isim);
            }

            
            Console.ReadKey();

        }
    }
}
