using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_methodoverriding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Customer c1 = new Customer("Ajay", "Rathod");
            //c1.Print(); // Customer

            //SilverCustomer sc1 = new SilverCustomer("Chetan", "Chavhan");
            //sc1.Print(); // SilverCustomer

            //Customer c2 = new SilverCustomer("Vihaan", "Rathod");
            //c2.Print(); // SilverCustomer

            //Customer c3 = new GoldCustomer("Krishika", "Rathod");
            //c3.Print(); // GoldCustomer

            //Customer c = new Customer("A", "B");
            //c = new SilverCustomer("P", "Q");
            //c = new GoldCustomer("X", "Y");

            int[] numbers = new int[] { 10, 20, 30 };

            Customer[] customers = new Customer[]
            {
            new Customer("Vihaan", "Rathod"),
            new SilverCustomer("Mihaan", "Rathod"),
            new GoldCustomer("Krishika", "Rathod"),
            new AdvancedSilverCustomer("Riya", "Rathod")
            };

            for (int i = 0; i < customers.Length; i++)
            {
                customers[i].Print();
            }

            //AdvancedSilverCustomer adc = new AdvancedSilverCustomer("Ajay", "Rathod");
            //adc.Print();

            Console.ReadLine();
        }
    }
}
