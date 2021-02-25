using System;

namespace CampIntro2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> products = new MyDictionary<int, string>();
            products.Add(52364892, "Mavi Jean");
            products.Add(59518415, "Siyah Kaban");
            products.Add(52974625, "Ekru Jean");
            products.Add(59614854, "Bordo Kaban");
            Console.WriteLine(products.Count);


        }
    }
}
