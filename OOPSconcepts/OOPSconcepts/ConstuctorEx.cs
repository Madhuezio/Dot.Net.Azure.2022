using System;
using System.Collections.Generic;
using System.Text;

namespace OOPSconcepts
{
    /// <summary>
    /// class named "Square"
    /// </summary>
    class Square
    {
        //store its starting X and Y coordinates (the upper left corner, already stored as a "Location") and the length of its side.
        private int x;
        private int y;
        private int length;
        /// <summary>
        /// A suitable constructor, to assign starting values to X, Y and the side. (2 points)
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="length"></param>
        public Square(int x, int y, int length)
        {
            this.x = x;
            this.y = y;
            this.length = length;
        }

        /// <summary>
        /// A Move method, to change X and Y coordinates. (1 point)
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public void Move(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        /// <summary>
        /// A Scale method, to change its side (for example, a scale factor of 2 would turn a side of 3 into 6). (1 point)
        /// </summary>
        /// <param name="scaleFactor"></param>
        public void Scale(int scaleFactor)
        {
            this.length *= scaleFactor;
        }
        /// <summary>
        /// A method ToString, to return a string with its data (for example: "Corner (10,5), side 7". (1 point)
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format("Corner ({0},{1}), side {2}", this.x, this.y, this.length);
        }
        /// <summary>
        /// "GetPerimeter" returns the perimeter
        /// </summary>
        /// <returns></returns>
        public double GetPerimeter()
        {
            return 4 * this.length;
        }
        /// <summary>
        /// "GetArea" returns the area
        /// </summary>
        /// <returns></returns>
        public double GetArea()
        {
            return this.length * this.length;
        }
        class ConstuctorEx
        {
            public static void Main13(string[] args)
            {
                //The remaining 2 points correspond to the test from "Main"
                Square square = new Square(5, 5, 10);
                Console.WriteLine(square.ToString());
                //Move
                Console.WriteLine("\nMove(15, 20)");
                square.Move(15, 20);
                Console.WriteLine(square.ToString());
                //Scale
                Console.WriteLine("\nScale(3)");
                square.Scale(3);
                Console.WriteLine(square.ToString());
                //Display the perimeter
                Console.WriteLine("\nThe perimeter = {0}", square.GetPerimeter());
                //Display the area
                Console.WriteLine("\nThe area = {0}", square.GetArea());


                Console.ReadLine();
            }
        }
    }
}
