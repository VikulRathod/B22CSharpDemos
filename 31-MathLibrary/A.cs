using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31_MathLibrary
{
    public class A
    // internal class A
    // class A
    {
        // private void PrintA()
        // protected void PrintA()
        // public void PrintA()
        // internal void PrintA()
        protected internal void PrintA()
        {
            Console.WriteLine("PrintA()");
        }

        void Print()
        {
            PrintA();
        }
    }

    public class B : A
    {
        private void PrintB()
        {
            A a = new A();
            // a.PrintA(); // no accessibility
            // a.PrintA();
            //             base.PrintA();
            // a.Print();
            base.PrintA();

            Console.WriteLine("PrintB()");
        }
    }

    public class C
    {
        private void PrintC()
        {
            A a = new A();
            a.PrintA();
            Console.WriteLine("PrintC()");
        }
    }
}
