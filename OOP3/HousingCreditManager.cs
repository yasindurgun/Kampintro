using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class HousingCreditManager : ICreditManager
    {
        public void Calculate()
        {
            //simulation
            Console.WriteLine("Konut kredisi ödeme planı hesaplandı.");
        }

        public void makeSomething()
        {
            throw new NotImplementedException();
        }
    }
}
