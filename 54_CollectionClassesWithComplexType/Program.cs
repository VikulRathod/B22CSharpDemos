using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _54_CollectionClassesWithComplexType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student() { RollNumber = 1, Name = "Vishal", City = "Pune" };
            Student s2 = new Student() { RollNumber = 2, Name = "Mahesh", City = "Pune" };
            Student s3 = new Student() { RollNumber = 3, Name = "Dipak", City = "Mumbai" };
            Student s4 = new Student() { RollNumber = 4, Name = "Aniket", City = "Pune" };
            Student s5 = new Student() { RollNumber = 5, Name = "Shital", City = "Pune" };

            #region List<Student>

            //List<Student> students = new List<Student>();
            //students.Add(s1);
            //students.Add(s2);
            //students.Add(s3);
            //students.Add(s4);
            //students.Add(s5);

            //Console.WriteLine("*** ALL STUDENTS ***");
            //foreach (Student item in students)
            //{
            //    Console.WriteLine($"Roll Number : {item.RollNumber} " +
            //        $"Name : {item.Name} City : {item.City}");
            //}

            #endregion List<Student>

            #region Dictionary<int, Student>

            //Dictionary<int, List<Student>> students1 = 
            //    new Dictionary<int, List<Student>>();

            Dictionary<int, Student> students = new Dictionary<int, Student>();
            students.Add(s1.RollNumber, s1);
            students.Add(s2.RollNumber, s2);
            students.Add(s3.RollNumber, s3);
            students.Add(s4.RollNumber, s4);
            students.Add(s5.RollNumber, s5);

            Student s = students[2];
            Console.WriteLine($"Roll Number : {s.RollNumber} " +
                $"Name : {s.Name} City : {s.City}");

            Console.WriteLine("*** ALL STUDENTS ***");
            // foreach (var item in students)
            // foreach (object item in students) // will not give Key, Value properties
            foreach (KeyValuePair<int, Student> item in students)
            {
                Console.WriteLine(item.Key);
                Student ss = item.Value;

                Console.WriteLine($"Roll Number : {ss.RollNumber} " +
                $"Name : {ss.Name} City : {ss.City}");
            }

            #endregion Dictionary<int, Student>

            Console.ReadLine();
        }
    }

    public class Student
    {
        public int RollNumber { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
    }
}
