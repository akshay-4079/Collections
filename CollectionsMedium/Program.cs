using System;
using System.Collections.Generic;
using System.Linq;

namespace CollectionsMedium
{
    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
    }
    class StudentDictionaryComparer : IEqualityComparer<KeyValuePair<int, Student>>
    {
        public bool Equals(KeyValuePair<int, Student> x, KeyValuePair<int, Student> y)
        {
            if (x.Key == y.Key && (x.Value.StudentID == y.Value.StudentID) && (x.Value.StudentName == y.Value.StudentName))
                return true;

            return false;
        }

        public int GetHashCode(KeyValuePair<int, Student> obj)
        {
            return obj.Key.GetHashCode();
        }
    }

    class MainClass
    {
        public static void Main(string[] args)
        {
            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(1, "Akshay");
            dict.Add(2, "C #");
            dict.Add(3, "Visual Studio");
            dict.Add(4, "Aks");
            foreach (KeyValuePair<int, string> item in dict)
            {
                Console.WriteLine("Key: {0}, Value: {1}", item.Key, item.Value);
            }
                Console.WriteLine(dict[1]);
                string result;

                if (dict.TryGetValue(5, out result))
                {
                    Console.WriteLine(result);
                }
                else
                {
                Console.WriteLine("Could not find the specified key.");
                }
           bool check=dict.ContainsKey(5);
            Console.WriteLine(check);
            dict.Remove(1);
            foreach (KeyValuePair<int, string> item in dict)
            {
                Console.WriteLine("Key: {0}, Value: {1}", item.Key, item.Value);
            }
            IDictionary<int, Student> studentDict = new Dictionary<int, Student>()
                    {
                        { 1, new Student(){ StudentID =1, StudentName = "Bill"}},
                        { 2, new Student(){ StudentID =2, StudentName = "Steve"}},
                        { 3, new Student(){ StudentID =3, StudentName = "Ram"}}
                    };

            Student std = new Student() { StudentID = 1, StudentName = "Bill" };

            KeyValuePair<int, Student> elementToFind = new KeyValuePair<int, Student>(1, std);

            bool result1 = studentDict.Contains(elementToFind, new StudentDictionaryComparer()); // returns true

            Console.WriteLine(result1);
        }
    }
}
