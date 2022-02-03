using System;
using System.Collections.Generic;
using System.Text;

namespace OOPSconcepts
{
    public class Dog : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("Eating");
        }
    }

    public abstract class Animal
    {
        private string Name;

        public void SetName(string name)
        {
            Name = name;
        }

        public string GetName()
        {
            return Name;
        }
        public abstract void Eat();
    }

    /*
      
   
    class DummyA
    {
        public virtual void show()
        {
            Console.WriteLine("I am coming from A");
        }
    }
    class DummyB : DummyA
    {
        public override void show()
        {
            Console.WriteLine("I am coming from B");
        }
    }

    */

    class Overriding
    {

        static void Main10(string[] args)
        {
            //DummyB B = new DummyB();
            //B.show();//B

            //DummyA A = new DummyB();
            //A.show();//A  ==>B

            //DummyA Obj = new DummyA();
            //Obj.show(); //A

            //Obj = new DummyB();
            //Obj.show();//A  ===>B

            Dog dog = new Dog();
            dog.SetName(Console.ReadLine());
            Console.WriteLine(dog.GetName());
            dog.Eat();
        }
    }
}
