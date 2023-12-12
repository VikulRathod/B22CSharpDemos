using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _45_GenericDelegates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Predicate Delegate
            //// public delegate bool Predicate<in T>(T obj);
            //Predicate<int> d1 = Method1;
            //bool b1 = d1(20);
            //Console.WriteLine(b1); // true
            //b1 = d1(21);
            //Console.WriteLine(b1); // false

            //Predicate<string> d2 = Method2;
            //b1 = d2("Rameshwar");
            //Console.WriteLine(b1); // true
            //b1 = d2("Anil");
            //Console.WriteLine(b1); // false
            #endregion Predicate Delegate

            #region Action Delegate

            //// public delegate void Action<in T>(T obj);
            //Action<string> d1 = Print1;
            //d1("Vishal");

            //Action<string, string, int> d2 = Print2;
            //d2("Anil", "Rathod", 25);

            //Action d3 = Print3;
            //d3();

            #endregion Action Delegate


            #region Func Delegate

            //// public delegate TResult Func<out TResult>();
            //// public delegate TResult Func<in T, out TResult>(T arg);

            //Func<string, int> d1 = PrintA;
            //int i = d1("Om");
            //Console.WriteLine($"{i}");

            //Func<int, int, int> d2 = Add;
            //i = d2(10, 11);
            //Console.WriteLine($"{i}");

            //// anonymous method
            //Func<int, int, int> d3 = delegate (int a, int b)
            //{
            //    return a + b;
            //};

            //i = d3(10, 50);
            //Console.WriteLine($"{i}");

            #endregion Func Delegate

            #region Anonymous Method

            Predicate<string> d1 = delegate (string s)
            {
                return s.Length > 3 ? true : false;
            };

            bool b1 = d1("OM");
            Console.WriteLine(b1); // false

            b1 = d1("OMPRAKASH");
            Console.WriteLine(b1); // true

            Action<string, string> d2 = delegate (string s1, string s2)
            {
                Console.WriteLine($"{s1} {s2}");
            };

            d2("Anil", "Rathod");

            Func<string, string, string> d3 = delegate (string s1, string s2)
            {
                return s1 + " " + s2;
            };
            string result = d3("OM", "Pachbhai");
            Console.WriteLine(result);

            // Func<string, string, string> d4 = (s1, s2) => s1 + " " + s2;

            #endregion Anonymous Method

            Console.ReadLine();
        }

        static bool Method1(int i)
        {
            return i % 2 == 0 ? true : false;
        }

        static bool Method2(string s)
        {
            return s.Length > 5 ? true : false;
        }

        static void Print1(string s)
        {
            Console.WriteLine(s.ToUpper());
        }

        static void Print2(string s1, string s2, int i)
        {
            Console.WriteLine($"{s1} : {s2} : {i}");
        }

        static void Print3()
        {
            Console.WriteLine("Print3() Method Called");
        }

        static int PrintA(string s)
        {
            return s.Length;
        }

        static int Add(int a, int b)
        {
            return a + b;
        }
    }
}
