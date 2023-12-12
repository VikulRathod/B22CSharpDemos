using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36_CompanyLibrary
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public int Experience { get; set; }

        public Company Company { get; set; } // navigation property

        public void Details()
        {
            Console.WriteLine($"Employee Id : {EmployeeId} Name : {Name} " +
                $"City : {City} Experience : {Experience}");
        }
    }
}
