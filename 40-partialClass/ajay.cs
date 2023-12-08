// ajay class file
// properties
public partial class Student
    : IStudent
{
    public string Name { get; set; }

    public Student()
    {
        PrintA(); // partial method call
        //
        //
    }

    partial void PrintA();

    // partial void PrintA() { }
}

interface IStudent
{
    void Print();
}

public class A { }
public class B { }