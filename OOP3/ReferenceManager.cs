using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    //Başvuru
    class ReferenceManager
    {
        //başvuru kredi bağımsız
        //method injection
        public void Apply(ICreditManager creditManager, List<ILoggerService> loggerServices)
        {
            //gönderilen kredinin hesapla metodu çalışır
            creditManager.Calculate();

            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
        }
        public void KrediOnBilgilendirmesiYap(List<ICreditManager> credits)
        {
            foreach (var credi in credits)
            {
                credi.Calculate();
            }
        }
    }
}
