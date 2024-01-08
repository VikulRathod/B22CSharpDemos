//using MathLibrary;

namespace _2_ConsoleApp_6
{
    public class MyCalculations
    {
        public void Print()
        {
            Calculator c1 = new Calculator();
            c1.Add(10, 10);
        }
    }

    public struct Customer
    {
        public Customer()
        {
            // 
        }
    }

    public interface ICustomer
    {
        void PrintA();

        public void PrintB()
        {
            Console.WriteLine("Default Implementation");
        }
    }
}
