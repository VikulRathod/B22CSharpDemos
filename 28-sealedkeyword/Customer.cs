using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28_sealedkeyword
{
    // public sealed class Customer
    public class Customer
    {
        public virtual void Print()
        {
            Console.WriteLine("Customer Print()");
        }
    }

    public class SilverCustomer : Customer
    {
        public sealed override void Print()
        {
            Console.WriteLine("Silver Customer Print()");
        }
    }

    public class AdvancedSilverCustomer : SilverCustomer
    {
        // cannot override as Print() is sealed
        //public override void Print()
        //{
        //    Console.WriteLine("Advanced Silver Customer Print()");
        //}
    }


    // public class Student { } // normal class
    // public static class Student { } // static class
    // public abstract class Student { } // abstract class
    // public static abstract class Student { } // static & abstract at same time not possible
    // public sealed class Student { } // sealed class
    // public static sealed class Student { } // static & sealed at same time not possible
}
