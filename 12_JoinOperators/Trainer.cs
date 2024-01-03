using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_JoinOperators
{
    public class Trainer
    {
        public int TrainerId { get; set; }
        public string TrainerName { get; set; }
        public int Experience { get; set; }

        public static List<Trainer> GetTrainers()
        {
            return new List<Trainer>()
            {
            new Trainer(){ TrainerId = 1, TrainerName = "Vikul", Experience = 14 },
            new Trainer(){ TrainerId = 2, TrainerName = "Usha", Experience = 3 },
            new Trainer(){ TrainerId = 3, TrainerName = "Atul", Experience = 2 }
            };
        }
    }

    public class Student
    {
        public int RollNumber { get; set; }
        public string StudentName { get; set; }
        public string City { get; set; }

        public int? TrainerId { get; set; }

        public static List<Student> GetStudents()
        {
            return new List<Student>()
            {
            new Student(){ RollNumber = 1, StudentName = "Ajay", City = "Pune",
            TrainerId = 1},
            new Student(){ RollNumber = 2, StudentName = "Mahesh", City = "Mumbai",
            TrainerId = 2},
            new Student(){ RollNumber = 3, StudentName = "Vishal", City = "Mumbai",
            TrainerId = 1},
            new Student(){ RollNumber = 4, StudentName = "Shital", City = "Pune",
            TrainerId = null},
            new Student(){ RollNumber = 5, StudentName = "Snehal", City = "Pune",
            TrainerId = null}
            };
        }
    }
}
