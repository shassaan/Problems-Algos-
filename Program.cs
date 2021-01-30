using System;
using System.Collections.Generic;

namespace problemSolving
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(matchingStrings(new string[]{""},new string[]{"1","2","3"}));
            Console.WriteLine("Hello World!");
        }


        static int[] matchingStrings(string[] strings, string[] queries)
        {
            var queriesWithCounts = new Dictionary<string,int>();
            queries.AddUniqueRange(queriesWithCounts.Add);
            Console.WriteLine(string.Join(",",queriesWithCounts.Keys));
            return null;
        }
    }
}
