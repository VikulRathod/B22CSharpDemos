using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_ClassDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rollNumber = 10;
            string name = "Ajay";
            string city = "Pune";
            Console.WriteLine($"Roll Number : {rollNumber}\n" +
                $"Name : {name}\n" +
                $"City : {city}");

            // s1 is a reference variable of type Student pointing to object of type Student
            Student s1 = new Student(); // instance/ object
            s1.RollNumber = 11;
            s1.Name = "Chetan";
            s1.City = "Yavatmal";

            // Console.WriteLine($"Roll Number : {s1.RollNumber} Name : {s1.Name} City : {s1.City}");
            s1.Details();

            Student s2 = new Student(); // object creation / instance creation
            s2.RollNumber = 12;
            s2.Name = "Vasudha";
            s2.City = "Mumbai";

            // Console.WriteLine($"Roll Number : {s2.RollNumber} Name : {s2.Name} City : {s2.City}");
            s2.Details();

            Circle c1 = new Circle();
            c1.Radius = 5;
            // c1.Pi = 3.14f;
            c1.Area();

            Circle c2 = new Circle();
            c2.Radius = 10;
            // c2.Pi = 3.14f;
            c2.Area();

            Console.WriteLine($"Pi : {Circle.Pi}");

            Console.ReadLine();
        }
    }

    // class is simply a template/ structure 
    class Student
    {
        // class fields/ data member
        public int RollNumber;
        public string Name;
        public string City;

        // member functions/ methods
        public void Details()
        {
            Console.WriteLine($"Roll Number : {RollNumber} Name : {Name} City : {City}");
        }
    }
}
