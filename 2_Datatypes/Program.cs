using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Datatypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool b1 = true;
            Console.WriteLine(b1);
            Console.WriteLine(sizeof(bool));

            byte i1 = 10;
            Console.WriteLine(i1); // 10
            Console.WriteLine(sizeof(byte)); // 1
            Console.WriteLine(byte.MinValue); // 0
            Console.WriteLine(byte.MaxValue); // 255

            short i2 = 10;
            Console.WriteLine($"{i2} : {sizeof(short)} : {short.MinValue} : {short.MaxValue} ");

            int i3 = 10;
            Console.WriteLine($"{i3} : {sizeof(int)} : {int.MinValue} : {int.MaxValue}");

            long i4 = 12;
            Console.WriteLine($"{i4} : {sizeof(long)} : {long.MinValue} : {long.MaxValue}");

            float f1 = 10.5f;
            Console.WriteLine($"{f1} : {sizeof(float)} : {float.MinValue} : {float.MaxValue} ");

            double f2 = 10.5;
            Console.WriteLine($"{f2} : {sizeof(double)} : {double.MinValue} : {double.MaxValue}");

            decimal f3 = 31223585237012451245645653m;
            Console.WriteLine($"{f3} : {sizeof(decimal)} : {decimal.MinValue} : {decimal.MaxValue}");

            char div = '$';
            Console.WriteLine(div);
            Console.WriteLine(sizeof(char));

            string name = "V!shal";
            Console.WriteLine(name);
            // Console.WriteLine(sizeof(string)); // error

            Console.ReadLine(); // to wait
        }
    }
}
