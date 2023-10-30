using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_NullableType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "vishal";
            Console.WriteLine(name);

            name = null; // nullable
            Console.WriteLine(name);

            // int = non nullable
            // int? = nullable

            int? age = null; // non-nullable
            bool? isDelivered = null; // non-nullable
            DateTime? dob = null; // non-nullable

            Nullable<int> marks = null; // nullable

            // int? = all int type values + null value

            int? a = null;
            // int b = (int) a; // int? => int
            int b = a ?? 0;
            Console.WriteLine($"a : {a} b : {b}");

            // string email = "ajay@gmail.com";
             string email = null;
            string emailInUnpper = email?.ToUpper();
            Console.WriteLine($"email: {email}\nemail in upper : {emailInUnpper}");


            Console.ReadLine();
        }
    }
}
