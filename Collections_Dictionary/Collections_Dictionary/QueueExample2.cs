using System;
using System.Text;
using System.Collections;

namespace Collections_Dictionary
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }


        public override string ToString()
        {
            return Name + " - " + Age;
        }
        class QueueObjects
        {
            public static void Main(string[] args)
            {
                System.Collections.Queue queue = new System.Collections.Queue();
                int total = 3;

                for (int i = 0; i < total; i++)
                {
                    string name = Console.ReadLine();
                    int age = int.Parse(Console.ReadLine());

                    queue.Enqueue(name);
                    queue.Enqueue(age);
                }

                for (int i = 0; i < total; i++)
                {
                    Person p = (Person)queue.Dequeue();
                    Console.WriteLine(p.ToString());
                }
            }
        }
    }
}
