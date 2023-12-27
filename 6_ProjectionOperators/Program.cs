using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_ProjectionOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region simple type collection

            //List<string> names = new List<string>()
            //{ "Ajay", "Vishal", "Om", "Chetan" };

            ////List<string> namesInCapital = new List<string>();
            ////foreach (var item in names)
            ////{
            ////    namesInCapital.Add(item.ToUpper());
            ////}

            //IEnumerable<string> namesInCapital = 
            //    names.Select(s => s.ToUpper());

            //foreach (var item in namesInCapital)
            //{
            //    Console.Write($"{item} ");
            //}
            //Console.WriteLine();

            ////List<int> lengths = new List<int>();
            ////foreach (var item in names)
            ////{
            ////    lengths.Add(item.Length);
            ////}

            //IEnumerable<int> lengths = names.Select(s => s.Length);

            //foreach (var item in lengths)
            //{
            //    Console.Write($"{item} ");
            //}
            //Console.WriteLine();

            #endregion simple type collection


            Student s1 = new Student();
            List<Student> students = s1.GetStudents();

            // List<Student> => List<string>

            // IEnumerable<string> names = students.Select(s => s.Name);

            IEnumerable<string> names = from s in students
                                        select s.Name;
            foreach (var item in names)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();

            //IEnumerable<StudentShortData> shorts = students
            //     .Select(s => new StudentShortData() { Name = s.Name, City = s.City });

            var shorts = students.Select(s => new { Name = s.Name, City = s.City });
            //var shorts = from s in students
            //             select new { Name = s.Name, City = s.City };
            foreach (var item in shorts)
            {
                Console.WriteLine($"Name : {item.Name} City : {item.City}");
            }

           IEnumerable<List<string>> subjects =
                students.Select(s => s.Subjects);

            foreach (var subject in subjects)
            {
                foreach (var item in subject)
                {
                    Console.Write($"{item} ");
                }
            }
            Console.WriteLine();

            IEnumerable<string> subjects1 = 
                students.SelectMany(s => s.Subjects);

            foreach (var item in subjects1)
            {
                Console.Write($"{item} ");
            }

            Console.ReadLine();
        }
    }

    public class Student
    {
        public int RollNumber { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string City { get; set; }

        public List<string> Subjects { get; set; }

        public List<Student> GetStudents()
        {
            return new List<Student>()
            {
            new Student(){ RollNumber = 1, Name = "Vishal", Age = 18, City = "Pune", Subjects = new List<string>(){ "S1", "S2"} },
            new Student(){ RollNumber = 2, Name = "Ajay", Age = 21, City = "Mumbai", Subjects = new List<string>(){ "S3"}},
            new Student(){ RollNumber = 3, Name = "Mahesh", Age = 16, City = "Pune", Subjects = new List<string>(){ "S4"}},
            new Student(){ RollNumber = 4, Name = "Dipali", Age = 23, City = "Satara", Subjects = new List<string>(){ "S5", "S6"}},
            new Student(){ RollNumber = 5, Name = "Vrushali", Age = 32, City = "Pune", Subjects = new List<string>(){ "S7"}}
            };
        }
    }

    public class StudentShortData
    {
        public string Name { get; set; }
        public string City { get; set; }
    }
}
