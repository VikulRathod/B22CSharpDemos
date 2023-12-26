using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_FilteringOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Where Operator

            //Student s1 = new Student();
            //var students = s1.GetStudents();

            //Console.WriteLine("*** ALL STUDENTS ***");
            //foreach (Student item in students)
            //{
            //    Console.WriteLine($"Roll Number : {item.RollNumber} " +
            //        $"Name : {item.Name} Age : {item.Age} " +
            //        $"City : {item.City}");
            //}

            //// var result = students.Where(s => s.City.Equals("Pune"));
            ////var result = students.
            ////    Where(s => s.City.Equals("Pune") && s.Age <= 20);

            //var result = from s in students
            //             where s.City.Equals("Pune") && s.Age <= 20
            //             select s;

            //Console.WriteLine("*** ALL STUDENTS FROM PUNE ***");
            //foreach (Student item in result)
            //{
            //    Console.WriteLine($"Roll Number : {item.RollNumber} " +
            //        $"Name : {item.Name} Age : {item.Age} " +
            //        $"City : {item.City}");
            //}

            //List<object> list = new List<object>()
            //{ 10,"Vishal", new Student(), 10.5f, 20, "Mahesh"};

            //// var result1 = list.Where(o => o.GetType().Name == "String");
            //var result1 = list.Where(o => o.GetType().Name == "Int32");
            //foreach (var item in result1)
            //{
            //    Console.Write($"{item} ");
            //}
            //Console.WriteLine();


            #endregion Where Operator

            #region OfType operator

            List<object> list = new List<object>()
            { 10,"Vishal", new Student(), 10.5f, 20, "Mahesh"};

            // var result = list.OfType<int>();
            var result = list.OfType<string>();
            foreach (var item in result)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();

            List<Car> cars = new List<Car>()
            {
                new Audi(),
                new BMW(),
                new BMW(),
                new BMW(),
                new Audi()
            };

            var result1 = cars.OfType<BMW>();
            foreach (var item in result1)
            {
                Console.WriteLine(item.Name);
            }

            #endregion OfType operator

            Console.ReadLine();
        }
    }

    public class Student
    {
        public int RollNumber { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string City { get; set; }

        public List<Student> GetStudents()
        {
            return new List<Student>()
            {
            new Student(){ RollNumber = 1, Name = "Vishal", Age = 18, City = "Pune"},
            new Student(){ RollNumber = 2, Name = "Ajay", Age = 21, City = "Mumbai"},
            new Student(){ RollNumber = 3, Name = "Mahesh", Age = 16, City = "Pune"},
            new Student(){ RollNumber = 4, Name = "Dipali", Age = 23, City = "Satara"},
            new Student(){ RollNumber = 5, Name = "Vrushali", Age = 32, City = "Pune"}
            };
        }
    }

    public class Car
    {
        public string Name { get; set; }
    }

    public class Audi : Car
    {
        public Audi()
        {
            Name = "Audi";
        }
    }

    public class BMW : Car
    {
        public BMW()
        {
            Name = "BMW";
        }
    }
}
