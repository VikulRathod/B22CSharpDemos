using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_methodoverriding
{
    public class GoldCustomer : Customer
    {
        public GoldCustomer(string fn, string ln) : base(fn, ln)
        {
        }

        public override void Print()
        {
            Console.WriteLine($"{FirstName} {LastName} : Gold Customer");
        }
    }
}
