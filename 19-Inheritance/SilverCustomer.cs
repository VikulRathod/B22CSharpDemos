using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Inheritance
{
    // child class / derived class
    public class SilverCustomer : Customer
    {
        // public int TicketAmount; // field
        public string Name = "Silver Customer";
        //public SilverCustomer()  // constructor
        //{
        //    Console.WriteLine("SilverCustomer() Constructor Called");
        //    //Console.WriteLine($"Name from current class : {this.Name}");
        //    //Console.WriteLine($"Name from base class : {base.Name}");
        //    TicketAmount = 150;
        //}

        // constructor chain
        public SilverCustomer(string name) : base(name)
        {
            Console.WriteLine($"Inside SilverCustomer(string name) : {name}");
        }

        //public void ShowsTimings()
        //{
        //    Console.WriteLine("** ALL TODAYS SHOWS **");
        //}

        //public void GetTicketAmount()
        //{
        //    Console.WriteLine($"Ticket Amount is : {TicketAmount}");
        //}

        public void PrintTicket()
        {
            Console.WriteLine("Silver Ticket Printed");
        }
    }
}
