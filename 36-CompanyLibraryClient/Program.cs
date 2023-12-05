using _36_CompanyLibrary;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36_CompanyLibraryClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Employee e = new Employee() { EmployeeId = 1, Name = "Vishal",
            //City = "Mumbai", Experience = 3};
            //e.Company = new Company() { CompanyId = 1, Name = "CG"};
            //Console.WriteLine($"Company Id : {e.Company.CompanyId} Company Name : {e.Company.Name}");

            //e.Details();

            Employee e1 = new Employee() { EmployeeId = 101, Name = "Mahesh",
                City = "Mumbai", Experience = 2};
            Employee e2 = new Employee()
            {
                EmployeeId = 102,
                Name = "Vishal",
                City = "Pune",
                Experience = 5
            };
            Employee e3 = new Employee()
            {
                EmployeeId = 103,
                Name = "Ajay",
                City = "Pune",
                Experience = 1
            };
            Employee e4 = new Employee()
            {
                EmployeeId = 104,
                Name = "Chetan",
                City = "Mumbai",
                Experience = 4
            };
            Employee e5 = new Employee()
            {
                EmployeeId = 105,
                Name = "Vasudha",
                City = "Pune",
                Experience = 4
            };

            Employee[] employees = new Employee[] 
            { e1, e2, e3, e4, e5 };

            Company c = new Company(employees) { CompanyId = 1, Name = "TCS"};
            c.Details();
            c.AllEmployees();

            string name = c[101];
            Console.WriteLine($"Employee Name : {name}"); // Mahesh

            c[101] = "Shital";

            name = c[101];
            Console.WriteLine($"Employee Name : {name}"); // Shital

            Employee ee = c["Shital"];
            Console.WriteLine($"{ee.EmployeeId} {ee.Name} {ee.City} {ee.Experience}");

            Console.ReadLine();
        }
    }
}
