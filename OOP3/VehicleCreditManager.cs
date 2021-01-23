using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class VehicleCreditManager : ICreditManager
    {
        public void Calculate()
        {
            //simulation
            Console.WriteLine("Taşıt kredisi ödeme planı hesaplandı.");
        }

        public void makeSomething()
        {
            throw new NotImplementedException();
        }
    }
}
