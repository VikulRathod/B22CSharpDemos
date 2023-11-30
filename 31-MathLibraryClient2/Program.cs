using _31_MathLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31_MathLibraryClient2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome Client 2");

            Calculator c1 = new Calculator();
            c1.Add(10,5);

            Console.WriteLine("Thank You. Visit Again");

            Console.ReadLine();
        }
    }
}
