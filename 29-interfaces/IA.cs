using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29_interfaces
{
    public interface IA
    {
        void PrintA();
        void Print();
    }

    public interface IB
    {
        void PrintB();
        void Print();
    }

    public class B { }

    public class A : B, IA, IB
    {
        void IA.Print()
        {
            Console.WriteLine("IA : Print()");
        }
        void IB.Print()
        {
            Console.WriteLine("IB : Print()");
        }

        public void PrintA()
        {
            Console.WriteLine("IA : PrintA()");
        }

        public void PrintB()
        {
            Console.WriteLine("IB : PrintB()");
        }
    }
}
