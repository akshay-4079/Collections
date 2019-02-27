using System;
using System.Collections.Generic;

namespace CollectionsHard
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            SortedList<int, string> sortedList1 = new SortedList<int, string>();
            sortedList1.Add(3, "Three");
            sortedList1.Add(4, "Four");
            sortedList1.Add(1, "One");
            sortedList1.Add(5, "Five");
            sortedList1.Add(2, "Two");
            SortedList<double, int?> sortedList2 = new SortedList<double, int?>();
            sortedList2.Add(1.5, 100);
            sortedList2.Add(3.5, 200);
            sortedList2.Add(2.4, 300);
            sortedList2.Add(2.3, null);
            sortedList2.Add(1.1, null);
            Console.WriteLine(sortedList2[1.5]);
            Console.WriteLine(sortedList2[2.4]);
            Console.WriteLine(sortedList2[1.1]);
            Console.WriteLine(sortedList1[3]);
            SortedList<string, int> sortedList3 = new SortedList<string, int>();
            sortedList3.Add("one", 1);
            sortedList3.Add("two", 2);
            sortedList3.Add("three", 3);
            sortedList3.Add("four", 4);
            foreach (KeyValuePair<string, int> kvp in sortedList3)
            {
                Console.WriteLine("key: {0}, value: {1}", kvp.Key, kvp.Value);
            }
        }
    }
}
