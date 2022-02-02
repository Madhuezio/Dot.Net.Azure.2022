using System;
using System.Collections.Generic;
using System.Text;

namespace OOPSconcepts
{
    /*
    class Student
    {
        int StudentID;
        string StudentName;
        string StudentSchool;
        double StudentRollNo;
        string StudentGender;

        public void GetStudentInformation()
        {
            Console.WriteLine("Please enter student Id");
            StudentID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter student Name");
            StudentName = Console.ReadLine();
            Console.WriteLine("Please enter student School");
            StudentSchool = Console.ReadLine();
            Console.WriteLine("Please enter student RollNo");
            StudentRollNo = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter student Gender");
            StudentGender = Console.ReadLine();
        }

        public void ShowStudentData()
        {
            Console.WriteLine("Student Data :-");
            Console.WriteLine("Student Id : {0}", StudentID);
            Console.WriteLine("Student Name : {0}", StudentName);
            Console.WriteLine("Student School : {0}", StudentSchool);
            Console.WriteLine("Student RollNo : {0}", StudentRollNo);
            Console.WriteLine("Student Gender : {0}", StudentGender);

        }
    }
    class Program1
    {
        static void Main(string[] args)
        {

            //Sample SamepleObject = new Sample();
            //SamepleObject.GetValue();
            //SamepleObject.display();

            Student student = new Student();
            student.GetStudentInformation();
            student.ShowStudentData();
        }
    }

    */
    // holds two data information
    class Student
    {
        int StudentID;
        string StudentName;
        string StudentSchool;
        double StudentRollNo;
        string StudentGender;

        public void GetStudentInformation()
        {
            Console.WriteLine("Please enter student Id");
            StudentID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter student Name");
            StudentName = Console.ReadLine();
            Console.WriteLine("Please enter student School");
            StudentSchool = Console.ReadLine();
            Console.WriteLine("Please enter student RollNo");
            StudentRollNo = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter student Gender");
            StudentGender = Console.ReadLine();
        }

        public void ShowStudentData()
        {
            Console.WriteLine("Student Data :-");
            Console.WriteLine("Student Id : {0}", StudentID);
            Console.WriteLine("Student Name : {0}", StudentName);
            Console.WriteLine("Student School : {0}", StudentSchool);
            Console.WriteLine("Student RollNo : {0}", StudentRollNo);
            Console.WriteLine("Student Gender : {0}", StudentGender);

        }
    }
    class Program1
    {
        static void Main2(string[] args)
        {

            //Sample SamepleObject = new Sample();
            //SamepleObject.GetValue();
            //SamepleObject.display();

            Student[] student = new Student[2];

            for (int i = 0; i < student.Length; i++)
            {
                Student student1 = new Student();
                student1.GetStudentInformation();
                student[i] = student1;
            }
            for (int i = 0; i < student.Length; i++)
            {
                student[i].ShowStudentData();
            }

            Console.WriteLine("Hello World!");
        }
    }
}
