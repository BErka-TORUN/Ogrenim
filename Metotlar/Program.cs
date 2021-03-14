using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Product urun1 = new Product();
            urun1.Ad = "elma";
            urun1.Fiyat = 13;
            urun1.Açıklama = "Amasya";


            Product urun2 = new Product();
            urun2.Ad = "portakal";
            urun2.Fiyat = 15;
            urun2.Açıklama = "Mersin";

            Product[] urunler = new Product[] {urun1,urun2 };
            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.Ad);
                Console.WriteLine(urun.Açıklama);
                Console.WriteLine(urun.Fiyat);
                Console.WriteLine("---------------");
            }

            Console.WriteLine("-------------metotlar-----------");


            SepetMenager ekle = new SepetMenager();
            ekle.Ekle(urun1);
            ekle.Ekle(urun2);

            


            Console.ReadKey();



        }
    }
}
