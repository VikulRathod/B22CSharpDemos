using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _43_Delegates
{

    public delegate void PrintDelegate(string a); // 1st delegate declaration

    internal class Program
    {
        static void Main(string[] args)
        {
            //// PrintA("Vishal"); // method call

            //// PrintDelegate pd = new PrintDelegate(PrintA); // 2nd delegate instance
            //PrintDelegate pd = PrintA;

            //pd("Mahesh"); // 3rd delegate call / invoke

            //PrintDelegate pd1 = PrintA;
            //PrintDelegate pd2 = PrintB;
            //PrintDelegate pd3 = PrintC;

            //PrintDelegate pd = pd1 + pd2 + pd3 - pd2;

            //pd("Vishal");

            PrintDelegate pd = PrintA;
            pd += PrintB;
            pd += PrintC;
            pd -= PrintA; // de register

            pd("Mahesh");

            Console.ReadLine();
        }

        static void PrintA(string name)
        {
            Console.WriteLine($"PrintA() : Hello, {name}");
        }
        static void PrintB(string name)
        {
            Console.WriteLine($"PrintB() : Welcome, {name}");
        }
        static void PrintC(string name)
        {
            Console.WriteLine($"PrintC() : Good Morning, {name}");
        }

        static string GetName()
        {
            return "Vishal";
        }
    }
}
