using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _38_ExceptionHandling_Continued
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Welcome To Calculator App");
                Console.WriteLine("Please enter numerator");
                int numerator, denominator;

                if (int.TryParse(Console.ReadLine(), out numerator))
                {
                    Console.WriteLine("Please enter a denominator");

                    if (int.TryParse(Console.ReadLine(), out denominator))
                    {
                        Divide(numerator, denominator);
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid denominator");
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a valid numerator");
                }

                Console.WriteLine("Thank You. Visit Again.");
            }
            catch(MyCustomException ex)
            {
                Console.WriteLine($"Main() MyCustomException Catch Block : {ex.Message}");
            }
            catch(Exception ex)
            {
                //if(ex.GetType().Name == "NullReferenceException")
                //{
                //    // logic 1
                //}
                //if (ex.GetType().Name == "IndexOutOfRangeException")
                //{
                //    // logic 2
                //}

                Console.WriteLine($"Main() Method Catch Block : {ex.GetType().Name} {ex.Message}");
                Console.WriteLine($"Main() Method Catch Block : {ex.InnerException.GetType().Name} {ex.InnerException.Message}");
            }

            Console.ReadLine();
        }

        static void Divide(int num, int den)
        {
            #region using conditional check
            //if (den != 0)
            //{
            //    int div = num / den;
            //    Console.WriteLine($"Division {num} / {den} = {div}");
            //}
            //else
            //{
            //    Console.WriteLine("Denominator can not be zero");
            //}
            #endregion using conditional check

            try
            {
                //if(den == 0)
                //{
                //    throw new Exception("Denominator is zero");
                //}

                int div = num / den;
                Console.WriteLine($"Division {num} / {den} = {div}");
                // throw;
            }
            catch(Exception ex)
            {
                // Console.WriteLine($"Divide() catch block : {ex.Message}");

                // throw new Exception("Denominator is zero");

                // throw;
                // File.WriteAllText(@"ErroLogs\logs.txt", ex.Message);

                // throw new DirectoryNotFoundException("Inner catch exception", ex);
                throw new MyCustomException("Product Quantity Are Not Available");
            }

            Console.WriteLine("Division Operation Completed");
        }
    }

    public class MyCustomException : Exception
    {
        public MyCustomException(string msg) : base(msg)
        {

        }
    }
}
