using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28_sealedkeyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer();
            c1.Print();

            Customer c2 = new SilverCustomer();
            c2.Print();

            Customer c3 = new AdvancedSilverCustomer();
            c3.Print();

            Console.ReadLine();
        }
    }
}
