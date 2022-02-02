using System;
using System.Collections.Generic;
using System.Text;

namespace OOPSconcepts
{
    class Calculator
    {

        public int number = 0;

        // no-argument constructor
        public Calculator() { }


        // parameterized constructor
        public Calculator(int n)
        {
            number = n;
        }

        // Overloading of Binary "*" operator
        public static Calculator operator *(Calculator Calc1,
                                             Calculator Calc2)
        {
            Calculator Calc3 = new Calculator(0);
            Calc3.number = Calc2.number * Calc1.number;
            return Calc3;
        }

        // function to display result
        public void display()
        {
            Console.WriteLine("{0}", number);
        }
    }


    class CalNum
    {

        // Driver Code
        static void Main6(string[] args)
        {

            Calculator num1 = new Calculator(200);
            Calculator num2 = new Calculator(40);
            Calculator num3 = new Calculator();


            num3 = num1 * num2;

            num1.display(); // Displays 200

            num2.display(); // Displays 40

            num3.display(); // Displays 240

        }
    }
}
