using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //PersonalFinanceCreditManager personalFinanceCreditManager = new PersonalFinanceCreditManager();
            //personalFinanceCreditManager.Calculate();

            //VehicleCreditManager vehicleCreditManager = new VehicleCreditManager();
            //vehicleCreditManager.Calculate();

            //HousingCreditManager housingCreditManager = new HousingCreditManager();
            //housingCreditManager.Calculate();

            //Reference type
            ICreditManager personalFinanceCreditManager = new PersonalFinanceCreditManager();
            ICreditManager vehicleCreditManager = new VehicleCreditManager();
            ICreditManager housingCreditManager = new HousingCreditManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            //List<ILoggerService> loggers = new List<ILoggerService> { new SmsLoggerService(), new FileLoggerService() };
            List<ILoggerService> loggers = new List<ILoggerService> { databaseLoggerService, fileLoggerService };

            ReferenceManager referenceManager = new ReferenceManager();
            //alternatif kullanım
            //referenceManager.Apply(vehicleCreditManager, new DatabaseLoggerService());

            referenceManager.Apply(housingCreditManager, loggers);
            Console.WriteLine("*******************");
            referenceManager.Apply(new TradesCreditManager(), new List<ILoggerService> {new DatabaseLoggerService(), new SmsLoggerService() });
            Console.WriteLine("*******************");
            referenceManager.Apply(new VehicleCreditManager(), loggers);


            Console.WriteLine("\nÖn Bilgilendirme.\n");
            List<ICreditManager> credits = new List<ICreditManager>() { personalFinanceCreditManager, vehicleCreditManager, housingCreditManager };
            referenceManager.KrediOnBilgilendirmesiYap(credits);


            Console.ReadKey();
        }
    }
}
