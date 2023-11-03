using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_ArrayDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int i = 10;
            //int j;
            //j = 10;

            // declaring array = first way
            int[] fees = new int[3];
            fees[0] = 15000;
            fees[1] = 5000;
            // fees[1] = "Five Thousand"; // compile time error
            fees[2] = 10000;
            // fees[3] = 12000; // error IndexOutOfRangeException

            Console.WriteLine($"Number of Items = {fees.Length}");

            for (int i = 0; i < fees.Length; i++)
            {
                Console.Write($"{fees[i]} ");
            }

            // declaring array - second way

            string[] names = new string[] 
            { "ajay", "chetan", "vasudha", "ganesh" };
            Console.WriteLine($"\nNumber of names : {names.Length}");

            for (int i = 0; i < names.Length; i++)
            {
                Console.Write($"{names[i]} ");
            }

            string[] emails = null;
            // Console.WriteLine($"Number of emails : {emails.Length}"); // runtime error

            emails = new string[] { "a@a.com", "p@p.com" };
            Console.WriteLine($"\nNumber of emails : {emails.Length}"); // 2

            int[] numbers = new int[] { 4, 2, 5, 1, 3 };
            // reverse array o/p => 3 1 5 2 4
            Console.WriteLine("Original Items");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"{numbers[i]} ");
            }

            Console.WriteLine("\nReverse array");
            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                Console.Write($"{numbers[i]} ");
            }

            // find highest number

            numbers = new int[] { 17, 10, 158, 195, 231, 7, 6 };

            int highest = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                // highest = numbers[i];

                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[j] > highest)
                    {
                        highest = numbers[j];
                    }
                }
            }
            Console.WriteLine($"\nHighest Number : {highest}");

            // reverse input string
            Console.WriteLine("Please enter your name");
            string name = Console.ReadLine();

            string reverseName = string.Empty;

            // char[] nameInChars = name.ToCharArray();
            for (int i = name.Length - 1; i >= 0; i--)
            {
                reverseName += name[i];
            }

            Console.WriteLine($"Input : {name} Output : {reverseName}");

            // reverse words in sentence
            // i/p => how are you o/p => you are how

            Console.WriteLine("Please enter a sentence");
            string sentence = Console.ReadLine();

            string[] words = sentence.Split(new char[] { ' ' });

            Console.WriteLine("Output : \n");
            for (int i = words.Length - 1; i >= 0; i--)
            {
                Console.Write($"{words[i]} ");
            }

            Console.ReadLine();
        }
    }
}
