using System;
using System.Collections.Generic;
using System.Text;

namespace OOPSconcepts
{

    /*
    class A
    {
        int amember;
        public A(int _amember)
        {
            amember = _amember;
        }
        public void PrintA()
        {
            Console.WriteLine(amember);
        }
    }
    class B : A
    {
        int bmember;
        public B(int _bmember) : base(_bmember)
        {
            bmember = _bmember;
        }
        public void PrintB()
        {
            Console.WriteLine(bmember);
        }
    }
    class C : B
    {
        int cmember;
        public C(int _cmember) : base(_cmember)
        {
            cmember = _cmember;
        }
        public void PrintC()
        {
            Console.WriteLine(cmember);
        }
    }
    */

    //

    public class Person
    {
        protected int age;

        public void Greet()
        {
            Console.WriteLine("Hello!");
        }

        public void SetAge(int n)
        {
            age = n;
        }
    }

    public class Student1 : Person
    {
        public void Study()
        {
            Console.WriteLine("I'm studying");
        }

        public void ShowAge()
        {
            Console.WriteLine("My age is {0} years old", age);
        }
    }

    public class Teacher : Person
    {
        public void Explain()
        {
            Console.WriteLine("I'm explaining on the screen");
        }
    }
    class StudentProffessorTest
    {
        static void Main8(string[] args)
        {
            // Console.WriteLine("Hello World!");
            // C cobject = new C(3);
            // cobject.PrintA();
            // cobject.PrintB();
            // cobject.PrintC();

            Person myPerson = new Person();
            myPerson.Greet();

            Student1 myStudent = new Student1();
            myStudent.SetAge(23);
            myStudent.Greet();
            myStudent.ShowAge();
            myStudent.Study();

            Teacher myTeacher = new Teacher();
            myTeacher.SetAge(30);
            myTeacher.Greet();
            myTeacher.Explain();

        }
    }
}
