using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _41_Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Calculator c1 = new Calculator();
            //bool b1 = c1.AreEqual(10,10);
            //Console.WriteLine(b1); // true

            //b1 = c1.AreEqual(10, 11);
            //Console.WriteLine(b1); // false

            //b1 = c1.AreEqual("ABC", "ABC");
            //Console.WriteLine(b1); // true

            //b1 = c1.AreEqual(10.5f, 2.5f);
            //Console.WriteLine(b1); // false

            //b1 = c1.AreEqual("Vishal", 2.5f);
            //Console.WriteLine(b1); // false

            //Calculator c1 = new Calculator();
            //bool b1 = c1.AreEqual<int>(10, 10);
            //Console.WriteLine(b1); // true

            //b1 = c1.AreEqual<string>("A", "B");
            //Console.WriteLine(b1); // false

            //b1 = c1.AreEqual<float>(10.5f, 4.5f);
            //Console.WriteLine(b1); // false

            //// b1 = c1.AreEqual<string>("AA", 10.5f);

            //c1.Add<int>(10, 11); // 21

            //c1.Add<string>("A", "B"); // AB

            //c1.Add<float>(10.5f, 10.5f); // 21


            Student<int, string> s1 = new Student<int, string>();
            s1.RollNumber = 10;
            s1.Name = "Vishal";
            string r1 = s1.Details();
            Console.WriteLine(r1);

            Student<string, string> s2 = new Student<string, string>();
            s2.RollNumber = "11";
            s2.Name = "Mahesh";
            r1 = s2.Details();
            Console.WriteLine(r1);

            Customer c1 = new Customer() { FirstName = "Vihaan", LastName = "Rathod"};
            Customer c2 = new Customer() { FirstName = "Vihaan", LastName = "Rathod" };

            Calculator c = new Calculator();
            bool b1 = c.AreEqual<Customer>(c1, c2);
            Console.WriteLine(b1); // false


            Console.ReadLine();
        }
    }

    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
}
