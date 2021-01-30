using System;
using System.Collections.Generic;
using System.Linq;

namespace problemSolving
{
    class Program
    {
        static void Main(string[] args)
        {
            matchingStrings(new string[] { "" }, new string[] { "1", "2", "3" });
            Console.WriteLine("Hello World!");
        }


        /// <summary>
        ///     returns array containing frequencies of "qeuries" in "strings"
        /// </summary>
        /// <param name="strings">list of strings</param>
        /// <param name="queries">list containing queries for which we want the frequencies</param>
        /// <returns>array of integers containing frequencies</returns>

        static int[] matchingStrings(string[] strings, string[] queries)
        {
            var counts = new List<int>();
            foreach (var query in queries)
            {
                counts.Add(strings.Where(s => s == query).Count());
            }
            return counts.ToArray();
        }
    }
}
