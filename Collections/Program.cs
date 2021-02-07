using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> isimler = new List<string> { "Yasin", "Ertaş" };
            // isimler.Add("Yasin");
            // isimler.Add("Ertaş");
            Console.WriteLine(isimler[0]);
            Console.WriteLine(isimler[1]);
            isimler.Add("Engin");
            Console.WriteLine(isimler[2]);
            isimler.Add("Veli");
            Console.WriteLine(isimler[3]);

            Console.ReadKey();
        }
    }
}
