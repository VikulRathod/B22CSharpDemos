using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Inheritance
{
    // parent class / base class
    public class Customer
    {
        public int TicketAmount;
        public string Name = "Customer";

        public Customer()
        {
            Console.WriteLine("Customer() Constructor Called");
        }

        public Customer(string n)
        {
            Console.WriteLine($"Inside Customer(string n) : {n}");
        }

        public void ShowsTimings()
        {
            // Console.WriteLine("** ALL TODAYS SHOWS **");
            Console.WriteLine("** NO SHOWS TODAY **");
        }
        public void GetTicketAmount()
        {
            Console.WriteLine($"Ticket Amount is : {TicketAmount}");
        }
    }
}
