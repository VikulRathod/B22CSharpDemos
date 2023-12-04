using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34_abstractionEncapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// you can insert new student data
            //Student s1 = new Student() { 
            //RollNumber = 1, Name = "Vishal", Gender = "Male"
            //};

            ////if (s1.IsValid())
            ////{
            ////    s1.Insert(); // we can insert data
            ////}

            //s1.Insert();

            //Student s2 = new Student();
            //s2.Insert();

            //Student s3 = new Student();

            Student s1 = new Student(10, "Vishal", "Male");
            s1.Insert();
            
            Console.ReadLine();
        }
    }

    public class Student
    {
        private int RollNumber;
        private string Name;
        private string Gender;

        public Student(int rn, string fn, string g)
        {
            RollNumber = rn;
            Name = fn;
            Gender = g;
        }

        private bool IsValid()
        {
            if(RollNumber > 0 && !string.IsNullOrEmpty(Name) &&
                    !string.IsNullOrEmpty(Gender)){
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Insert()
        {
            if (IsValid())
            {
                // code to insert data in database
                Console.WriteLine("New Student Inserted Successfully");
            }
            else
            {
                Console.WriteLine("Invalid Data to Insert");
            }
        }
    }
}
