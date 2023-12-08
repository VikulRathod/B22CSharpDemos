using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40_partialClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student() 
            { Name = "Vishal" };

            s.AddEnquiry();

            Console.ReadLine();
        }
    }
}
