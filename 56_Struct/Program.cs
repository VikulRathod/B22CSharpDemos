using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _56_Struct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime today1 = DateTime.Now;
            Console.WriteLine(today1);
            Console.WriteLine($"Date : {today1.ToShortDateString()}");
            Console.WriteLine($"Time : {today1.ToShortTimeString()}");

            // date formatting
            // https://www.c-sharpcorner.com/blogs/date-and-time-format-in-c-sharp-programming1

            Console.WriteLine($"{today1.ToString("dddd, dd MMMM YYYY")}");

            DateTime today2 = DateTime.Today;
            Console.WriteLine(today2);

            //Customer c = new Customer()
            //{
            //    CustomerId = 1,
            //    FirstName = "Ajay",
            //    LastName = "Rathod"
            //};
            //c.Details();

            //c = new Customer()
            //{
            //    CustomerId = 2,
            //    FirstName = "Mahesh",
            //    LastName = "Pawar"
            //};
            //c.Details();

            Console.ReadLine();
        }
    }

    public struct Customer
    {
        // public Customer() { }

        public Customer(int id, string fn, string ln)
        {
            CustomerId = id;
            FirstName = fn;
            LastName = ln;
        }

        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void Details()
        {
            Console.WriteLine($"Id : {CustomerId} Name : {FirstName} {LastName}");
        }
    }

    public class SilverCustomer // : Customer
    {

    }
}
