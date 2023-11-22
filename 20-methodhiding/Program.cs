using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _20_methodhiding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Customer c1 = new Customer();
            ////c1.Print();
            ////c1.PrintA();
            ////// c1.PrintB(); // method is not there in Customer class

            //SilverCustomer sc = new SilverCustomer();
            ////sc.Print();
            ////sc.PrintA();
            ////sc.PrintB();

            //Customer c2 = new SilverCustomer();
            ////c2.Print();
            ////c2.PrintA();
            ////// c2.PrintB();
            ////((SilverCustomer)c2).PrintB();

            //// SilverCustomer sc2 = new Customer(); // not possible
            //// sc2.Print();

            // A -> B -> C
            A a1 = new A(); a1.Print(); // A
            B b1 = new B(); b1.Print(); // B
            C c1 = new C(); c1.Print(); // C

            A a2 = new B(); a2.Print(); // A
            A a3 = new C(); a3.Print(); // A

            // C c2 = new B(); // c2.Print() // compiler error

            B b2 = new C(); b2.Print(); // B

            Console.ReadLine();
        }
    }

    class A
    {
        public void Print()
        {
            Console.WriteLine("A");
        }
    }
    class B : A
    {
        new public void Print()
        {
            Console.WriteLine("B");
        }
    }
    class C : B
    {
        new public void Print()
        {
            Console.WriteLine("C");
        }
    }
}
