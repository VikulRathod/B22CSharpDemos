using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SilverCustomer sc1 = new SilverCustomer();
            //sc1.ShowsTimings();
            //sc1.GetTicketAmount();
            //sc1.PrintTicket();

            //GoldCustomer gc1 = new GoldCustomer();
            //gc1.ShowsTimings();
            //gc1.GetTicketAmount();
            //gc1.PrintTicket();

            //PlatinumCustomer pc1 = new PlatinumCustomer();
            //pc1.ShowsTimings();
            //pc1.GetTicketAmount();
            //pc1.PrintTicket();

            // if we have parent & child class
            // object creation

            //Customer c1 = new Customer();
            //// c1 is a reference variable of type Customer pointing Customer type object

            //SilverCustomer sc1 = new SilverCustomer();
            //// sc1 is reference variable of type SilverCustomer pointing to SilverCustomer type object

            //Customer c2 = new SilverCustomer();
            //// c2 is reference varibale of type Customer pointing to SilverCustomer type object

            //// SilverCustomer sc2 = new Customer(); // compiler error
            //// SilverCustomer sc2 = (SilverCustomer) new Customer(); // runtime error

            // Customer c1 = new Customer();

            Customer c2 = new SilverCustomer("Chetan");

            Console.ReadLine();
        }
    }
}
