using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_methodoverloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator c1 = new Calculator();
            c1.Print();

            c1.Print(10);

            // c1.Print(10);

            int i = 10;
            c1.Print(ref i);

            c1.Print(10, 20);

            c1.Print("Vishal");

            c1.Print(1, "Vishal");

            c1.Print("Vishal", 1);

            short s = 10;
            int i1 = 10;

            c1.Print(10);

            c1.Print(s);

            Console.ReadLine();
        }
    }
}
