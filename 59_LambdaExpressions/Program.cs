using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _59_LambdaExpressions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region using separate method

            //Calculator c1 = new Calculator();
            //// Predicate<int> del1 = c1.Even;
            //Predicate<int> del1 = Calculator.Even;

            //bool b1 = del1(10);
            //Console.WriteLine(b1); // true
            //b1 = del1(11);
            //Console.WriteLine(b1); // false

            #endregion using separate method

            #region using anonymous method

            //Predicate<int> del1 = delegate (int num)
            //{
            //    return num % 2 == 0;
            //};

            //Console.WriteLine(del1(10));
            //Console.WriteLine(del1(21));

            #endregion using anonymous method

            #region lambda expression

            Predicate<int> del1 = i => i % 2 == 0;

            Console.WriteLine(del1(10)); // true
            Console.WriteLine(del1(11)); // false

            Action<string, string> del2 =
                (s1, s2) => Console.WriteLine($"{s1} {s2}");

            del2("Anil", "Rathod");

            Action<string, string> del3 = (s1, s2) =>
            {
                string s = s1 + " " + s2;
                Console.WriteLine(s);
            };

            del3("Rahul", "Rathod");

            Func<string> del4 = () => { return "Hello World!!!"; };

            Console.WriteLine(del4());

            Func<string, string, string> del5 =
                (s1, s2) => {
                    string s = s1 + " " + s2;
                    return s;
                };

            Console.WriteLine(del5("Anup", "Rathod"));

            Func<int, int, int> del6 = (i, j) => i + j;

            #endregion lambda expression

            Console.ReadLine();
        }

        //static bool Even(int num)
        //{
        //    return num % 10 == 0;
        //}
    }

    public class Calculator
    {
        public static bool Even(int num)
        {
            return num % 10 == 0;
        }
    }
}
