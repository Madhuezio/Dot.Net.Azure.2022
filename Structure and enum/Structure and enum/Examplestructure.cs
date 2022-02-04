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
        static void Main(string[] args)
        {

        }
    }
}
