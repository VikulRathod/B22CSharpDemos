using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Inheritance
{
    // child class / derived class
    public class GoldCustomer : Customer
    {
        // public int TicketAmount;

        public GoldCustomer()
        {
            Console.WriteLine("GoldCustomer() Constructor Called");
            TicketAmount = 250;
        }

        //public void ShowsTimings()
        //{
        //    Console.WriteLine("** ALL TODAYS SHOWS **");
        //}

        //public void GetTicketAmount()
        //{
        //    Console.WriteLine($"Ticket Amount Is : {TicketAmount}");
        //}

        public void PrintTicket()
        {
            Console.WriteLine("Gold Ticket Printed");
        }
    }
}
