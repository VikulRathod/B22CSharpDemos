using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_abstractkeyword
{
    public class SilverCustomer : Customer
    {
        public override void PrintTicket()
        {
            Console.WriteLine("Silver Ticket Printed");
        }
    }
}
