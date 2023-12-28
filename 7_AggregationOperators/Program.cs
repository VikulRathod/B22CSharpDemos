using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_AggregationOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6 };

            var c1 = numbers.Count();
            Console.WriteLine($"Number of items : {c1}");

            var c2 = numbers.LongCount();
            Console.WriteLine($"Number of items : {c2}");

            var c3 = numbers.Min();
            Console.WriteLine($"Minimum value : {c3}"); // 1

            var c4 = numbers.Max();
            Console.WriteLine($"Maximum value : {c4}"); // 6

            var c5 = numbers.Sum();
            Console.WriteLine($"Sum : {c5}");

            var c6 = numbers.Aggregate((i, j) => i + j);
            Console.WriteLine($"Aggregate : {c6}");

            var c7 = numbers.Average();
            Console.WriteLine($"Average : {c7}");

            bool b1 = numbers.Contains(5);
            Console.WriteLine($"Contains(5) : {b1}"); // true
            b1 = numbers.Contains(50);
            Console.WriteLine($"Contains(50) : {b1}"); // false

            // 1 2 3 4 5 6
            // All() -> it checks whether all items matches given condition
            b1 = numbers.All(i => i > 0);
            Console.WriteLine($"All(i => i > 0) : {b1}"); // true

            b1 = numbers.All(i => i > 1);
            Console.WriteLine($"All(i => i > 1) : {b1}"); // false

            // Any() -> it returns true even any one item matches given condition
            b1 = numbers.Any(i => i > 5);
            Console.WriteLine($"Any(i => i > 5) : {b1}"); // true

            b1 = numbers.Any(i => i > 50);
            Console.WriteLine($"Any(i => i > 50) : {b1}"); // false

            // 1 2 3 4 5 6
            b1 = numbers.All(i => i % 2 == 0);
            Console.WriteLine($"All(i => i % 2 == 0) : {b1}"); // false

            b1 = numbers.Any(i => i % 2 == 0);
            Console.WriteLine($"Any(i => i % 2 == 0) : {b1}"); // true

            Student s1 = new Student() { FirstName = "Vihaan", LastName = "Rathod" };
            Student s2 = new Student() { FirstName = "Mihaan", LastName = "Rathod" };
            Student s3 = new Student() { FirstName = "Krishika", LastName = "Rathod" };

            List<Student> students = new List<Student>() { s1, s2, s3};

            Student s4 = new Student() { FirstName = "Vihaan", LastName = "Rathod" };
            bool b2 = students.Contains(s4);
            Console.WriteLine(b2); // false

            b2 = students.Contains(s4, new StudentHelper());
            Console.WriteLine(b2); // true

            Console.ReadLine();
        }
    }

    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //public override bool Equals(object obj)
        //{
        //    Student s = obj as Student;
        //    return this.FirstName.Equals(s.FirstName) &&
        //        this.LastName.Equals(s.LastName);
        //}

        //public override int GetHashCode()
        //{
        //    return FirstName.GetHashCode() ^ LastName.GetHashCode();
        //}
    }

    public class StudentHelper : IEqualityComparer<Student>
    {
        public bool Equals(Student x, Student y)
        {
          return x.FirstName.Equals(y.FirstName) &&
                x.LastName.Equals(y.LastName);
        }

        public int GetHashCode(Student obj)
        {
            return obj.FirstName.GetHashCode() ^ obj.LastName.GetHashCode();
        }
    }
}
