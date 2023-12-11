using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace _42_Enum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.RollNumber = 1;
            s1.Name = "Vishal";
            // s1.Gender = "Male";
            // s1.Gender = 1;
            s1.Gender = Gender.Male;
            //s1.Subject = Subject.Mathematics;

            //Console.WriteLine($"Roll Number : {s1.RollNumber} Name : {s1.Name} " +
            //    $"Gender : {GetGender(s1.Gender)}");

            Console.WriteLine($"Roll Number : {s1.RollNumber} Name : {s1.Name} " +
                $"Gender : {s1.Gender}");

            Student s2 = new Student();
            s2.RollNumber = 2;
            s2.Name = "Mahesh";
            // s2.Gender = "Bond007";
            // s2.Gender = 1;
            s2.Gender = Gender.Male;

            //Console.WriteLine($"Roll Number : {s2.RollNumber} Name : {s2.Name} " +
            //    $"Gender : {GetGender(s2.Gender)}");
            Console.WriteLine($"Roll Number : {s2.RollNumber} Name : {s2.Name} " +
               $"Gender : {s2.Gender}");

            Student s3 = new Student();
            s3.RollNumber = 3;
            s3.Name = "Kiran";
            s3.Gender = Gender.Unknown;

            Console.WriteLine($"Roll Number : {s3.RollNumber} Name : {s3.Name} " +
               $"Gender : {s3.Gender}");

            Type t = Enum.GetUnderlyingType(typeof(Gender));
            Console.WriteLine($"Underlying type : {t.Name}");

            Console.WriteLine("All Items from enum");
            string[] names = Enum.GetNames(typeof(Gender));

            for (int i = 0; i < names.Length; i++)
            {
                Console.Write($"{names[i]}\t");
            }
            Console.WriteLine(); // new line

            int[] values = (int[]) Enum.GetValues(typeof(Gender));

            Console.WriteLine("All Values Of Enum Items");
            for (int i = 0; i < values.Length; i++)
            {
                Console.Write($"{values[i]}\t");
            }
            Console.WriteLine(); // new line

            Console.ReadLine();
        }

        static string GetGender(int gender)
        {
            switch (gender)
            {
                case 1:
                    return "Male";
                case 2:
                    return "Female";
                default:
                    return "Invalid Gender";
            }
        }
    }
}
