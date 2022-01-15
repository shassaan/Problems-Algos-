using System;
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
            Console.WriteLine(JsonSerializer.Serialize(rotLeft(new List<int> { 1, 2, 3, 4, 5 }, 4)));
        }


        public static List<int> rotLeft(List<int> a, int d)
        {
            //1,2,3,4,5
            for (int i = 0; i < d; i++)
            {
                var elementToShift = a[0];
                a.Remove(a[0]);
                a.Add(elementToShift);
            }
            return a;
        }

        public static void minimumBribes(List<int> q)
        {
            var bribes = 0;
            for (int j = 0; j <= q.Count - 2; j++)
            {
                for (int i = 0; i <= q.Count - 2; i++)
                {
                    if (q[i] > q[i + 1])
                    {
                        var temp = q[i + 1];
                        q[i + 1] = q[i];
                        q[i] = temp;
                        bribes++;
                    }
                }
            }

            Console.WriteLine(bribes);
            if (bribes > 2)
            {
                Console.WriteLine("Too chaotic");
            }
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
            for (int i = a.Count - 1; i >= 0; i--)
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


        public int[] TwoSumBruteForce(int[] nums, int target)
        {
            int[] arr = new int[2];
            for(int i = 0;i<nums.Length;i++)
            {
                for (int j = 1;j<nums.Length;j++)
                {
                    if(nums[i] + nums [j] == target && i != j)
                    {
                        arr[0] = i;
                        arr[1] = j;
                        return arr;
                    }
                }
            }
            return arr;
        }

        public int[] TwoSumDictionary(int[] nums, int target)
        {
            int[] arr = new int[2];
            var dictionary = new Dictionary<int,int>();
            for(int i = 0;i<nums.Length;i++)
            {
                var difference = target - nums[i];
                if(dictionary.ContainsKey(difference))
                {
                    arr[0] = i;
                    arr[1] = dictionary[difference];
                    return arr;
                }
                else if(!dictionary.ContainsKey(nums[i]))
                {
                    dictionary.Add(nums[i],i);
                }
            }
            return arr;
        }
    }
}
