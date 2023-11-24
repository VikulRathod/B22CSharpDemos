using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_methodoverloading
{
    public class Calculator
    {
        public void Print()
        {
            Console.WriteLine("Print() Called");
        }

        public void Print(int num)
        {
            Console.WriteLine("Print(int num) Called");
        }

        public void Print(short num)
        {
            Console.WriteLine("Print(short num) Called");
        }

        // this is not overloading
        //public int Print(int num)
        //{            
        //    Console.WriteLine("Print(int num) Called");
        //    return 10;
        //}

        public void Print(ref int num)
        {
            Console.WriteLine("Print(ref int num) Called");
        }

        // this nois not overloading
        //public void Print(out int num)
        //{
        //    num = 10;
        //    Console.WriteLine("Print(ref int num) Called");
        //}

        public void Print(int num1, int num2)
        {
            Console.WriteLine("Print(int num1, int num2) Called");
        }

        public void Print(string name)
        {
            Console.WriteLine("Print(string name) Called");
        }

        public void Print(int num, string name)
        {
            Console.WriteLine("Print(int num, string name) Called");
        }

        public void Print(string name, int num)
        {
            Console.WriteLine("Print(string name, int num) Called");
        }

        public void Print(int[] num)
        {
            Console.WriteLine("Print(int[] num) Called");
        }

        // this is not overloading
        //public void Print(params int[] num)
        //{
        //    Console.WriteLine("params Print(int[] num) Called");
        //}
    }
}
