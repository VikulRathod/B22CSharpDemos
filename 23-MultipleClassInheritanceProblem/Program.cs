using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_MultipleClassInheritanceProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            A a1 = new A();
            a1.Print(); // A A

            B b1 = new B();
            b1.Print(); // A B

            C c1 = new C();
            c1.Print();// C

            D d1 = new D(); // D : B
            d1.Print(); // A B


            int i = 10, j = 10;
            int k = i + j;

            if(i == j)
            {
                Console.WriteLine("i & j are EQUAL");
            }

            A a2 = new A() { Name = "Ajay"};
            A a3 = new A() { Name = "Ajay"};

            // A a4 = a2 + a3;

            if(a2 == a3)
            {
                Console.WriteLine("a2 & a3 are EQUAL");
            }
            else
            {
                Console.WriteLine("a2 & a3 are NOT EQUAL");
            }



            Console.ReadLine();
        }
    }
}
