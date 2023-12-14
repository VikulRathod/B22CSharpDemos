using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _49_LazyLoading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer();

            // Console.WriteLine(c1.Name);

            Console.WriteLine(c1.Name.Value);

            //for (int i = 0; i < c1.Orders.Value.Length; i++)
            //{
            //    Console.WriteLine($"Order Id : {c1.Orders.Value[i].OrderId} " +
            //        $"Description : {c1.Orders.Value[i].Description}");
            //}

            Console.ReadLine();
        }
    }

    public class Order
    {
        public int OrderId { get; set; }
        public string Description { get; set; }
    }

    public class Customer
    {
        public Lazy<string> Name { get; set; }

        public Lazy<Order[]> Orders { get; set; }

        public Customer()
        {
            // Name = GetName();

            Name = new Lazy<string>(GetName);

            // Orders = GetOrders();

            //Func<Order[]> del = GetOrders;
            //Orders = new Lazy<Order[]>(del);

            Orders = new Lazy<Order[]>(GetOrders);
        }

        public string GetName()
        {
            Console.WriteLine("Customer Details Loaded");
            return "Vishal";
        }

        public Order[] GetOrders()
        {
            Console.WriteLine("Order Details Loaded");

            return new Order[]
            {
            new Order(){OrderId = 1, Description = "Order 1" },
            new Order(){OrderId = 2, Description = "Order 2" },
            new Order(){OrderId = 3, Description = "Order 3" }
            };
        }
    }
}
