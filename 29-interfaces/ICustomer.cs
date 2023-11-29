using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29_interfaces
{
    public interface ICustomer
    {
        // public int CustomerId; // no fields
        //public ICustomer() // no constructors
        //{

        //}

        void ShowsTimings();
    }

    public interface ICustomerV1 : ICustomer
    {
        void PrintTicket();

        //void OrderFood()
        //{

        //}
    }

    // public class SilverCustomer : ICustomer, ICustomerV1
    public class SilverCustomer : ICustomerV1
    {
        public void PrintTicket()
        {
            Console.WriteLine("SilverCustomer: PrintTicket() Method");
        }

        public void ShowsTimings()
        {
            Console.WriteLine("SilverCustomer: ShowsTimings() Method");
        }
    }

    // public class GoldCustomer : ICustomer, ICustomerV1
    public class GoldCustomer : ICustomerV1
    {
        public void ShowsTimings()
        {
            Console.WriteLine("GoldCustomer: ShowsTimings() Method");
        }
        public void PrintTicket()
        {
            Console.WriteLine("GoldCustomer: PrintTicket() Method");
        }
    }
}
