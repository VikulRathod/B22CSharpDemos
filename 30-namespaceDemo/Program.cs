using _30_namespaceDemo.bankmodels;
using Bank;
using Cinema;
using System; // to import namespace
using ab = Cinema.Abhiruchi;

class Program
{
    static void Main()
    {
        Convert.ToInt32("10");

        //System.Console.WriteLine("Hello");

        //System.Console.ReadLine();

        Console.WriteLine("Hello");

        SilverCustomer sc = new SilverCustomer();
        sc.Details();        

        SavingsCustomer sc1 = new SavingsCustomer();
        sc1.Details();

        // Cinema.Abhiruchi.Customer c1 = new Cinema.Abhiruchi.Customer();
        ab.Customer c1 = new ab.Customer();

        Account a = new Account();
        a.Details();

        Console.ReadLine();
    }
}
