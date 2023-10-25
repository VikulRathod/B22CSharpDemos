using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 10, j = 10;
            Console.WriteLine(i); // 10

            i = 20;
            Console.WriteLine(i); // 20

            int a = i + j;
            Console.WriteLine(a); // 30

            int s = i - j;
            Console.WriteLine(s); // 10

            int m = i * j;
            Console.WriteLine(m); // 200

            int d = i / j;
            Console.WriteLine(d); // 2

            int mo = 5 % 2;
            Console.WriteLine(mo); // 1

            // i = i + 1; // 20
            i++;
            Console.WriteLine(i); // 21

            // Console.WriteLine(i++); // 21 // post increment
            Console.WriteLine(++i); // 22 // pre increment
            Console.WriteLine(i); // 22


            // compound assignment

            // i = i + 5;
            // i += 5;
            i -= 7;
            Console.WriteLine(i); // 15

            i *= 3;
            Console.WriteLine(i); // 45

            i /= 5;
            Console.WriteLine(i); // 9

            bool result = i == j;
            Console.WriteLine(result); // false

            result = i != j;
            Console.WriteLine(result); // true

            result = i < j;
            Console.WriteLine(result); // true

            i++;
            result = i >= j;
            Console.WriteLine(result); // true

            int k = 20;
            result = i >= j && j > k;
            Console.WriteLine(result); // false

            result = i >= j || j > k;
            Console.WriteLine(result); // true


            Console.ReadLine(); // to wait
        }
    }
}
