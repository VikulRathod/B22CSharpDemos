using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Inheritance
{
    public class PlatinumCustomer : Customer
    {
        public PlatinumCustomer()
        {
            Console.WriteLine("PlatinumCustomer() Constructor Called");
            TicketAmount = 400;
        }

        public void PrintTicket()
        {
            Console.WriteLine("Platinum Ticket Printed");
        }
    }
}
