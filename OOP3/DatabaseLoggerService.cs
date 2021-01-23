using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class DatabaseLoggerService : ILoggerService
    {
        //simulation
        public void Log()
        {
            Console.WriteLine("Veri tabanına loglandı");
        }
    }
}
