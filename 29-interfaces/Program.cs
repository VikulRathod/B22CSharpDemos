using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29_interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ICustomer c1 = new ICustomer(); // not possible

            //ICustomerV1 c1 = new SilverCustomer();
            //c1.ShowsTimings();
            //c1.PrintTicket();

            //c1 = new GoldCustomer();
            //c1.ShowsTimings();
            //c1.PrintTicket();

            //SilverCustomer sc = new SilverCustomer();
            //sc.ShowsTimings();

            //ICustomerV1[] customers = new ICustomerV1[2];
            //customers[0] = new SilverCustomer();
            //customers[1] = new GoldCustomer();

            //for (int i = 0; i < customers.Length; i++)
            //{
            //    customers[i].ShowsTimings();
            //    customers[i].PrintTicket();
            //}

            //SilverCustomer sc = new SilverCustomer();
            //sc.ShowsTimings();

            //GoldCustomer gc = new GoldCustomer();
            //gc.ShowsTimings();

            A a = new A();
            a.PrintA();
            a.PrintB();
            // a.Print(); // compiler error
            ((IA)a).Print();
            ((IB)a).Print();

            IA ia = new A();
            ia.PrintA();
            ia.Print();

            IB ib = new A();
            ib.PrintB();
            ib.Print();

            Console.ReadLine();
        }
    }
}
