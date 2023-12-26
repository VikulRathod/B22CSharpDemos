using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_SortingOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region simple type sorting

            //List<int> numbers = new List<int>() { 2, 45, 17, 23, 15, 7, 188 };

            //Console.WriteLine("*** ALL NUMBERS ***");
            //foreach (var item in numbers)
            //{
            //    Console.Write($"{item} ");
            //}
            //Console.WriteLine();

            ////numbers.Reverse();

            ////Console.WriteLine("*** numbers.Reverse() ***");
            ////foreach (var item in numbers)
            ////{
            ////    Console.Write($"{item} ");
            ////}
            ////Console.WriteLine();

            //var result = numbers.OrderBy(i => i);

            //Console.WriteLine("*** numbers.OrderBy(i => i) ***");
            //foreach (var item in result)
            //{
            //    Console.Write($"{item} ");
            //}
            //Console.WriteLine();

            //var result1 = numbers.OrderByDescending(i => i);

            //Console.WriteLine("*** numbers.OrderByDescending(i => i) ***");
            //foreach (var item in result1)
            //{
            //    Console.Write($"{item} ");
            //}
            //Console.WriteLine();

            #endregion simple type sorting

            #region complex type sorting

            Student s1 = new Student();
            var students = s1.GetStudents();

            Console.WriteLine("*** ALL STUDENTS ***");
            foreach (var item in students)
            {
                Console.WriteLine($"Roll Number : {item.RollNumber} " +
                    $"Name : {item.Name} " +
                    $"Age : {item.Age} " +
                    $"City : {item.City}");
            }

            // var result = students.OrderBy(s => s.City);

            var result = from s in students
                         orderby s.City
                         select s;

            // var result = students.OrderByDescending(s => s.City);

            Console.WriteLine("*** OrderBy(s => s.City) ***");
            foreach (var item in result)
            {
                Console.WriteLine($"Roll Number : {item.RollNumber} " +
                    $"Name : {item.Name} " +
                    $"Age : {item.Age} " +
                    $"City : {item.City}");
            }

            //var result1 = students.OrderBy(s => s.City).ThenBy(s => s.Name);

            //Console.WriteLine("*** OrderBy(s => s.City).ThenBy(s => s.Name) ***");
            //foreach (var item in result1)
            //{
            //    Console.WriteLine($"Roll Number : {item.RollNumber} " +
            //        $"Name : {item.Name} " +
            //        $"Age : {item.Age} " +
            //        $"City : {item.City}");
            //}

            //var result1 = students
            //    .OrderBy(s => s.City)
            //    .ThenByDescending(s => s.Name);

            //var result1 = from s in students
            //              orderby s.City ascending
            //              orderby s.Name descending
            //              select s;

            var result1 = students.OrderBy(s => s.City);
            var result2 = result1.ThenByDescending(s => s.Name);

            Console.WriteLine("*** OrderBy(s => s.City).ThenByDescending(s => s.Name) ***");
            foreach (var item in result1)
            {
                Console.WriteLine($"Roll Number : {item.RollNumber} " +
                    $"Name : {item.Name} " +
                    $"Age : {item.Age} " +
                    $"City : {item.City}");
            }

            #endregion complex type sorting

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
}
