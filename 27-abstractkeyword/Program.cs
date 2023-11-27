using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_abstractkeyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SilverCustomer sc = new SilverCustomer();
            //sc.ShowTimings();
            //sc.PrintTicket();

            //GoldCustomer gc = new GoldCustomer();
            //gc.ShowTimings();
            //gc.PrintTicket();

            // Customer c = new Customer(); // abstract class object creation not possible
            Customer c1 = new SilverCustomer();
            c1.PrintTicket();
            Customer c2 = new GoldCustomer();
            c2.PrintTicket();
            Customer c3 = new PlatinumCustomer();
            c3.PrintTicket();


            Console.ReadLine();
        }
    }
}
