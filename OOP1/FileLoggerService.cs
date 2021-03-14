using System;

namespace OOP1
{
    class FileLoggerService : ILoggerServiceManager
    {
        public void Log()
        {
            Console.WriteLine("Dosyaya 'log'landı.");
        }
    }
}
