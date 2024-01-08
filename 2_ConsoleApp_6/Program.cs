using _2_ConsoleApp_6;
//using MathLibrary;

Console.WriteLine("Hello, World!");
Print();

Calculator c = new Calculator();
c.Add(10, 20);

MyCalculations mc = new MyCalculations();
mc.Print();

//var del = () => "Hello";

//var del1 = string () => null;

Customer c1 = new Customer("Vihaan", "Rathod");
Customer c2 = new Customer("Vihaan", "Rathod");

if (c1.Equals(c2))
{
    Console.WriteLine("c1 & c2 are EQUAL");
}
else
{
    Console.WriteLine("c1 & c2 are NOT EQUAL");
}

Console.ReadLine();

static void Print()
{
    Console.WriteLine("Print() Method Called");
}

//public record Customer
//{
//    public string FirstName { get; set; }
//    public string LastName { get; set; }
//}

public record Customer(string FirstName, string LastName);