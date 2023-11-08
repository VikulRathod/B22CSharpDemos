using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_BoxingUnBoxing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            Console.WriteLine($"i : {i}");
            object o = i; // int -> object / value type -> reference type = boxing
            Console.WriteLine($"o : {o}");

            int j = (int) o; // object -> int / reference type -> value type = unboxing
            Console.WriteLine($"j : {j}");

            // j = i;

            // object is base type for all types in dot net
            object o1 = 10;
            o1 = '$';
            o1 = "abc";
            o1 = 45.5f;

            Console.ReadLine();
        }
    }
}
