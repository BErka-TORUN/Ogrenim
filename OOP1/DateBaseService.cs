using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class DateBaseService : ILoggerServiceManager
    {
        public void Log()
        {
            Console.WriteLine("Veri tabanı 'log'landı.");
        }
    }
}
