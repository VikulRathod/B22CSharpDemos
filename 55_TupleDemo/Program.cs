using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _55_TupleDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tuple<int, int, int> t1 =
                new Tuple<int, int, int>(11, 12, 13);

            Console.WriteLine(t1.Item2);

            Tuple<int, int, int, int, int, int, int> numbers =
                new Tuple<int, int, int, int, int, int, int>(1, 2,3, 4, 5, 6, 7);

            Console.WriteLine(numbers.Item4); // 4
            Console.WriteLine(numbers.Item7); // 7

            Tuple<int, int, int, int, int, int, int, Tuple<int, int, int>> numbers1 =
                new Tuple<int, int, int, int, int, int, int, Tuple<int, int, int>>
                (1, 2, 3, 4, 5, 6, 7, t1);

            Console.WriteLine(numbers1.Item5); // 5
            Console.WriteLine(numbers1.Rest.Item3); // 13

            var result = GetDetails();

            Console.WriteLine($"Roll Number {result.Item1} : " +
                $"Name : {result.Item3} City: {result.Item2}");

            Console.ReadLine();
        }

        static Tuple<int, string, string> GetDetails()
        {
            Tuple<int, string, string> detail =
                new Tuple<int, string, string>(10, "Vishal", "Mumbai");

            return detail;
        }
    }
}
