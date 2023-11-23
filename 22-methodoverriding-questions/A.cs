using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_methodoverriding_questions
{
    public class A
    {
        public virtual void Print()
        {
            Console.WriteLine("A");
        }
    }
    public class B : A
    {
        public override void Print()
        {
            Console.WriteLine("B");
        }
    }
    public class C : B
    {
        public override void Print()
        {
            Console.WriteLine("C");
        }
    }
}
