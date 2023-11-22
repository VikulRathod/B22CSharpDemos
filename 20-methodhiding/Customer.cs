using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_methodhiding
{
    public class Customer
    {
        public Customer()
        {
            Console.WriteLine("Customer CTOR");
        }

        public void Print()
        {
            Console.WriteLine("Customer Print() method called");
        }

        public void PrintA()
        {
            Console.WriteLine("Customer PrintA() method called");
        }
    }

    public class SilverCustomer : Customer
    {
        public SilverCustomer()
        {
            Console.WriteLine("SilverCustomer CTOR");
        }

        new public void Print()
        {
            Console.WriteLine("SilverCustomer Print() method called");
        }

        public void PrintB()
        {
            Console.WriteLine("SilverCustomer PrintB() method called");
        }
    }
}
