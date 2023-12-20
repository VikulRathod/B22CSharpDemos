using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _57_YieldKeyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6 };

            foreach (int num in GetEven(numbers))
            {
                Console.Write($"{num} ");
            }
            Console.ReadLine();
        }
        static IEnumerable<int> GetEven(List<int> numbers)
        {            
            // List<int> temp = new List<int>();
            foreach (int num in numbers)
            {
                if (num % 2 == 0)
                {
                    yield return num;
                    // temp.Add(num);
                }
            }
            // return temp;
        }
    }
}
