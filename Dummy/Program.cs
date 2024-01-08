using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dummy
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10, j = 10, k = 20;

            bool b = i != j || i < k;

            bool b1 = i != j & i < k;


            Console.ReadLine();
        }
    }
}
