using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_ConversionOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region AsEnumerable, AsQueryable

            //List<int> numbers = new List<int>() { 1, 2, 3 };

            //IQueryable<int> numbers1 = numbers.AsQueryable();

            //ArrayList numbers2 = new ArrayList() { 1, 2, 3 };

            //IEnumerable<int> numebrs3 = numbers2.Cast<int>();

            #endregion AsEnumerable, AsQueryable

            #region ToArray, ToList, ToDictionary

            int[] numbers1 = new int[] { 1, 2, 3 };

            // array -> list
            List<int> numbers2 = numbers1.ToList();

            // array -> dictionary
            Dictionary<int, int> numbers3 =
                numbers1.ToDictionary<int, int>(i => i);

            // list -> array
            int[] numbers4 = numbers2.ToArray();

            // list -> dictionary
            Dictionary<int, int> numbers5 =
                numbers2.ToDictionary<int, int>(i => i);

            foreach (var item in numbers5)
            {
                Console.WriteLine($"Key : {item.Key} Value : {item.Value}");
            }

            // dictionary -> list
            List<KeyValuePair<int,int>> numbers6 = 
                numbers5.ToList<KeyValuePair<int, int>>();

            #endregion ToArray, ToList, ToDictionary

            Console.ReadLine();
        }
    }
}
