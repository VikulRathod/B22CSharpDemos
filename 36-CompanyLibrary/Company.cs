using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36_CompanyLibrary
{
    public class Company
    {
        public int CompanyId { get; set; }
        public string Name { get; set; }

        public Employee[] Employees { get; set; }

        public Company(Employee[] emps)
        {
            Employees = emps;
        }

        public string this[int id]
        {
            get
            {
                string name = "No Employee";//string.Empty ;//"";

                for (int i = 0; i < Employees.Length; i++)
                {
                    if (Employees[i].EmployeeId == id)
                    {
                        name = Employees[i].Name;
                        break;
                    }
                }

                return name;
            }

            set
            {
                for (int i = 0; i < Employees.Length; i++)
                {
                    if (Employees[i].EmployeeId == id)
                    {
                        Employees[i].Name = value;
                    }
                }
            }
        }

        public Employee this[string name]
        {
            get
            {
                for (int i = 0; i < Employees.Length; i++)
                {
                    if (Employees[i].Name == name)
                    {
                        return Employees[i];
                    }
                }
                return null;
            }
        }

        public void Details()
        {
            Console.WriteLine($"Company Id : {CompanyId} Name : {Name}");
        }

        public void AllEmployees()
        {
            if(Employees != null & Employees.Length > 0)
            {
                for (int i = 0; i < Employees.Length; i++)
                {
                    Console.WriteLine($"Employee Id : {Employees[i].EmployeeId} " +
                        $"Name : {Employees[i].Name} City : {Employees[i].City} " +
                        $"Experience : {Employees[i].Experience}");
                }
            }
            else
            {
                Console.WriteLine("No Employees in company");
            }
        }
    }
}
