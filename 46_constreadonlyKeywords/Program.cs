using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _46_constreadonlyKeywords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.RollNumber = 1;
            s1.Name = "Vishal";
            // s1.CompanyName = "V#";

            Console.WriteLine($"Roll Number : {s1.RollNumber} " +
                $"Name : {s1.Name} " +
                $"Company Name : {s1.CompanyName}");

            Student s2 = new Student();
            s2.RollNumber = 2;
            s2.Name = "Mahesh";
            // s2.CompanyName = "TCS";

            // Student.CompanyName = "TCS";

            Console.WriteLine($"Roll Number : {s2.RollNumber} " +
           $"Name : {s2.Name} " +
           $"Company Name : {s2.CompanyName}");

            Console.ReadLine();
        }
    }

    public class Student
    {
        public int RollNumber { get; set; }
        public string Name { get; set; }

        // public static string CompanyName = "V#";
        // public const string CompanyName = "V#";
        public readonly string CompanyName;
        // public static readonly string CompanyName;

        public Student()
        {
            // runtime 
            CompanyName = "V#";
        }
    }
}
