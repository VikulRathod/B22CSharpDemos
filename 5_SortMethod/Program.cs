using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _5_SortMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Sort() method

            //List<int> numbers = new List<int>() { 2, 17, 25, 8, 4, 56 };

            //numbers.Sort();

            //foreach (int item in numbers)
            //{
            //    Console.Write($"{item} ");
            //}
            //Console.WriteLine();

            //List<string> names = new List<string>() { "X", "E",null, "F", "A",null, "M" };

            //names.Sort();

            //foreach (string item in names)
            //{
            //    Console.Write($"{item} ");
            //}
            //Console.WriteLine();

            //Student s = new Student();
            //List<Student> students = s.GetStudents();

            //// students.Sort();

            ////IComparer<Student> o = new StudentHelper();
            ////// students.Sort(o);
            ////students.Sort(0, 3, o);

            //// public delegate int Comparison<in T>(T x, T y);
            ////Comparison<Student> comp = (x, y) => x.Name.CompareTo(y.Name);
            ////students.Sort(comp);

            //// students.Sort((x, y) => x.Age.CompareTo(y.Age));
            //// students.Sort((x, y) => x.City.CompareTo(y.City));
            //students.Sort((x,y) => y.Age.CompareTo(x.Age));

            //foreach (Student item in students)
            //{
            //    Console.WriteLine($"Roll Number : {item.RollNumber} " +
            //        $"Name : {item.Name} Age : {item.Age} " +
            //        $"City : {item.City}");
            //}

            #endregion Sort() method

            #region Grouping Operators

            Student s1 = new Student();
            List<Student> students = s1.GetStudents();

            Console.WriteLine("Original Collection");
            foreach (Student item in students)
            {
                Console.WriteLine($"Roll Number : {item.RollNumber} " +
                    $"Name : {item.Name} Age : {item.Age} " +
                    $"City : {item.City}");
            }

            // var groups = students.GroupBy(s1 => s1.City);
            //var groups = from s in students
            //             group s by s.City;

            var groups = students.ToLookup(s => s.City);
            

            Console.WriteLine($"Number of Groups : {groups.Count()}");

            foreach (var item in groups)
            {
                Console.WriteLine($"City : {item.Key} Total Students : {item.Count()}");


                foreach (var i in item)
                {
                    Console.WriteLine($"Name : {i.Name}");
                }

                Console.WriteLine("-----------------------------------------");
            }

            #endregion Grouping Operators

            Console.ReadLine();
        }
    }

    public class Student : IComparable
    {
        public int RollNumber { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string City { get; set; }

        public int CompareTo(object obj)
        {
            Student s = obj as Student;
            // sort based on age
            //if(this.Age > s.Age)
            //{
            //    return -1;
            //}
            //else if(this.Age < s.Age)
            //{
            //    return 1;
            //}
            //else
            //{
            //    return 0;
            //}
            return this.Age.CompareTo(s.Age);
        }

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

    public class StudentHelper : IComparer<Student>
    {
        public int Compare(Student x, Student y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }
}
