using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33_varDynamicKeywords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region var keyword

            //  // ?? i = 10; // ?? -> int/ object
            //  // ?? c = '$'; // ?? -> char / object
            //  // ?? s = new Student(); // ?? -> Student / object

            //  // object o = new { Id = 10, Name = "Mahesh" }; // ?? -> object
            //  var o = new { Id = 10, Name = "Mahesh" }; // ?? -> object
            //  Console.WriteLine($"Id : {o.Id} Name : {o.Name}");

            //  //var i = 10;
            //  //var b = true;
            //  //var s = "Vishal";

            //  var i = 10;
            //  Console.WriteLine($"{i.GetType().Name}");
            ////  i = "Vishal";

            #endregion var keyword

            #region dynamic keyword

            //dynamic d = 10;
            //Console.WriteLine(d.GetType().Name); // Int32
            //d = "Mahesh";
            //Console.WriteLine(d.GetType().Name); // String

            //dynamic s = "Vishal";
            //dynamic s1 = new Student();
            //dynamic o = new { Id = 10, Name = "Vishal", Gender = "Male" };

            #endregion dynamic keyword

            //var v1 = new Student();
            //v1.Print(); // compile time error

            // dynamic v1 = new Student();
            // v1.Print();
            // v1.PrintA();

            //Student s1 = new Student();
            //s1.Print();

            //var s1 = new Student();
            //s1.Print();

            //object s1 = new Student();
            //s1.Print(); // compile time error

            dynamic s1 = new Student();
            s1.Print();

            Console.ReadLine();
        }

        //static void Print(var a) // not possible
        //{

        //}
    }
    class Student
    {
        public int RollNumber;
        //  public var Name;// not possible

        public void Print()
        {
            Console.WriteLine("Print() Method");
        }
    }
}
