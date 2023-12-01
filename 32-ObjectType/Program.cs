using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _32_ObjectType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region GetType() Method

            //// to retrive type information
            //// 1. typeof() operator - we cna use with type name
            //// 2. GetType() method - we can use with variable

            //int i = 10;
            //Type i1 = typeof(int);
            //Type i1 = i.GetType();
            //Console.WriteLine($"{i1.Namespace} : {i1.Name} : {i1.FullName}");

            //bool b = true;
            //i1 = b.GetType();
            //Console.WriteLine($"{i1.Namespace} : {i1.Name} : {i1.FullName}");

            //string s = "Vishal";
            //i1 = s.GetType();
            //Console.WriteLine($"{i1.Namespace} : {i1.Name} : {i1.FullName}");

            //Student s1 = new Student();
            //i1 = s1.GetType();
            //Console.WriteLine($"{i1.Namespace} : {i1.Name} : {i1.FullName}");


            ////object i = 10;
            ////object b = true;
            ////object s = "Vishal";
            ////object s1 = new Student();

            #endregion GetType() Method

            #region ToString() Method

            //int i = 10, j = 10;
            //Console.WriteLine(i + j);
            //Console.WriteLine(i.ToString() + j.ToString());

            //double d = 10.5;
            //Console.WriteLine(d.ToString());

            //Student s1 = new Student() { FirstName = "Ganesh", LastName = "Pawar" };
            //Console.WriteLine(s1.ToString());

            //Student s2 = new Student() { FirstName = "Vishal", LastName = "Pawar" };
            //Console.WriteLine(s2.ToString());

            #endregion ToString() Method

            #region Equals() Method

            ////int i = 10;
            ////// int j = i;
            ////int j = 11;
            ////// if(i == j)
            ////if(i.Equals(j))
            ////{
            ////    Console.WriteLine("i & j are EQUAL");
            ////}
            ////else
            ////{
            ////    Console.WriteLine("i & j are NOT EQUAL");
            ////}

            //Student s1 = new Student() { FirstName = "Chetan", LastName="Chavhan"};
            //// Student s2 = s1;
            //Student s2 = new Student() { FirstName = "Vishal", LastName = "Chavhan" };
            //if (s1.Equals(s2))
            //{
            //    Console.WriteLine("s1 & s2 are EQUAL");
            //}
            //else
            //{
            //    Console.WriteLine("s1 & s2 are NOT EQUAL");
            //}

            #endregion Equals() Method

            #region GetHashCode() Method

            //int i = 10;
            //int j = 10;

            //Console.WriteLine($"{i.GetHashCode()} : {j.GetHashCode()}");

            //string s1 = "Vishal";
            //string s2 = "Mahesh";
            //string s3 = "Vishal";

            //Console.WriteLine($"s1 : {s1.GetHashCode()}  s2 : {s2.GetHashCode()} " +
            //    $"s3 : {s3.GetHashCode()}");

            //Student sc1 = new Student() { FirstName = "Ajay", LastName = "Rathod"};
            //Student sc2 = new Student() { FirstName = "Ajay", LastName = "Rathod" };

            //Console.WriteLine($"sc1 : {sc1.GetHashCode()}  sc2 : {sc2.GetHashCode()}");

            #endregion GetHashCode() Method

            #region Compare values

            // int i = 10, j = 10;
            Student i = new Student() { FirstName = "Vihaan", LastName = "Rathod"};
            Student j = new Student() { FirstName = "Vihaan", LastName = "Rathod" };

            string result = (i == j) ? "EQUAL" : "NOT EQUAL";
            Console.WriteLine(result); // NOT EQUAL

            result = (i.Equals(j)) ? "EQUAL" : "NOT EQUAL";
            Console.WriteLine(result); // EQUAL

            result = (i.GetHashCode() == j.GetHashCode()) ? "EQUAL" : "NOT EQUAL";
            Console.WriteLine(result); // EQUAL


            #endregion Compare values


            Console.ReadLine();
        }
    }

    public class Student
    {
        public string FirstName;
        public string LastName;

        public override string ToString()
        {
            return FirstName + " " + LastName;
        }

        public override bool Equals(object obj)
        {
            Student s = (Student) obj;

            return this.FirstName.Equals(s.FirstName) &&
                this.LastName.Equals(s.LastName);
        }

        public override int GetHashCode()
        {
            return this.FirstName.GetHashCode() ^ this.LastName.GetHashCode();
        }
    }
}
