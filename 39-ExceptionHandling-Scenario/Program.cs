using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _39_ExceptionHandling_Scenario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string result = GetData1();
            Console.WriteLine(result);

            Customer c = null;
            if (c != null)
            {
                Console.WriteLine(c.Name);
            }

            Console.ReadLine();
        }

        static string GetData()
        {
            try
            {
                return "TRY";
            }
            catch
            {
                return "CATCH";
            }
            finally
            {
                // return "FINALLY"; // return statement not possible in finally block
            }
        }

        static string GetData1()
        {
            string result = "";
            try
            {
                result = "TRY";
                // return "TRY";
                return result; // return "TRY";
            }
            catch
            {
                result = "CATCH";
                //return "CATCH";
                return result;
            }
            finally
            {
                result = "FINALLY";
                Console.WriteLine("Finally Block Executed");
                // return "FINALLY"; // return statement not possible in finally block
            }

            // return result;
        }
    }

    public class Customer
    {
        public string Name { get; set; }
    }
}
