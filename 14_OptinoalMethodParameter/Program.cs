using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _14_OptinoalMethodParameter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Add(10, 20); // 30

            // Add(10);  // 15
            Add(b: 20); // named parameter

            // Add(); // 0

            Sum(10, 20, 30); // 60
            Sum(a: 5, c: 15); // named parameter // 20

            Sum(5, c: 20); // 25

            Console.ReadLine();
        }
        //static void Add(int a = 5, int b = 50) // default value
        //{
        //    Console.WriteLine($"Addition : {a} + {b} = {a + b}");
        //}

        //static void Add(int a, int b = 5) // default value
        //{
        //    Console.WriteLine($"Addition : {a} + {b} = {a + b}");
        //}

        //static void Add([Optional] int a, [Optional] int b) // default value
        //{
        //    Console.WriteLine($"Addition : {a} + {b} = {a + b}");
        //}

        static void Add([Optional] int a, int b) // default value
        {
            Console.WriteLine($"Addition : {a} + {b} = {a + b}");
        }

        static void Sum(int a, [Optional] int b, int c)
        {
            Console.WriteLine($"Addition : {a} + {b} + {c} = {a + b + c}");
        }
    }
}
