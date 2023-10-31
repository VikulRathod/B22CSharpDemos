using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_LoopingStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region while loop

            //int start = 1; // initialization
            //while (start <= 0)  // condition
            //{
            //    Console.WriteLine(start);
            //    start++; // updation
            //}

            #endregion while loop

            #region do while loop

            //int start = 1;
            //do
            //{
            //    Console.WriteLine(start);
            //    start++;
            //} while (start <= 0);

            #endregion do while loop

            #region for loop

            //for (int start = 1; start <= 10; start++)
            //{
            //    Console.WriteLine(start);
            //}

            //for (int start = 1; start <= 10; start++)
            //{
            //    //if(start == 5)
            //    //{
            //    //    break;
            //    //    // continue;
            //    //}

            //    Console.WriteLine(start);
            //    if (start == 5)
            //    {
            //        start = 10;
            //        // break;
            //        // continue;
            //    }
            //}

            #endregion for loop


            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= 5; j++)
            //    {
            //        Console.Write($"*\t");
            //    }
            //    Console.WriteLine(); // new line
            //}

            //for (int i = 5; i > 0; i--)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write($"*\t");
            //    }
            //    Console.WriteLine(); // new line
            //}

            for (int i = 5; i > 0; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{j}\t");
                }
                Console.WriteLine(); // new line
            }

            Console.ReadLine();
        }
    }
}
