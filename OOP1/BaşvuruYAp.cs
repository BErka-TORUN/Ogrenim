using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class BaşvuruYAp
    {
        public void BaşvuruYap(IKredıManager kredıManager,ILoggerServiceManager logger)
        {
            kredıManager.Hesapla();
            logger.Log();
        }

        public void OnBilgilendirmeYap(List<IKredıManager> kredıler)
        {
            foreach (var kredı in kredıler)
            {
                kredı.Hesapla();
            }
        }

        internal void BaşvuruYap(IKredıManager kredıManager, List<ILoggerServiceManager> loggers)
        {
            kredıManager.Hesapla();
            foreach (var logger in loggers)
            {
                logger.Log();
            }
        }
    }
}
