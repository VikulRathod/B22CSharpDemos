using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _17_ClassObjectDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0; // i is a variable of type int

            // Student s1; // s1 is a variable of type Student
            // s1 is a reference variable

            Student s1 = new Student(); // object or instance of Student class
            s1.RollNumber = 1;
            s1.Name = "Ajay";
            s1.City = "Pune";
            // s1.CourseName = "Dot Net";
            s1.Print();

            Student s2 = new Student();
            s2.Create(2, "Chetan", "Mumbai");
            // s2.CourseName = "Dot Net";
            s2.Print();

            Student.CourseName = "C#"; // we can change value of static field

            Student s3 = new Student();
            s3.Create(3, "Farin", "Pune");
            s3.Print();

            //World w1 = new World(); // error creating object of static class

            //World w2 = new World(); // error creating object of static class

            Console.WriteLine($"{World.NumberOfCountries}");

            Console.ReadLine();
        }
    }

    class Student
    {
        public int RollNumber; // instance member
        public string Name;
        public string City;
        public static string CourseName = "Dot Net"; // static member

        public void Print() // non static/ instance
        {
            Console.WriteLine($"Roll Number : {this.RollNumber} Name : {this.Name}" +
                $" City : {this.City} Course Name : {CourseName}");

            // PrintA();
        }

        public void Create(int RollNumber, string Name, string City)
        {
            this.RollNumber = RollNumber;
            this.Name = Name;
            this.City = City;
        }

        public static void PrintA() // static method
        {
            Console.WriteLine("static PrintA() called");
            //Console.WriteLine($"Roll Number : {RollNumber} Name : {Name}" +
            //    $" City : {City} Course Name : {CourseName}");

            // Print(); // not allowed to call static method directly

            // to access instance member from static method we need to create object
            //Student s = new Student();
            //s.Create(4, "Kishor", "Pune");
        }
    }

    static class World
    {
        public static int NumberOfCountries = 290;

        public static int NumberOfContinents = 7;
    }
}
