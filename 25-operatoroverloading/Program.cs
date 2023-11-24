using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_operatoroverloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region int type with == operator

            //int i = 10;
            //// int j = i;
            //int j = 10;
            //if(i == j)
            //{
            //    Console.WriteLine("i & j are EQUAL");
            //}
            //else
            //{
            //    Console.WriteLine("i & j are NOT EQUAL");
            //}

            //int i = 10, j = 10;
            //int k = i + j;
            //Console.WriteLine(k);

            #endregion int type with == operator

            #region string type with == operator

            //string s1 = "Ajay";
            //// string s2 = s1;
            //string s2 = "Vijay";
            //if(s1 == s2)
            //{
            //    Console.WriteLine("s1 & s2 are EQUAL");
            //}
            //else
            //{
            //    Console.WriteLine("s1 & s2 are NOT EQUAL");
            //}

            //string s1 = "Vishal", s2 = "Pawar";
            //string s3 = s1 + s2;
            //Console.WriteLine(s3);

            #endregion string type with == operator

            #region Student type with == operator

            //Student s1 = new Student(1, "Ajay", "Rathod");
            //// Student s2 = s1;
            //Student s2 = new Student(1, "Ajay", "Rathod");

            //// if(s1 == s2)
            ////if(s1.RollNumber == s2.RollNumber && 
            ////    s1.FirstName == s2.FirstName &&
            ////    s1.LastName == s2.LastName)
            //if(s1 == s2) // s1 & s2 are operands 
            //{
            //    Console.WriteLine("s1 & s2 are EQUAL");
            //}
            //else
            //{
            //    Console.WriteLine("s1 & s2 are NOT EQUAL");
            //}

            Student s1 = new Student(1, "Vishal", "Pawar");
            Student s2 = new Student(2, "Mahesh", "Deshpande");

            Student s3 = s1 + s2;
            Console.WriteLine($"{s3.RollNumber} : {s3.FirstName} : {s3.LastName}");

            #endregion Student type with == operator

            Console.ReadLine();
        }
    }
}
