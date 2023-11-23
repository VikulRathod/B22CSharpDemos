using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_methodoverriding_questions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            A a1 = new A(); a1.Print(); // A A A A
            A a2 = new B(); a2.Print(); // A B B A
            A a3 = new C(); a3.Print(); // A B C C
            B b1 = new C(); b1.Print(); // B B C B

            Console.ReadLine();
        }
    }
}
