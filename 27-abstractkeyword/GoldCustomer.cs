using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_abstractkeyword
{
    public class GoldCustomer : Customer
    {
        //public void Print(string s)
        //{
        //    Console.WriteLine("Gold Ticket Printed");
        //}
        public override void PrintTicket()
        {
            Console.WriteLine("Gold Ticket Printed");
        }
    }
}
