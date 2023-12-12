using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _44_MulticastDelegates
{
    delegate string PrintDelegate();

    internal class Program
    {
        static void Main(string[] args)
        {
            PrintDelegate pd = PrintA;
            pd += PrintB;
            pd += PrintC;

            //string result = pd();
            //Console.WriteLine(result);

            Delegate[] delegates = pd.GetInvocationList();

            for (int i = 0; i < delegates.Length; i++)
            {
                try
                {
                    var result = delegates[i].DynamicInvoke();
                    Console.WriteLine(result);
                }
                catch
                {
                    Console.WriteLine("Exception Occurred");
                }
            }

            Console.ReadLine();
        }

        static string PrintA()
        {
            return "PrintA";
        }
        static string PrintB()
        {
            throw new Exception("Intentionally exception thrown");
            return "PrintB";
        }
        static string PrintC()
        {
            return "PrintC";
        }
    }
}
