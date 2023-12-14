using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace _50_Reflection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// Early Binding
            //Customer c = new Customer();
            //c.PrintA();

            // Late Binding / Reflection
            // method -> class object -> class -> namespace -> assembly

            Assembly assembly = Assembly.GetExecutingAssembly();
            Type customer = assembly.GetType("_50_Reflection.Customer");

            if(customer != null)
            {
                object c = Activator.CreateInstance(customer);

                if(c != null)
                {
                    MethodInfo printA = customer.GetMethod("PrintA");
                    if(printA != null)
                    {
                        printA.Invoke(c, null);
                    }

                    MethodInfo printC = customer.GetMethod("PrintC");

                    Console.WriteLine("Please enter first name");
                    string fn = Console.ReadLine();

                    Console.WriteLine("Please enter last name");
                    string ln = Console.ReadLine();

                    // printC.Invoke(c, new object[] { "Vishal", "Pawar"});
                    printC.Invoke(c, new object[] { fn, ln });
                }

                MethodInfo printB = customer.GetMethod("PrintB");
                printB.Invoke(null, null);

              MethodInfo printD =  customer.GetMethod("PrintD",
                    BindingFlags.NonPublic | BindingFlags.Instance);

                printD.Invoke(c, null);
            }

            // all methods
            Console.WriteLine("*** All Methods ***");
            MethodInfo[] methods = customer.GetMethods();
            for (int i = 0; i < methods.Length; i++)
            {
                Console.WriteLine(methods[i].Name);
            }

            // all properties
            Console.WriteLine("*** ALL PROPERTIES ***");
            PropertyInfo[] properties = customer.GetProperties();
            for (int i = 0; i < properties.Length; i++)
            {
                Console.WriteLine($"{properties[i].Name} : " +
                    $"{properties[i].PropertyType}");
            }


            Console.ReadLine();
        }
    }

    public class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }

        public void PrintA()
        {
            Console.WriteLine("PrintA() Method Called");
        }

        public static void PrintB()
        {
            Console.WriteLine("Static PrintB() Method Called");
        }

        public void PrintC(string firstName, string lastName)
        {
            Console.WriteLine($"PrintC() Method Called : {firstName} {lastName}");
        }

        private void PrintD()
        {
            Console.WriteLine("Private Method : PrintD() Method Called");
        }
    }
}
