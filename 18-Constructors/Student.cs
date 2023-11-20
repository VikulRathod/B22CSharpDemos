using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_Constructors
{
    public class Student
    {
        public int RollNumber;
        public string FirstName;
        public string LastName;
        public static string CourseName = "Dot Net";

        // default constructor / parameter less constructor
        public Student()
        {
            Console.WriteLine("public Student() Constructor Called");
            RollNumber = 1;
            FirstName = "Vihaan";
            LastName = "Rathod";
            // CourseName = "Dot Net";
        }

        // parameterized constructor
        public Student(int rn, string fn, string ln)
        {
            Console.WriteLine("Student(int rn, string fn, string ln) Constructor Called");
            RollNumber = rn;
            FirstName = fn;
            LastName = ln;
        }

        // copy constructor
        public Student(Student s)
        {
            this.RollNumber = s.RollNumber;
            this.FirstName = s.FirstName;
            this.LastName = s.LastName;
        }

        // static constructor
        static Student()
        {
            Console.WriteLine("static Student() Constructor Called");
            CourseName = "Dot Net";
        }

        public void Details()
        {
            Console.WriteLine($"Roll Number : {RollNumber} Full Name : {FirstName} {LastName} Course Name : {CourseName}");
        }

        public void Initialize(int rn, string fn, string ln)
        {
            RollNumber = rn;
            FirstName = fn;
            LastName = ln;
        }
    }
}
