using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_abstractkeyword
{
    public abstract class Customer
    {
        public Customer()
        {
            Console.WriteLine("Customer() Called");
        }

        public void ShowTimings()
        {
            Console.WriteLine("** ALL TODAYS SHOWS **");
        }

        //public virtual void PrintTicket()
        //{
        //    // no logic / implementation
        //}

        public abstract void PrintTicket(); // only declaration
    }
}
