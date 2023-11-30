using _31_MathLibrary;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31_MathLibraryClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Calculator App");

            //int a = 10, b = 0;
            //int c = a / b;

            Calculator c1 = new Calculator();
            Console.WriteLine("Please enter first number");
            int first = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter second number");
            int second = int.Parse(Console.ReadLine());

            c1.Add(first, second);

            Console.WriteLine("Thank You For Using Calculator App");

            Console.ReadLine();
        }
    }

    public class X
    {
        void PrintX()
        {
            A a = new A();
            // a.PrintA();
            Console.WriteLine("PrintX()");
        }
    }

    public class Y : A
    {
        void PrintY()
        {
            //A a = new A();
            //a.PrintA();
            base.PrintA();
            Console.WriteLine("PrintY()");
        }
    }
}
