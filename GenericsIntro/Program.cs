using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> names = new MyList<string>();
            names.Add("Yasin");
            names.Add("Engin");

            MyDictionary<int, string> cities = new MyDictionary<int, string>();
            cities.Add(52, "Ordu");
            cities.Add(54, "Sakarya");

            Console.WriteLine(cities.Length);

        }
    }
}
