using System;
using System.Collections.Generic;
using System.Text;

namespace Collections_Dictionary
{
    public class Student
    {
        public int _studentID;
        public string _studentName;
        
        public Student(int studentID, string studentName)
        {
            _studentID = studentID;
            _studentName = studentName;
        }
    }
    class ExDictionary
    {
        static void Main2(string[] args)
        {
            /*
             
            Console.WriteLine("Grade Book Dictionary : ");
            Dictionary<string, string> IN = new Dictionary<string, string>();
            Console.WriteLine("Enter Student Id and Student Name : ");
            for (int i = 0; i < 3; i++)
            {
                IN.Add(Console.ReadLine(), Console.ReadLine());
            }
            foreach (var item in IN)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }

            */
            //List

            List<Student> students = new List<Student>();
            students.Add(new Student(101, "Madhu"));
            students.Add(new Student(102, "Ezio"));
            students.Add(new Student(103, "Uzmi"));
            students.Add(new Student(104, "JK"));

            foreach(var student in students)
            {
                Console.WriteLine($"StudentID : {student._studentID} StudentName : {student._studentID}");
            }
        }
    }
}
