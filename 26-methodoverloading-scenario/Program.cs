using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_methodoverloading_scenario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            a.PrintA();

            B b = new B();
            b.PrintA(10); // coming from class B
            b.PrintA(); // coming from class A

            Console.ReadLine();
        }
    }

    class A
    {
        public void PrintA()
        {
            Console.WriteLine("A : PrintA()");
        }
    }
    class B : A
    {
        public void PrintA(int a)
        {
            Console.WriteLine("B : PrintA(int a)");
        }
    }
}
