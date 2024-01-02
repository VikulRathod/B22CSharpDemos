using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_PartitioningOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Take

            //List<int> numbers = new List<int>() { 2, 4, 7, 6, 5, 3, 10, 15, 20, 9 };

            //Console.WriteLine("*** ALL NUMBERS ***");
            //foreach (var item in numbers)
            //{
            //    Console.Write($"{item} ");
            //}
            //Console.WriteLine();

            //IEnumerable<int> result = numbers.Take(5);
            //Console.WriteLine("*** Take(3) ***");
            //foreach (var item in result)
            //{
            //    Console.Write($"{item} ");
            //}
            //Console.WriteLine();

            //// IEnumerable<int> result1 = numbers.TakeWhile(i => i < 10);
            //// IEnumerable<int> result1 = numbers.TakeWhile(i => i % 2 == 0);
            //IEnumerable<int> result1 = numbers.TakeWhile(i => i > 10);
            //Console.WriteLine("*** TakeWhile(i => i < 10) ***");
            //foreach (var item in result1)
            //{
            //    Console.Write($"{item} ");
            //}
            //Console.WriteLine();

            #endregion Take

            #region Skip

            //List<int> numbers = new List<int>() { 2, 4, 7, 6, 5, 3, 10, 15, 20, 9 };

            //Console.WriteLine("*** ALL NUMBERS ***");
            //foreach (var item in numbers)
            //{
            //    Console.Write($"{item} ");
            //}
            //Console.WriteLine();

            //IEnumerable<int> result = numbers.Skip(5);

            //Console.WriteLine("*** Skip(5) ***");
            //foreach (var item in result)
            //{
            //    Console.Write($"{item} ");
            //}
            //Console.WriteLine();

            //IEnumerable<int> result1 = numbers.SkipWhile(i => i < 10);
            //Console.WriteLine("*** SkipWhile(i => i < 10) ***");
            //foreach (var item in result1)
            //{
            //    Console.Write($"{item} ");
            //}
            //Console.WriteLine();

            #endregion Skip

            #region Second highest number

            List<int> numbers = new List<int>() { 10, 17, 23, 54, 47 };

            int max = numbers.Max();
            Console.WriteLine($"Highest Number : {max}");

            //int secondHighest =
            //    numbers.OrderByDescending(i => i)
            //    .Take(2).OrderBy(i => i)
            //    .Take(1).FirstOrDefault();

            //int secondHighest =
            //    numbers.OrderByDescending(i => i)
            //    .Take(2).Skip(1).FirstOrDefault();

            int secondHighest =
                numbers.OrderByDescending(i => i)
                .Take(2).Min();
            Console.WriteLine($"Second Highest Number : {secondHighest}");

            #endregion Second highest number

            Console.ReadLine();
        }
    }
}
