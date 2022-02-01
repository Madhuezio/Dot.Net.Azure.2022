using System;
using System.Collections.Generic;
using System.Text;

namespace Loops
{
    class Array
    {
        static void Main(string[] args)
        {
            /*
             
            //Find all duplicate elements in array
            int[] arr = new int[10];
            int i, j, num, count = 0;

            //Reads size of the array
            Console.WriteLine("Enter size of the array: ");
            num = Convert.ToInt32(Console.ReadLine());

            //Reads elements in array
            Console.WriteLine("Enter elements in the array: ");
            for (i = 0; i < num; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (i = 0; i < num; i++)
            {
                for (j = i + 1; j < num; j++)
                {
                    // If duplicate element found then increment count by 1
                    if (arr[i] == arr[j])
                    {
                        count++;
                        break;
                    }
                }
            }

            Console.WriteLine("\n Total number of duplicate elements found in array:" + count);
            Console.ReadLine();
            
            */

            //Write a program in C# Sharp to find the second largest element in an array

             /*
             
            int i, j, seclarg;
            int[] arr = new int[5];

            Console.Write("Enter five numbers:");
            for (i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (i = 0; i < 5; i++)
            {
                for (j = i + 1; j < 5; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        seclarg = arr[i];
                        arr[i] = arr[j];
                        arr[j] = seclarg;
                    }
                }
            }
            Console.WriteLine("Second largest element is:" + arr[5 - 2]);  

            */


            //Write a program in C# Sharp to find transpose of a given matrix.

            
             
            int i, j, r, c;
            int[,] arr1 = new int[50, 50];
            int[,] brr1 = new int[50, 50];


            Console.Write("\n\nTranspose of a Matrix :\n");
            Console.Write("---------------------------\n");

            Console.Write("\nInput the number of rows and columns of the first matrix :\n");
            Console.Write("Rows : ");
            r = Convert.ToInt32(Console.ReadLine());
            Console.Write("Columns : ");
            c = Convert.ToInt32(Console.ReadLine());


            Console.Write("Input elements in the matrix :\n");
            for (i = 0; i < r; i++)
            {
                for (j = 0; j < c; j++)
                {
                    Console.Write("element - [{0}],[{1}] : ", i, j);
                    arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.Write("\nThe First matrix is :\n");
            for (i = 0; i < r; i++)
            {
                Console.Write("\n");
                for (j = 0; j < c; j++)
                    Console.Write("{0}\t", arr1[i, j]);
            }

            for (i = 0; i < r; i++)
            {
                for (j = 0; j < c; j++)
                {

                    brr1[j, i] = arr1[i, j];
                }
            }

            Console.Write("\n\nThe Transpose of a matrix is : ");
            for (i = 0; i < c; i++)
            {
                Console.Write("\n");
                for (j = 0; j < r; j++)
                {
                    Console.Write("{0}\t", brr1[i, j]);
                }
            }
            Console.Write("\n\n");

            
        }
    }
}
