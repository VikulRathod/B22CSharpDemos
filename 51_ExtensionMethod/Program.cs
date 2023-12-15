using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _51_ExtensionMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region string type

            //int i = 10;

            //string name = "vishal";
            //string r1 = name.ToUpper();
            //Console.WriteLine(r1);

            //r1 = name.ToLower();
            //Console.WriteLine(r1);

            //r1 = name.ToCapitalCase(); // capital case
            //Console.WriteLine(r1);

            //string s = "vhaash";
            //r1 = s.ToCapitalCase();
            //Console.WriteLine(r1);

            #endregion string type

            BMW o1 = new BMW();
            o1.Print("A"); // extension method

            AUDI o2 = new AUDI();
            o2.Print("B");
            

            Console.ReadLine();
        }
    }

    public static class StringHelper
    {
        public static string ToCapitalCase(this string name)
        {
            string result = string.Empty;

            for (int i = 0; i < name.Length; i++)
            {
                if(i == 0)
                {
                    result += name[i].ToString().ToUpper();
                }
                else
                {
                    result += name[i];
                }
            }

            return result;
        }
    }

    public interface ICar { }

    public class BMW : ICar
    {
        public int Id { get; set; }
        public static void PrintA()
        {
            // Console.WriteLine(Id);
        }
        public void PrintB()
        {
            Console.WriteLine(this.Id);
        }

        //public void Print()
        //{
        //    Console.WriteLine($"Print() : {GetType().Name}");
        //}
    }

    public class AUDI : ICar
    {
        //public void Print()
        //{
        //    Console.WriteLine($"Print() : {GetType().Name}");
        //}
    }

    public static class CarHelper
    {
        public static void Print(this ICar o, string s)
        {
            Console.WriteLine($"Print() : {s} : {o.GetType().Name}");
        }
    }
}
