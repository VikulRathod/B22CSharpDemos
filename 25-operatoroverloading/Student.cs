using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_operatoroverloading
{
    public class Student
    {
        public int RollNumber;
        public string FirstName;
        public string LastName;

        public Student(int rn, string fn, string ln)
        {
            RollNumber = rn;
            FirstName = fn;
            LastName = ln;
        }

        public static bool operator ==(Student s1, Student s2)
        {
            return s1.RollNumber == s2.RollNumber &&
                s1.FirstName == s2.FirstName &&
                s1.LastName == s2.LastName;
        }

        public static bool operator !=(Student s1, Student s2)
        {
            return s1.RollNumber != s2.RollNumber &&
                s1.FirstName != s2.FirstName &&
                s1.LastName != s2.LastName;
        }

        public static Student operator +(Student s1, Student s2)
        {
            int rollNumber = s1.RollNumber + s2.RollNumber;
            string fn = s1.FirstName + ", " + s2.FirstName;
            string ln = s1.LastName + ", " + s2.LastName;

            return new Student(rollNumber, fn, ln);
        }
    }
}
