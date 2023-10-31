using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_ConditionalStatementsExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Please enter first number");
            //int first = int.Parse(Console.ReadLine());

            //Console.WriteLine("Please enter second number");
            //int second = int.Parse(Console.ReadLine());

            //Console.WriteLine("Please enter third number");
            //int third = int.Parse(Console.ReadLine());

            //Console.WriteLine($"You entered : {first}, {second}, {third}");

            #region nested if else

            //if(first > second)
            //{
            //    if(first > third)
            //    {
            //        Console.WriteLine($"{first} is greater number");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{third} is greater number");
            //    }
            //}
            //else if(second > first)
            //{
            //    if(second > third)
            //    {
            //        Console.WriteLine($"{second} is greater number");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{third} is greater number");
            //    }
            //}
            //else
            //{
            //    if(first > third)
            //    {
            //        Console.WriteLine($"{first}, {second} are greater number");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{third} is greater number");
            //    }
            //}

            #endregion nested if else

            #region nested ternary operator
            //// int number = (first > second) ? first : second;
            //int number = (first > second) ? 
            //    ((first > third) ? first : third) : 
            //    ((second > third) ? second : third);

            //Console.WriteLine($"{number} is greater number");

            #endregion nested ternary operator

            #region divisible 3 & 5
            //// if input number is divisible by 3 = THREE
            //// if input number is divisible by 5 = FIVE
            //// if input number is divisible by 3 & 5 = THREEFIVE

            //Console.WriteLine("Please enter a number");
            //int num = int.Parse(Console.ReadLine());

            //if (num % 3 == 0 && num % 5 == 0)
            //{
            //    Console.WriteLine("THREEFIVE");
            //}
            //else if (num % 3 == 0)
            //{
            //    Console.WriteLine("THREE");
            //}
            //else if (num % 5 == 0)
            //{
            //    Console.WriteLine("FIVE");
            //}

            #endregion divisible 3 & 5

            #region even / odd number

            //Console.WriteLine("Please enter a number");
            //int num = int.Parse(Console.ReadLine());

            //string result = (num % 2 == 0) ? "EVEN" : "ODD";

            //Console.WriteLine($"{num} is {result} number");

            #endregion even / odd number

            #region grade meaning

            Console.WriteLine("Please enter a grade");
            char grade = char.Parse(Console.ReadLine().ToUpper());

            switch (grade)
            {
                case 'A':
                    Console.WriteLine($"{grade} : Distinction");
                    break;
                case 'B':
                    Console.WriteLine($"{grade} : First Class");
                    break;
                case 'C':
                    Console.WriteLine($"{grade} : Second Class");
                    break;
                case 'F':
                    Console.WriteLine($"{grade} : Failed");
                    break;
                default:
                    Console.WriteLine($"{grade} : Invalid Grade");
                    break;
            }

            #endregion grade meaning


            Console.ReadLine();
        }
    }
}
