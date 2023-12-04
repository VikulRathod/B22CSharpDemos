using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _35_Properties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Student s1 = new Student();
            //s1.RollNumber = 1; // assigning / setting/ write
            //s1.Name = "Vishal";
            //s1.Passmark = 35;

            //Console.WriteLine($"Roll Number : {s1.RollNumber} " +
            //    $"Name : {s1.Name} Passmark : {s1.Passmark}"); // read/ get/ fetch

            //Student s2 = new Student();
            //s2.RollNumber = -1;
            //s2.Name = null;
            //s2.Passmark = 10;

            //Console.WriteLine($"Roll Number : {s2.RollNumber} " +
            //   $"Name : {s2.Name} Passmark : {s2.Passmark}");

            //Student s2 = new Student();
            //// s2.RollNumber = -1;
            //s2.SetRollNumber(-1);
            //// s2.SetName("Vishal");
            //s2.SetName(null);
            //// s2.GetPassmark(10);

            //Console.WriteLine($"Roll Number : {s2.GetRollNumber()} " +
            //    $"Name : {s2.GetName()} Passmark : {s2.GetPassmark()}");

            Student s = new Student();
            s.RollNumber = 10;
            s.Name = "Vishal";
            Console.WriteLine($"Roll Number : {s.RollNumber} Name : {s.Name}");

            Student s1 = new Student();
            s1.RollNumber = -10;
            s1.Name = null;
            //  s1.Passmark = 10; // read only
            Console.WriteLine($"Roll Number : {s1.RollNumber} Name : {s1.Name} " +
                $"Passmark : {s1.Passmark}");

            //int num = 153, actual = 153;
            //int temp = 0;
            //double sum = 0;
            //for (int i = 0; i < 3; i++)
            //{
            //    temp = num % 10;
            //    sum += Math.Pow(temp, 3);
            //    Console.WriteLine($"{temp}");
            //    num = num / 10;
            //}
            //Console.WriteLine($"actual number : {actual} digit cube sum :  {sum}");


            Console.ReadLine();
        }
    }

    //public class Student
    //{
    //    public int RollNumber;
    //    public string Name;
    //    public int Passmark = 35;
    //}

    //public class Student
    //{
    //    private int _rollNumber;
    //    private string _name;
    //    private int _passmark = 35;

    //    public void SetRollNumber(int rollNumber)
    //    {
    //        if(rollNumber > 0)
    //        {
    //            _rollNumber = rollNumber;
    //        }
    //        else
    //        {
    //            _rollNumber = 0;
    //            Console.WriteLine("RollNumber cannot be negative");
    //        }
    //    }

    //    public int GetRollNumber()
    //    {
    //        return _rollNumber;
    //    }

    //    public void SetName(string name)
    //    {
    //        _name = name;
    //    }
    //    public string GetName()
    //    {
    //        return !string.IsNullOrEmpty(_name) ? _name : "No Name Provided" ;
    //    }

    //    public int GetPassmark()
    //    {
    //        return _passmark;
    //    }
    //}

    public class Student
    {
        private int _rollNumber;
        private string _name;
        private int _passmark = 35;

        public int RollNumber
        {
            get
            {
                return _rollNumber;
            }
            set
            {
                if (value > 0)
                {
                    _rollNumber = value;
                }
                else
                {
                    _rollNumber = 0;
                    Console.WriteLine("Roll Number cannot be negative");
                }
            }
        }

        public string Name
        {
            get
            {
                return !string.IsNullOrEmpty(_name) ? _name : "No Name Provided";
            }
            set
            {
                _name = value;
            }
        }

        public int Passmark
        {
            get
            {
                return _passmark;
            }
            // no set modifier
        }

        private string _city;
        public string City
        {
            get
            {
                return _city;
            }
            set
            {
                _city = value;
            }
        }
        public string Email { get; set; }

        public int StandardId { get; set; }
    }
}
