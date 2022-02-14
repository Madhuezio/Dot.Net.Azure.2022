using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace FileHandling
{
    class Fileex
    {
        public void WriteData()
        {
            //write a data in file of class
            //FileStream fs = new FileStream("D://.net//sample.txt", FileMode.Append, FileAccess.Write);
            StreamWriter w = new StreamWriter("D://.net//sample.txt");
            Console.WriteLine("Enter the string");
            string str = Console.ReadLine();
            w.Write(str);
            w.Flush();
            w.Close();

        }
        static void Main2(string[] args)
        {
            Fileex fx = new Fileex();
            fx.WriteData();
            Console.Read();

        }
    }
}
