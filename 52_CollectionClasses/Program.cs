using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _52_CollectionClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region array

            //int[] numbers = new int[2];
            //numbers[0] = 10;
            //numbers[1] = 20;
            //// numbers[2] = 30;

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            #endregion array

            #region Arraylist

            //// Console.BackgroundColor = ConsoleColor.Green;

            //ArrayList numbers = new ArrayList(2);
            //numbers.Add(10);
            //numbers.Add("vishal");
            //numbers.Add(10.5f);

            //Console.WriteLine("*** Original Collection ***");

            ////for (int i = 0; i < numbers.Count; i++)
            ////{
            ////    Console.Write($"{numbers[i]} ");
            ////}

            //foreach (int item in numbers) // forward only
            //{
            //    Console.Write($"{item} ");
            //}

            //Console.WriteLine();

            //// add multiple items
            //ICollection temp = new ArrayList() { 40, 50, 60 };
            //numbers.AddRange(temp);

            //Console.WriteLine("*** AddRange(temp) Collection ***");

            ////for (int i = 0; i < numbers.Count; i++)
            ////{
            ////    Console.Write($"{numbers[i]} ");
            ////}

            //foreach (var num in numbers)
            //{
            //    Console.Write($"{num} ");
            //}

            //Console.WriteLine();

            //// 10 20 30 40 50 60

            //// numbers.Add(15);
            //numbers.Insert(1, 15);

            //Console.WriteLine("*** Insert(1, 15) Collection ***");

            ////for (int i = 0; i < numbers.Count; i++)
            ////{
            ////    Console.Write($"{numbers[i]} ");
            ////}

            //foreach (object item in numbers)
            //{
            //    Console.Write($"{item} ");
            //}
            //Console.WriteLine();

            //ICollection temp1 = new ArrayList() { 16, 17, 18 };
            //numbers.InsertRange(2, temp1);

            //Console.WriteLine("*** InsertRange(2, temp1) Collection ***");

            //for (int i = 0; i < numbers.Count; i++)
            //{
            //    Console.Write($"{numbers[i]} ");
            //}
            //Console.WriteLine();

            //bool b1 = numbers.Contains(19);
            //Console.WriteLine($"19 : {b1}"); // false
            //b1 = numbers.Contains(30); // true
            //Console.WriteLine($"30 : {b1}");

            //numbers.Remove(15);
            //numbers.RemoveAt(0);

            //Console.WriteLine("*** Remove(15) RemoveAt(0) Collection ***");

            //for (int i = 0; i < numbers.Count; i++)
            //{
            //    Console.Write($"{numbers[i]} ");
            //}
            //Console.WriteLine();

            //numbers.RemoveRange(0, 3);
            //Console.WriteLine("*** RemoveRange(0, 3) Collection ***");

            //for (int i = 0; i < numbers.Count; i++)
            //{
            //    Console.Write($"{numbers[i]} ");
            //}
            //Console.WriteLine();

            //numbers.Clear(); // removes all items
            //Console.WriteLine($"number of items : {numbers.Count}");

            #endregion Arraylist

            #region Hastable

            //Hashtable students = new Hashtable();
            //students.Add(1, "Mahesh");
            //students.Add(2, "Suresh");
            //students.Add(3, "Ramesh");
            //// students.Add(3, "Kunal");

            //Console.WriteLine("*** ALL ITEMS ***");

            //foreach (DictionaryEntry item in students)
            //{
            //    Console.WriteLine($"Key : {item.Key} Value : {item.Value}");
            //}

            //bool b1 = students.ContainsKey(4);
            //Console.WriteLine($"4 Key : {b1}");

            //b1 = students.ContainsValue("Mahesh");
            //Console.WriteLine($"Mahesh Value : {b1}");

            // object val = students[2];
            //Console.WriteLine($"2 : {val}");

            #endregion Hastable

            #region Stack

            //Stack visitedSites = new Stack();

            //visitedSites.Push("google.com");
            //visitedSites.Push("facebook.com");
            //visitedSites.Push("facebook.com/friends");
            //visitedSites.Push("facebook.com/users/ajay");

            //Console.WriteLine($"Number of items : {visitedSites.Count}");

            //var site = visitedSites.Pop(); // last added item
            //Console.WriteLine($"Returned : {site}");
            //Console.WriteLine($"Pop() : Number of items : {visitedSites.Count}");

            //// site = visitedSites.Pop(); // last added item
            //site = visitedSites.Peek();
            //Console.WriteLine($"Returned : {site}");
            //Console.WriteLine($"Peek() : Number of items : {visitedSites.Count}");

            #endregion Stack

            #region Queue

            Queue bankToken = new Queue();

            bankToken.Enqueue("ajay");
            bankToken.Enqueue("chetan");
            bankToken.Enqueue("ganesh");
            bankToken.Enqueue("anshul");

            Console.WriteLine($"Number of items: {bankToken.Count}");

            //foreach (var item in bankToken)
            //{
            //    Console.WriteLine(item);
            //}

            var token = bankToken.Dequeue();
            Console.WriteLine($"Dequeue() : {token}");
            Console.WriteLine($"Number of items: {bankToken.Count}");

            token = bankToken.Peek();
            Console.WriteLine($"Peek() : {token}");
            Console.WriteLine($"Number of items: {bankToken.Count}");

            #endregion Queue

            Console.ReadLine();
        }
    }
}
