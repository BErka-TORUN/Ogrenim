using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÖĞRENİM
{
    class Dögüler
    {
        static void Main(string[] args)
        {
            Urun ürün1 = new Urun();
            ürün1.urunad = "oyuncak ayı";
            ürün1.fıyat = 123;


            Urun ürün2 = new Urun();
            ürün2.urunad = "oyuncak panda";
            ürün2.fıyat = 465;

            Urun ürün3 = new Urun();
            ürün3.urunad = "oyuncak araba";
            ürün3.fıyat = 565;


            Urun[] oyuncaklar = new Urun[] { ürün1, ürün2, ürün3 };

            Console.WriteLine("--------------");
            Console.WriteLine("FOREACH");

            foreach (var oyuncak in oyuncaklar)
            {
                Console.WriteLine(oyuncak.urunad + ":" + oyuncak.fıyat);
            }
            Console.WriteLine("--------------");
            Console.WriteLine("FOR");
            Console.WriteLine("--------------");

            for (int i = 0; i < oyuncaklar.Length; i++)
            {
                Console.WriteLine(oyuncaklar[i].urunad + ":" + oyuncaklar[i].fıyat);
            }

            Console.WriteLine("--------------");
            Console.WriteLine("WHİLE");
            Console.WriteLine("--------------");

            int x = 0;
            while (x<oyuncaklar.Length)
            {
                Console.WriteLine(oyuncaklar[x].urunad + ":" + oyuncaklar[x].fıyat);
                x++;
            }
            


            Console.WriteLine("hello");
            Console.ReadKey();

        }
    }
    class Urun
    {
        public string urunad { get; set; }
        public int fıyat { get; set; }
        
    }






}