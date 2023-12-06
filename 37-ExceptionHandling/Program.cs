using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _37_ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Welcome To Calculator App");

                Console.WriteLine("Please enter numerator");
                int num = int.Parse(Console.ReadLine());

                Console.WriteLine("Please enter denominator");
                int den = int.Parse(Console.ReadLine());

                Divide(num, den);
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"FormatException : {ex.Message}");
            }
            catch (OverflowException ex)
            {
                Console.WriteLine($"OverflowException : {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"${ex.GetType().Name} : {ex.Message}");
            }

            Console.WriteLine("Thank You. Visit Again.");

            Console.ReadLine();
        }

        static void Divide(int num, int den)
        {
            //try
            //{
            try
            {
                int div = num / den;
                Console.WriteLine($"Division : {num} / {den} = {div}");
            }
            // catch
            catch (DivideByZeroException ex)
            {
                // Console.WriteLine("Denominator cannot be zero. Please enter denominator greater than zero.");
                // Console.WriteLine(ex.GetType().Name);
                Console.WriteLine(ex.Message);
                // Console.WriteLine(ex.StackTrace);

                File.WriteAllText(@"logs\app\errors.txt", $"{ex.Message} \n");
            }
            //}
            //catch(Exception ex)
            //{
            //    Console.WriteLine($"Outer Catch Block : {ex.Message}");
            //}

            finally
            {
                Console.WriteLine("Division Operation Completed");
            }
        }
    }
}
