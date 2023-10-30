using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_ConditionalStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 12;

            //if (i == 10)
            //{
            //    Console.WriteLine($"{i} : TEN");
            //    // Console.WriteLine("EVEN");                
            //}
            //else
            //{
            //    Console.WriteLine($"{i} : NOT TEN");
            //}

            // Console.WriteLine($"{i} : NOT TEN");

            // ternary operator
            // (condition) ? statement1(true) : statement2(false);

            //i = 10;
            //string result = (i == 10) ? "TEN" : "NOT TEN";
            //Console.WriteLine($"{i} : {result}");

            // if-else if-else ladder

            //i = 10;
            //if (i == 10)
            //{
            //    Console.WriteLine($"{i} : TEN");
            //}
            //else if (i == 20)
            //{
            //    Console.WriteLine($"{i} : TWENTY");
            //}
            //else if (i == 30)
            //{
            //    Console.WriteLine($"{i} : THIRTY");
            //}
            //else
            //{
            //    Console.WriteLine($"{i} : NOT 10 20 or 30");
            //}

            // switch
            //i = 100;
            //switch (i)
            //{
            //    case 10:
            //        Console.WriteLine($"{i} : TEN");
            //        break;
            //    case 20:
            //        Console.WriteLine($"{i} : TWENTY");
            //        break;
            //    case 30:
            //        Console.WriteLine($"{i} : THIRTY");
            //        break;
            //    default:
            //        Console.WriteLine($"{i} : NOT 10 20 or 30");
            //        break;
            //}

            int a = 10, b = 11;
            if (a > b)
            {
                Console.WriteLine($"{a} is greater than {b}");
            }
            else if (b > a)
            {
                Console.WriteLine($"{b} is greater than {a}");
            }
            else
            {
                Console.WriteLine($"{a} and {b} are equal");
            }

            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Today);

            Console.ReadLine();
        }
    }
}
