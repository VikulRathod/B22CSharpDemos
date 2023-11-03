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
            #region array example
            //// comma separated input to find even numbers

            //Console.WriteLine("Please enter comma separated numbers");
            //string input = Console.ReadLine();

            //string[] numbers = input.Split(',');

            //int counter = 0;
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (int.Parse(numbers[i]) % 2 == 0)
            //    {
            //        Console.Write($"{numbers[i]} ");
            //        counter++;
            //    }
            //}
            //Console.WriteLine($"\nNumber of Even Numbers : {counter}");

            #endregion array example

            #region even number till given target

            //Console.WriteLine("Please enter a target number");
            //int target = int.Parse(Console.ReadLine());

            //int evenCount = target / 2;
            //int[] evens = new int[evenCount];
            //// int counter = 2;

            //for (int i = 0, counter = 2; i < evenCount; i++, counter+=2)
            //{
            //    evens[i] = counter;
            //    //if(i % 2 == 0)
            //    //{
            //    //    evens[i] = i;
            //    //}
            //}

            //for (int i = 0; i < evens.Length; i++)
            //{
            //    Console.Write($"{evens[i]} ");
            //}

            ////for (int i = 1; i <= target; i++)
            ////{
            ////    if(i % 2 == 0)
            ////    {
            ////        Console.Write($"{i} ");
            ////    }
            ////}
            //Console.WriteLine(); // new line

            #endregion even number till given target

            // multi dimensional array
            // array of arrays

            // int[] numbers = new int[2];
            int[,] numbers = new int[3, 3];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    // Console.Write($"{i}{j} ");
                    if (i == j)
                    {
                        Console.Write($"*\t");
                    }
                    else
                    {
                        Console.Write($"\t");
                    }
                }
                Console.WriteLine(); // new line
            }


            Console.ReadLine();
        }
    }
}
