using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class PersonalFinanceCreditManager : ICreditManager
    {
        public void Calculate()
        {
            //simulation
            Console.WriteLine("İhtiyaç kredisi ödeme planı hesaplandı.");
        }

        public void makeSomething()
        {
            throw new NotImplementedException();
        }
    }
}
