using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_methodoverriding
{
    public class Customer
    {
        public string FirstName;
        public string LastName;

        public Customer(string fn, string ln)
        {
            FirstName = fn;
            LastName = ln;
        }

        public virtual void Print() // virtual/ abstract/ override
        {
            Console.WriteLine($"{FirstName} {LastName} : Normal Customer");
        }
    }
}
