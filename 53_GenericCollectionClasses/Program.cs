using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _53_GenericCollectionClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region List<>

            //// ArrayList numbers = new ArrayList();
            //// List<object> col = new List<object>();

            //List<int> numbers = new List<int>();
            //numbers.Add(10);
            //numbers.Add(20);
            //numbers.Add(30);

            //Console.WriteLine($"Number of Items : {numbers.Count}");
            //foreach (int item in numbers)
            //{
            //    Console.Write($"{item} ");
            //}
            //Console.WriteLine("\n-----------------------------");

            //List<int> temp = new List<int>() {40,50};
            //numbers.AddRange(temp);
            //foreach (int item in numbers)
            //{
            //    Console.Write($"{item} ");
            //}
            //Console.WriteLine("\n-----------------------------");

            //numbers.Insert(1, 15);
            //foreach (int item in numbers)
            //{
            //    Console.Write($"{item} ");
            //}
            //Console.WriteLine("\n-----------------------------");

            //bool b1 = numbers.Contains(30);
            //Console.WriteLine($"30 Exists? : {b1}"); // true
            //b1 = numbers.Contains(51);
            //Console.WriteLine($"51 Exists? : {b1}"); // false

            //numbers.Remove(30);
            //numbers.RemoveAt(0);
            //numbers.RemoveRange(2, 1);
            //foreach (int item in numbers)
            //{
            //    Console.Write($"{item} ");
            //}
            //Console.WriteLine("\n-----------------------------");

            //numbers.Clear();
            //Console.WriteLine($"Number of items : {numbers.Count}");

            #endregion List<>

            #region Dictionary<>

            //Dictionary<int, string> students =
            //    new Dictionary<int, string>();

            //students.Add(1, "Vishal");
            //students.Add(2, "Mahesh");
            //students.Add(3, "Kunal");

            //Console.WriteLine($"Number of items: {students.Count}");

            ////foreach (var item in students)
            ////{
            ////    Console.WriteLine($"Key : {item.Key} Value : {item.Value}");
            ////}

            //foreach (KeyValuePair<int, string> item in students)
            //{
            //    Console.WriteLine($"Key : {item.Key} Value : {item.Value}");
            //}

            //bool b1 = students.ContainsKey(2);
            //Console.WriteLine($"2 Key Exists? : {b1}");

            //b1 = students.ContainsValue("Vishal");
            //Console.WriteLine($"Vishal Value Exists? : {b1}");

            //string name = students[2];
            //Console.WriteLine(name);

            #endregion Dictionary<>

            #region Stack<>

            //Stack<string> names = new Stack<string>();
            //names.Push("Vishal");
            //names.Push("Kiran");
            //names.Push("Shital");

            //Console.WriteLine($"Number of items : {names.Count}");

            //string name = names.Pop();
            //Console.WriteLine(name);
            //Console.WriteLine($"Number of items : {names.Count}"); // 2

            //name = names.Peek();
            //Console.WriteLine(name); // Kiran
            //Console.WriteLine($"Number of items : {names.Count}"); // 2


            #endregion Stack<>

            #region Queue<>

            Queue<string> names = new Queue<string>();
            names.Enqueue("Vishal");
            names.Enqueue("Kiran");
            names.Enqueue("Sital");

            Console.WriteLine($"Number of items: {names.Count}");

            string name = names.Dequeue();
            Console.WriteLine(name); // Vishal
            Console.WriteLine($"Number of items: {names.Count}"); // 2

            name = names.Peek();
            Console.WriteLine(name); // Kiran
            Console.WriteLine($"Number of items: {names.Count}"); //2

            #endregion Queue<>

            Console.ReadLine();
        }
    }
}
