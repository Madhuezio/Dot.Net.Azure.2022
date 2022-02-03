using System;
using System.Collections.Generic;
using System.Text;

namespace OOPSconcepts
{

    //Create a C# program that prompts the user for three names of people and stores them in an array of Person-type objects.
    //To do this, first create a Person class that has a Name property of type string,
    //a constructor that receives the name as a parameter, a destructor that assigns the name to empty and overwrites the ToString () method
    public class Person1
    {
        public string Name { get; set; }

        public Person1(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return "Hello! My name is " + Name;
        }

        ~Person1()
        {
            Name = string.Empty;
        }
    }
    class Mutlilevelcontd
    {
        public static void Main9()
        {
            int total = 3;
            Person1[] persons = new Person1[total];

            for (int i = 0; i < total; i++)
            {
                persons[i] = new Person1(Console.ReadLine());
            }

            for (int i = 0; i < total; i++)
            {
                Console.WriteLine(persons[i].ToString());
            }
        }
    }
}
