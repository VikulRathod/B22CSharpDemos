using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_methodoverriding
{
    public class SilverCustomer : Customer
    {
        public SilverCustomer(string fn, string ln) : base(fn, ln)
        {

        }

        //public override void Print()
        //{
        //    Console.WriteLine($"{FirstName} {LastName} : Silver Customer");
        //}

        public override void Print()
        {
            Console.WriteLine($"{FirstName} {LastName} : Silver Customer");
        }
    }

    public class AdvancedSilverCustomer : SilverCustomer
    {
        public AdvancedSilverCustomer(string fn, string ln) : base(fn,ln) { }

        public override void Print()
        {
            Console.WriteLine($"{FirstName} {LastName} : Advanced Silver Customer");
        }
    }
}
