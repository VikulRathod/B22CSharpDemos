using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_ElementsOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6 };

            // ElementAt -> it returns item from given index
            int item = numbers.ElementAt(0);
            Console.WriteLine($"ElementAt(0) : {item}"); // 1
            item = numbers.ElementAt(3);
            Console.WriteLine($"ElementAt(3) : {item}"); // 4
            //item = numbers.ElementAt(9);
            //Console.WriteLine($"ElementAt(9) : {item}"); // 

            // ElementAt -> throws exception when the given index is not within boundary
            // ElementAtOrDefault -> works same like ELementAt()
            // except it handles exception if given index is out of size and returns deafult value

            item = numbers.ElementAtOrDefault(9);
            Console.WriteLine($"ElementAtOrDefault(9) : {item}"); // 0

            // First -> it returns first matching item from collection

            item = numbers.First();
            Console.WriteLine($"First() : {item}"); // 1

            item = numbers.First(i => i % 2 == 0);
            Console.WriteLine($"First(i => i % 2 == 0) : {item}"); // 2

            //item = numbers.First(i => i > 50);
            //Console.WriteLine($"First(i => i > 50) : {item}");

            // FIrst -> throws exception if no item matching condition
            // FirstOrDefault -> it handles exception even if there are no matching item and returns default value

            item = numbers.FirstOrDefault(i => i > 50);
            Console.WriteLine($"FirstOrDefault(i => i > 50) : {item}"); // 0

            // Last -> returns last matching item from collection
            item = numbers.Last();
            Console.WriteLine($"Last() : {item}"); // 6

            item = numbers.Last(i => i % 2 == 0);
            Console.WriteLine($"Last(i => i % 2 == 0) : {item}"); // 6

            //item = numbers.Last(i => i > 50); // runtime error
            //Console.WriteLine($"Last(i => i > 50) : {item}");

            // Last -> throws exception when there are no matching item
            // LastOrDefault -> handles this exception

            item = numbers.LastOrDefault(i => i > 50);
            Console.WriteLine($"LastOrDefault(i => i > 50) : {item}"); // 0

            //// Single -> returns first matching item from collection
            //// Single -> throws exception if there are multiple matching items
            //// numbers = new List<int>() { 3 };
            //item = numbers.Single();
            //Console.WriteLine($"Single() : {item}");

            // item = numbers.Single(i => i % 2 == 0);
            item = numbers.Single(i => i > 5);
            Console.WriteLine($"Single(i => i > 5) : {item}");

            //item = numbers.Single(i => i > 50);
            //Console.WriteLine($"Single(i => i > 50) : {item}");

            // Single -> throws exception when no matching item found
            // SingleOrDefault -> it handles exception if no matching item found and returns default value

            item = numbers.SingleOrDefault(i => i > 50);
            Console.WriteLine($"SingleOrDefault(i => i > 50) : {item}");

            //item = numbers.SingleOrDefault(i => i % 2 == 0);
            //Console.WriteLine($"SingleOrDefault(i => i % 2 == 0) : {item}");

            Console.ReadLine();
        }
    }
}
