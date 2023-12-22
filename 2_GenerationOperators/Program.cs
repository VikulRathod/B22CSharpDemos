using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_GenerationOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<int> numbers1 = Enumerable.Empty<int>();
            Console.WriteLine($"{numbers1.Count()}");

            IEnumerable<int> numbers2 = Enumerable.DefaultIfEmpty<int>(numbers1);
            Console.WriteLine($"{numbers2.Count()} : {numbers2.ElementAt(0)}");

            IEnumerable<int> numbers3 = Enumerable.Repeat(5, 10);
            foreach (var item in numbers3)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();

            IEnumerable<int> numbers4 = Enumerable.Range(1, 25);
            foreach (var item in numbers4)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
