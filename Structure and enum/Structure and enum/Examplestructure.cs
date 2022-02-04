using System;
using System.Collections.Generic;
using System.Text;

namespace Structure_and_enum
{
    public struct sampleStru
    {
        private double val;
        public double Value
        {
            get { return val; }
            set { val = value; }
        }
        public double Read()
        {
            return double.Parse(Console.ReadLine());
        }
    }
    public struct Square
    {
        sampleStru ln;
        sampleStru ht;

        public sampleStru Length
        {
            get { return ln; }
            set { ln = value; }
        }
        public sampleStru Breadth
        {
            get { return ht; }
            set { ht = value; }
        }
        public void newSquare()
        {
            sampleStru rct = new sampleStru();

            Console.WriteLine("\nInput the dimensions of the Square( equal length and breadth ) : ");
            ln = sqrLength();
            Console.Write("breadth : ");
            ht.Value = rct.Read();
        }
        public sampleStru sqrLength()
        {
            sampleStru rct = new sampleStru();

            Console.Write("length : ");
            rct.Value = rct.Read();
            return rct;
        }
    }
    class Examplestructure
    {
        static void Main7(string[] args)
        {
            Console.Write("\n\nMethod that returns a structure  :\n");
            Console.Write("--------------------------------------\n");
            var Sqre = new Square();
            Sqre.newSquare();
            Console.WriteLine();
            Console.WriteLine("Perimeter and Area of the square :");
            Console.WriteLine("Length:    {0}", Sqre.Length.Value);
            Console.WriteLine("Breadth:    {0}", Sqre.Breadth.Value);
            Console.WriteLine("Perimeter: {0}", (Sqre.Length.Value + Sqre.Breadth.Value) * 2);
            Console.WriteLine("Area:      {0}\n", Sqre.Length.Value * Sqre.Breadth.Value);
        }
    }
}
