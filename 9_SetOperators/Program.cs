using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_SetOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Distinct

            //List<int> numbers = new List<int>() { 1, 2, 4, 2, 5, 4, 2 };

            //var unique = numbers.Distinct();
            //foreach (var item in unique)
            //{
            //    Console.Write($"{item} ");
            //}
            //Console.WriteLine();

            #endregion Distinct

            #region Union

            //List<int> numbers1 = new List<int>() { 3, 2, 1 };
            //List<int> numbers2 = new List<int>() { 5, 6, 4, 2 };

            //// IEnumerable<int> result = numbers1.Union(numbers2); // ignoring duplicates

            //IEnumerable<int> result = numbers1.Concat(numbers2);

            //foreach (var item in result)
            //{
            //    Console.Write($"{item} ");
            //}
            //Console.WriteLine();

            #endregion Union

            #region Intersect

            //List<int> numbers1 = new List<int>() { 3, 2, 5, 1 };
            //List<int> numbers2 = new List<int>() { 4, 2, 1 };

            //// IEnumerable<int> result = numbers1.Intersect(numbers2);

            //IEnumerable<int> result = numbers1.Except(numbers2);

            //foreach (var item in result)
            //{
            //    Console.Write($"{item} ");
            //}
            //Console.WriteLine();

            #endregion Intersect

            #region SequenceEqual

            List<int> numbers1 = new List<int>() { 2, 3, 1 };
            List<int> numbers2 = new List<int>() { 1, 3, 2 };

            //numbers1.Sort();
            //numbers2.Sort();

            bool b1 = numbers1.Count == numbers2.Count;
            Console.WriteLine("NOT EQUAL");

            b1 = numbers1.SequenceEqual(numbers2);
            Console.WriteLine($"SequenceEqual : {b1}");

            #endregion SequenceEqual

            Console.ReadLine();
        }
    }
}
