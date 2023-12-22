using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Intro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Generation Operators

            //List<Student> students = new List<Student>()
            //{
            //new Student(){ RollNumber = 1, Name = "Vishal", Age = 18},
            //new Student(){ RollNumber = 2, Name = "Mahesh", Age = 23},
            //new Student(){ RollNumber = 3, Name = "Divya", Age = 25},
            //new Student(){ RollNumber = 4, Name = "Priyanka", Age = 32},
            //new Student(){ RollNumber = 5, Name = "Rohan", Age = 15}
            //};

            //Console.WriteLine("*** ALL STUDENTS ***");
            //foreach (Student item in students)
            //{
            //    Console.WriteLine($"Roll Number : {item.RollNumber} " +
            //        $"Name : {item.Name} Age : {item.Age}");
            //}

            //// filter students having age 18 to 25

            ////List<Student> result1 = new List<Student>();
            ////foreach (Student item in students)
            ////{
            ////    if (item.Age >= 18 && item.Age <= 25)
            ////    {
            ////        result1.Add(item);
            ////    }
            ////}

            //// Func<Student, bool>
            //// var result1 = students.Where(s => s.Age >= 18 && s.Age <= 25);

            ////var result1 = from s in students
            ////              select s;

            //// var result1 = students.Select(s => s);

            ////var result1 = from s in students
            ////              where s.Age >= 18 && s.Age <= 25
            ////              select s;

            //// var result1 = students.Where(s => s.Age >= 18 && s.Age <= 25);

            ////var result1 = from s in students
            ////              orderby s.Name
            ////              select s;

            //var result1 = students.OrderBy(s => s.Name);


            //Console.WriteLine("*** ALL STUDENTS having age 18 to 25 ***");
            //foreach (Student item in result1)
            //{
            //    Console.WriteLine($"Roll Number : {item.RollNumber} " +
            //        $"Name : {item.Name} Age : {item.Age}");
            //}

            #endregion Generation Operators

            string cs = "data source=.\\sqlexpress;database=B22DB;integrated security=true";
            SqlConnection con = new SqlConnection(cs);

            SqlCommand cmd = new SqlCommand("select * from Student", con);
            con.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            List<Student> students = new List<Student>();

            while (reader.Read())
            {
                Student s = new Student();
                s.RollNumber = (int)reader["Id"];
                s.Name = reader["Name"].ToString();
                s.City = reader["City"].ToString();

                students.Add(s);
            }

            con.Close();

            foreach (Student s in students)
            {
                Console.WriteLine($"Roll Number : {s.RollNumber} Name : {s.Name} " +
                    $"City = {s.City}");
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

        public int TrainerId { get; set; }
    }
}
