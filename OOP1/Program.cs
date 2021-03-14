using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            //KonutKradıManager konutKradıManager = new KonutKradıManager(); şeklinde de olabilir
            IKredıManager konutKradıManager = new KonutKradıManager();
            IKredıManager IhtıyaçKradıManager = new IhtıyaçKradıManager();
            IKredıManager TaşıtKradıManager = new TaşıtKradıManager();

            List<ILoggerServiceManager> loggers = new List<ILoggerServiceManager>() {
                new DateBaseService(),
                new FileLoggerService()};

            ILoggerServiceManager database = new DateBaseService();
            BaşvuruYAp başvuru = new BaşvuruYAp();
            //başvuru.BaşvuruYap(IhtıyaçKradıManager,database );
            //başvuru.BaşvuruYap(TaşıtKradıManager,new FileLoggerService()); 

            başvuru.BaşvuruYap(TaşıtKradıManager, loggers);

            List<IKredıManager> kredıler = new List<IKredıManager>() {IhtıyaçKradıManager,konutKradıManager,TaşıtKradıManager };
            //başvuru.OnBilgilendirmeYap(kredıler);

            Console.ReadKey();
        }
    }
}
