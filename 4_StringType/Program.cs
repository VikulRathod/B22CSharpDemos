using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _4_StringType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Vishal";
            Console.WriteLine(name);

            Console.WriteLine(name.Length);

            name = "       Vishal";
            Console.WriteLine(name);
            Console.WriteLine(name.Trim());

            name = "Vishal";
            Console.WriteLine(name.ToUpper());
            Console.WriteLine(name.ToLower());

            name = "\"Vishal\"";
            Console.WriteLine(name); // "Vishal"

            name = "\'Vishal\'";
            Console.WriteLine(name);

            name = "\\Vishal\\";
            Console.WriteLine(name); // \Vishal\

            Console.WriteLine("Vishal Pawar");
            Console.WriteLine("Vishal\tPawar");
            Console.WriteLine("Vishal\nPawar");

            // string path = "E:\\temp\\Batch22\\Client";
            string path = @"E:\temp\Batch22\Client";
            Console.WriteLine(path);

            string firstName = "Vihaan";
            string lastName = "Rathod";
            string fullName = firstName + lastName;
            Console.WriteLine(fullName); // VihaanRathod

            fullName = firstName + " " + lastName;
            Console.WriteLine(fullName); // Vihaan Rathod

            fullName = string.Concat(firstName, " ", lastName);
            Console.WriteLine(fullName); // Vihaan Rathod

            string middleName = "Vikul";
            fullName = string.Concat(firstName + " " + middleName + " " + lastName);
            Console.WriteLine(fullName); // Vihaan Vikul Rathod

            fullName = string.Join(" ", firstName, middleName, lastName);
            Console.WriteLine(fullName); // Vihaan Vikul Rathod

            // Full Name : Vihaan Vikul Rathod

            fullName = string.Join(" ", "Full", "Name", ":", firstName, middleName, lastName);
            Console.WriteLine(fullName);

            // placeholder syntax
            fullName = string.Format("Full Name : {0} {1} {2}", firstName, middleName, lastName);
            Console.WriteLine(fullName);

            // string interpolation
            fullName = $"Full Name : {firstName} {middleName}\t, {lastName}";
            Console.WriteLine(fullName);

            fullName = $"My Son Name Is : {firstName}";
            Console.WriteLine(fullName);

            Console.ReadLine();
        }
    }
}
