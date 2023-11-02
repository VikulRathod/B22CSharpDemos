using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_ArrayExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter comma separated numbers");
            string input = Console.ReadLine();

            string[] numbers = input.Split(',');

            int counter = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (int.Parse(numbers[i]) % 2 == 0)
                {
                    Console.Write($"{numbers[i]} ");
                    counter++;
                }
            }
            Console.WriteLine($"\nNumber of Even Numbers : {counter}");

            Console.WriteLine("Please enter a target number to find even numbers");
            int target = int.Parse(Console.ReadLine());

            int[] evens = new int[target / 2]; // array size = half
            int c = 0;
            for (int i = 0, j = 0; j <= target; i += 2, j++)
            {
                evens[i] = i + 2;
                //if (i % 2 == 0)
                //{
                //    evens[i] = i;
                //}
            }
            // int[] evens = new int[c];
            Console.WriteLine("All Even Number");
            for (int i = 0; i < evens.Length; i++)
            {
                Console.Write($"{evens[i]} ");
            }


            Console.ReadLine();
        }
    }
}
