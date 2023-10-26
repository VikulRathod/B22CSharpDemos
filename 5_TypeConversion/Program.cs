using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_TypeConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 10, j = 10;
            Console.WriteLine(i + j); // 20

            // int => string
            string a = i.ToString(); // int -> string
            string b = j.ToString();
            Console.WriteLine(a + b); // 1010

            byte b1 = 10;
            short s1 = b1; // byte -> short
            Console.WriteLine(s1); // 10

            float f1 = s1; // short -> float
            Console.WriteLine(f1); // 10

            // int i1 = f1; // float -> int
            int i1 = (int)f1; // float -> int
            Console.WriteLine(i1);

            f1 = 25.55f;
            i1 = (int)f1;
            Console.WriteLine(i1); // 25.55

            string s = "2000";
            // string s = "ABCD";
            // i1 = s; // string -> int
            i1 = Convert.ToInt32(s);
            Console.WriteLine(i1); // 100

            s = "true";
            bool bb = Convert.ToBoolean(s); // string -> bool
            Console.WriteLine(bb);


            s = "777";
            // Parse()
            // Parse() method throws error when string is not in correct format
            i1 = int.Parse(s); // string -> int
            Console.WriteLine(i1); // 777

            //s = "XYZ";
            //i1 = int.Parse(s); // runtime error
            //Console.WriteLine(i1);

            // TryParse() -> it handles the runtime error
            // convert and return conversion status along with converted value
            // in case of runtime error it returns false, default value as output
            // default value of bool is false
            // default value of int is 0
            // default value of string is null

            s = "2000";
            bb = int.TryParse(s, out i1);
            Console.WriteLine($"Status : {bb} Result : {i1}");

            s = "XYZ";
            bb = int.TryParse(s, out i1);
            Console.WriteLine($"Status : {bb} Result : {i1}"); // false, 0

            decimal x = 10.52m;
            long l = (long) x; // decimal -> long
            Console.WriteLine(l); // 10

            Console.ReadLine();
        }
    }
}
