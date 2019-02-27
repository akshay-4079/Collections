using System;
using System.Collections;
using System.Collections.Generic;
using CK.System.Collections.Generic;

namespace CollectionsEasy
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            List<int> intList = new List<int>();
            intList.Add(1);
            intList.Add(2);
            intList.Add(3);
            intList.Add(4);

            Console.WriteLine(intList.Count);

            List<string> strList = new List<string>();
            strList.Add("one");
            strList.Add("two");
            strList.Add("three");
            strList.Add("four");
            strList.Add("four");
            strList.Add(null);
            strList.Add(null);

            Console.WriteLine(strList.Count);
            List<Student> studentList = new List<Student>() {
                new Student(){ StudentID=1, StudentName="Bill"},
                new Student(){ StudentID=2, StudentName="Steve"},
                new Student(){ StudentID=3, StudentName="Ram"},
                new Student(){ StudentID=1, StudentName="Moin"}
            };
            Console.WriteLine(studentList.Count);

            List<string> strList1 = new List<string>();
            strList1.AddRange(strList);
            Console.WriteLine(strList1.Count);
            intList.ForEach(el => Console.WriteLine(el));
            strList.ForEach(el => Console.WriteLine(el));
          strList1.ForEach(el => Console.WriteLine(el));
           studentList.ForEach(el => Console.WriteLine(el.StudentName)  );

            for (int i = 0; i < studentList.Count; i++)
            {
                Console.WriteLine(studentList[i].StudentID);
                Console.WriteLine(studentList[i].StudentName);
            }
            studentList.RemoveAt(2);
            for (int i = 0; i < studentList.Count; i++)
            {
               
                Console.WriteLine(studentList[i].StudentName);
            }

        }
    }
    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
    }
}
