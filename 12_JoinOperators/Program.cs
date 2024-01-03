using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _12_JoinOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region let keyword

            //// let keyword
            //List<string> names = new List<string>() { "Vishal", "Ajay", "Mahesh" };

            //var name = (from n in names
            //            let search = "VISHAL"
            //            where n.ToUpper() == search
            //            select search).FirstOrDefault();

            //Console.WriteLine($"Name : {name}");

            #endregion let keyword


            List<int> numbers = new List<int>() { 1,2,3,4,5};
            // var result = numbers.Where(i => i % 2 == 0).ToList();
            var result = numbers.FindAll(i => i % 2 == 0);

            foreach (var item in result)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();

            List<Trainer> trainers = Trainer.GetTrainers();

            Console.WriteLine("*** ALL TRAINERS ***");
            foreach (var item in trainers)
            {
                Console.WriteLine($"Trainer Id : {item.TrainerId} Name : {item.TrainerName} " +
                    $"Experience : {item.Experience}");
            }

            List<Student> students = Student.GetStudents();
            Console.WriteLine("*** ALL STUDENTS ***");
            foreach (var item in students)
            {
                Console.WriteLine($"Roll Number : {item.RollNumber} Name : {item.StudentName} " +
                    $"City : {item.City} Trainer Id : {item.TrainerId}");
            }

            #region method syntax

            //// method syntax

            //var result = students.Join(trainers, s => s.TrainerId, t => t.TrainerId,
            //      (s, t) =>
            //      new { StudentName = s.StudentName, TrainerName = t.TrainerName });

            //Console.WriteLine("*** students.Join(trainers ***");
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"Student Name : {item.StudentName} " +
            //        $"Trainer Name : {item.TrainerName}");
            //}

            //var result1 = students.GroupJoin(trainers, s => s.TrainerId, t => t.TrainerId,
            //      (s, ts) =>
            //      new
            //      {
            //          StudentName = s.StudentName,
            //          TrainerName =
            //          ts.FirstOrDefault(t => t.TrainerId == s.TrainerId)?.TrainerName
            //      });

            //Console.WriteLine("*** students.GroupJoin(trainers ***");
            //foreach (var item in result1)
            //{
            //    Console.WriteLine($"Student Name : {item.StudentName} " +
            //        $"Trainer Name : {item.TrainerName}");
            //}

            #endregion method syntax

            // inner join
            var inner = from s in students
                        join t in trainers
                        on s.TrainerId equals t.TrainerId
                        select new
                        {
                            StudentName = s.StudentName,
                            TrainerName = t.TrainerName
                        };
            Console.WriteLine("*** INNER JOIN ***");
            foreach (var item in inner)
            {
                Console.WriteLine($"Student Name : {item.StudentName} " +
                    $"Trainer Name : {item.TrainerName}");
            }

            // left join

            var left = from s in students
                       join t in trainers
                       on s.TrainerId equals t.TrainerId
                       into temp
                       from tt in temp.DefaultIfEmpty()
                       select new
                       {
                           StudentName = s.StudentName,
                           TrainerName = tt?.TrainerName
                       };
            Console.WriteLine("*** LEFT JOIN ***");
            foreach (var item in left)
            {
                Console.WriteLine($"Student Name : {item.StudentName} " +
                    $"Trainer Name : {item.TrainerName}");
            }

            // right join

            var right = from t in trainers
                        join s in students
                        on t.TrainerId equals s.TrainerId
                        into temp
                        from ss in temp.DefaultIfEmpty()
                        select new
                        {
                            StudentName = ss?.StudentName,
                            TrainerName = t.TrainerName
                        };
            Console.WriteLine("*** RIGHT JOIN ***");
            foreach (var item in right)
            {
                Console.WriteLine($"Student Name : {item.StudentName} " +
                    $"Trainer Name : {item.TrainerName}");
            }

            // full join

            var full = left.Union(right);
            Console.WriteLine("*** FULL JOIN ***");
            foreach (var item in full)
            {
                Console.WriteLine($"Student Name : {item.StudentName} " +
                    $"Trainer Name : {item.TrainerName}");
            }

            // cross join
            var cross = from s in students
                        from t in trainers
                        select new
                        { StudentName = s.StudentName, TrainerName = t.TrainerName };
            Console.WriteLine("*** CROSS JOIN ***");
            foreach (var item in cross)
            {
                Console.WriteLine($"Student Name : {item.StudentName} " +
                    $"Trainer Name : {item.TrainerName}");
            }

            // select all students & trainers data inner join
            var all = from s in students
                      join t in trainers
                      on s.TrainerId equals t.TrainerId
                      select new { Student = s, Trainer = t };
            Console.WriteLine("*** all student trainer data with JOIN ***");
            foreach (var item in all)
            {
                Console.WriteLine($"Student Name : {item.Student.StudentName} " +
                    $"City : {item.Student.City}" +
                    $"Trainer Name : {item.Trainer.TrainerName} " +
                    $"Experience : {item.Trainer.Experience}");
            }

            // select all students data 
            var studentsData = from s in students
                               join t in trainers
                               on s.TrainerId equals t.TrainerId
                               select s;
            Console.WriteLine("*** all student data with JOIN ***");
            foreach (var item in studentsData)
            {
                Console.WriteLine($"Roll Number : {item.RollNumber} " +
                    $"Name : {item.StudentName} " +
                    $"City : {item.City}");
            }

            Console.ReadLine();
        }
    }
}
