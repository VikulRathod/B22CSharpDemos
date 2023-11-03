using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_MethodsDemo
{
    internal class Program
    {
        static void Main(string[] args) // Calling Method
        {
            // return;

            PrintA(); // method call

            PrintB("Ajay"); // Ajay value => method argument
            string name = "Chetan";
            PrintB(name); // name => method argument

            PrintC("Ajay", "Rathod");
            string firstName = "Ganesh", lastName = "Pawar";
            PrintC(firstName, lastName);

            string result = PrintD("Chetan", "Chavhan");
            Console.WriteLine($"PrintD() result : Full Name : {result}");

            PrintE(true);
            PrintE(false);

            PrintF(null); // No Items To Add
            int[] numbers = new int[] { 10,20,30};
            PrintF(numbers); // 60

            Console.ReadLine();
        }

        // Calling method -> method from where another method is getting called
        // Called method -> method which is getting called from another method


        // 1. method without return without parameter
        static void PrintA() // Called Method
        {
            Console.WriteLine("PrintA() Method Called");
        }

        // 2. method without return with parameter
        static void PrintB(string name) // name => method parameter
        {
            Console.WriteLine($"PrintB() : Hello, {name}");
        }

        // 3. method without return multiple parameters
        static void PrintC(string fn, string ln)
        {
            Console.WriteLine($"PrintC() : Full Name : {fn} {ln}");
        }

        // 4. method with return with parameter
        static string PrintD(string fn, string ln)
        {
            return fn + ", " + ln;
        }

        static void PrintE(bool isConfirmed)
        {
            if (!isConfirmed)
            {
                return;
            }

            Console.WriteLine($"PrintE({isConfirmed}) : Session Allowed");
        }

        // sum of array elements
        static void PrintF(int[] numbers)
        {
            if(numbers != null && numbers.Length > 0)
            {
                int sum = 0;
                for (int i = 0; i < numbers.Length; i++)
                {
                    sum += numbers[i];
                }
                Console.WriteLine($"Sum Of Array Items : {sum}");
            }
            else
            {
                Console.WriteLine("No Numbers To Add");
            }
        }
    }
}
