using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.ID = 123;
            musteri1.MusteriNo = "213";

            TuzelMusteri tuzelMusteri1= new TuzelMusteri();
            tuzelMusteri1.ID = 2322;
            tuzelMusteri1.MusteriNo = "2335";
            tuzelMusteri1.ŞirketNo = "5656556";

            GerçekMusteri gerçekMusteri1 = new GerçekMusteri();
            gerçekMusteri1.ID = 1321;
            gerçekMusteri1.Ad = "berka";
            gerçekMusteri1.Soyad = "torun";
            gerçekMusteri1.TcNo = "36885";

            MusterıManager musterıManager = new MusterıManager();
            musterıManager.Ekle(musteri1);
            musterıManager.Ekle(tuzelMusteri1);
            musterıManager.Ekle(gerçekMusteri1);



        }
    }
}
