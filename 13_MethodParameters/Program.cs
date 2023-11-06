using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_MethodParameters
{
    internal class Program
    {
        static void Main(string[] args) // Calling Method
        {
            //int a = 10;
            //PrintA(a);
            //Console.WriteLine(a);

            //int a = 10;
            //// int a; // compiler error 
            //PrintB(ref a);
            //Console.WriteLine(a);

            //// int a = 10;
            //int a;
            //PrintC(out a);
            //Console.WriteLine(a);

            //int a = 10, b = 2, add, sub, mul, div;
            //Print(a, b, out add, out sub, out mul, out div);
            //Console.WriteLine($"Addition : {a} + {b} = {add}");
            //Console.WriteLine($"Substraction : {a} - {b} = {sub}");
            //Console.WriteLine($"Multiplication : {a} * {b} = {mul}");
            //Console.WriteLine($"Division : {a} / {b} = {div}");

            int[] nums1 = new int[] { 10, 20, 30};
            PrintD(nums1); // 60

            PrintD(new int[] { 10, 20, 30 }); // 60

            PrintD(10, 20, 30); // 1st benefit

            int[] nums2 = null;
            PrintD(nums2); // EMPTY ARRAY

            PrintD(null); // EMPTY ARRAY

            PrintD(); // 1nd benefit

            string name = "vihaan rathod";
            // name.Split(new char[] { ' '});
            string[] result = name.Split(' ', ',');

            Console.ReadLine();
        }

        static void PrintA(int a) // Called Method
        {
            a = 100;
        }

        static void PrintB(ref int b)
        {
            // b = 100; // no error
        }

        static void PrintC(out int a)
        {
            // a = 100; // error
            a = 100;
        }

        // write a single method which returns add, sub, div, multiplication
        static void Print(int a, int b, out int add, out int sub, out int mul,
            out int div)
        {
            add = a + b;
            sub = a - b;
            mul = a * b;
            div = a / b;
        }

        static int Print1(int a, int b, out int sub, out int mul,
            out int div)
        {
            sub = a - b;
            mul = a * b;
            div = a / b;
            return a + b;
        }

        static void PrintD(params int[] numbers)
        {
            if(numbers != null && numbers.Length > 0)
            {
                int sum = 0;
                for (int i = 0; i < numbers.Length; i++)
                {
                    sum += numbers[i];
                }
                Console.WriteLine($"Sum Of Array : {sum}");
            }
            else
            {
                Console.WriteLine("EMPTY ARRAY");
            }
        }

    }
}
