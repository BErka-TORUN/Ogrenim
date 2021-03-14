using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class Işlemler
    {
        List<string> müsteriler = new List<string>();

        public void Ekle(Musterı musterı)
        {
            Console.WriteLine("{0} adlı müşteri eklendi.", musterı);
    
        }

        public void Silme (Musterı musterı)
        {
            Console.WriteLine("{0} adlı müşteri silindi.", musterı);
            
        }

        public void Bılgıler(Musterı musterı)
        {
            Console.WriteLine("Ad:" + musterı.MusterıAd + "\t " + "Soyad:" + musterı.Soyad + "\t" + "Yas:" + musterı.Yas);
                
        }     
           

    }
}
