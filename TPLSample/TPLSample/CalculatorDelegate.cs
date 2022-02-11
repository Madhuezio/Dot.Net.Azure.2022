using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace TPLSample
{
    class CalculatorDelegate
    {
        delegate double ArithmaticDelegate(double x, double y);

        static void Menu()
        {
            Console.WriteLine("Select an arithmatic operation");
            Console.WriteLine("1)Addition");
            Console.WriteLine("2)Subtraction");
            Console.WriteLine("3)Multiplication");
            Console.WriteLine("4)Division");
            Console.WriteLine("5)Remainder");
            Console.WriteLine("6)Quit");
        }

        static double Add(double a, double b)
        {
            return a + b;
        }

        static double Subtract(double a, double b)
        {
            return a - b;
        }

        static double Multiply(double a, double b)
        {
            return a * b;
        }

        static double Divide(double a, double b)
        {
            return a / b;
        }

        static double Modulus(double a, double b)
        {
            return a % b;
        }
        static void Main5(string[] args)
        {
            int operation;
            ArithmaticDelegate arithmatic;
            double x, y;

            do
            {
                Console.WriteLine("Enter two numbers seperated by Enter");
                x = double.Parse(Console.ReadLine());
                y = double.Parse(Console.ReadLine());
                Console.Clear();

                Menu();
                operation = int.Parse(Console.ReadLine());

                switch (operation)
                {
                    //Addition
                    case 1:
                        arithmatic = Add;
                        break;
                    //Subtraction
                    case 2:
                        arithmatic = Subtract;
                        break;
                    //Multiplication
                    case 3:
                        arithmatic = Multiply;
                        break;
                    //Division
                    case 4:
                        arithmatic = Divide;
                        break;
                    //Remainder
                    case 5:
                        arithmatic = Modulus;
                        break;
                    default:
                        Console.WriteLine("Exiting program");
                        return;
                }
                Console.WriteLine(arithmatic(x,y));
                Console.WriteLine("Press any key to continue");
                Console.ReadKey(true);
                Console.Clear();
            } while (operation != 6);
        }
    }
}
