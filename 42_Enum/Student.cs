using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _42_Enum
{
    // gender
    // male - 1, female = 2

    public class Student
    {
        public int RollNumber { get; set; }
        public string Name { get; set; }
        // public string Gender { get; set; }
        // public int Gender { get; set; }
        public Gender Gender { get; set; }

        // public string Subject { get; set; }

        public Subject Subject { get; set; }
    }

    // public enum Gender : byte
    public enum Gender
    {
        Male,
        Female = 20,
        Unknown
    }

    public enum Subject
    {
        Marathi40,
        Hindi40,
        English35,
        Mathematics32,
        Chemistry25,
        Physics20
    }
}
