using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_abstractkeyword
{
    public class PlatinumCustomer : Customer
    {
        public override void PrintTicket()
        {
            Console.WriteLine("Platinum Ticket Printed");
        }
    }
}
