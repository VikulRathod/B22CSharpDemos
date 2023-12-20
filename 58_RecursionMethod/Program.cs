using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _58_RecursionMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 5;
            // 5 factorial = 5 * 4 * 3 * 2 * 1 = 120

            //int factorial = 1;
            //for (int i = num; i  > 0; i--)
            //{
            //    factorial *= i;
            //}
            //Console.WriteLine(factorial);

            int factorial = Factorial(num);
            Console.WriteLine(factorial);

            // Fibanacii series = 1 1 2 3 5 8 13 21 ...
            int target = 10;
            int firstNum = 1;
            int secondNum = 1;


            //List<int> series = new List<int>();
            //series.Add(firstNum);
            //series.Add(secondNum);

            //for (int i = 0; i < 10; i++)
            //{               
            //    int ThirdNum = firstNum + secondNum;
            //    series.Add(ThirdNum);

            //    firstNum = secondNum;
            //    secondNum = ThirdNum;
            //}

            //foreach (int item in series)
            //{
            //    Console.Write($"{item} ");
            //}

            //// 2nd way 
            //Console.Write($"{firstNum} {secondNum} ");
            //FibonaciiSeries(firstNum, secondNum, target);

            //Console.Write($"{firstNum} {secondNum} ");
            //for (int i = 0; i < target; i++)
            //{
            //    int n = GetFibonaciiSeries(firstNum, secondNum, target);
            //    Console.Write($"{n} ");
            //}

            Console.WriteLine("Enter the number of terms in the Fibonacci series:");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Fibonacci Series:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(Fibonacci(i) + " ");
            }

            Console.ReadLine();
        }

        static int Factorial(int num)
        {
            if (num == 1)
            {
                return 1;
            }

            return num * Factorial(num - 1);
        }

        static void FibonaciiSeries(int fn, int sn, int count)
        {
            int tn = fn + sn;

            Console.Write($"{tn} ");

            count--;
            if (count == 0)
            {
                return;
            }

            FibonaciiSeries(sn, tn, count);
        }

        static int GetFibonaciiSeries(int fn, int sn, int count)
        {
            int tn = fn + sn;

            // Console.Write($"{tn} ");

            count--;
            if (count == 0)
            {
                return tn;
            }
            else
            {
                return GetFibonaciiSeries(sn, tn, count);
            }
        }

        static int Fibonacci(int n) // 0, 1,2,3.. target
        {
            if (n <= 1) // n == 0, n == 1
                return n;
            else
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            // return (1) + (0) = 1
        }
    }
}
