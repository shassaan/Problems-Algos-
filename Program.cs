﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.Json;
using Problems_Algos_.Models;

namespace problemSolving
{
    class Program
    {
        static void Main(string[] args)
        {
            //matchingStrings(new string[] { "" }, new string[] { "1", "2", "3" });
           Console.WriteLine(JsonSerializer.Serialize(GetPairWhichSumsTo(9,new List<int>{2,4,6,3,1})));
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

        public static List<int> reverseArray(List<int> a)
        {
            var reversedList = new List<int>();
            for (int i = a.Count-1; i >= 0; i--)
            {
                reversedList.Add(a[i]);
            }
            return reversedList;
        }



        /// <summary>
        ///     This methods checks whether there is a cycle in a linkedlist
        /// </summary>
        /// <param name="head">contains starting point of linkedlist</param>
        /// <returns>bool on basis of if cycle exists or not</returns>
        static bool HasCycle(SinglyLinkedListNode head)
        {
            SinglyLinkedListNode temp = new SinglyLinkedListNode();
            List<SinglyLinkedListNode> pointedLocations = new List<SinglyLinkedListNode>();
            temp = head;
            while (temp.Next != null)
            {
                var isVisited = pointedLocations.Any(p => p == temp);
                if (isVisited)
                    return isVisited;
                pointedLocations.Add(temp);
                if (temp.Next == null)
                    return false;
                temp = temp.Next;
            }
            return false;
        }


        static List<int> GetPairWhichSumsTo(int x,List<int> integers)
        {
            var dictionary = new Dictionary<int,int>();
            foreach (var integer in integers)
            {
                dictionary.Add(integer,integers.IndexOf(integer));
            }

            foreach (var integer in integers)
            {
                int firstNumber = x-integer;
                if(dictionary.ContainsKey(firstNumber) && integers.IndexOf(firstNumber) != integers.IndexOf(integer))
                {
                    return new List<int>{integer,firstNumber};
                }
            }
            return null;
        }
    }
}
