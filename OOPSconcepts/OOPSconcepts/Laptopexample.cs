using System;
using System.Collections.Generic;
using System.Text;

namespace OOPSconcepts
{
    class Laptop : LaptopBase
    {
        public void ShowDetails(string name, string price, string processor, string ram, string hdd)
        {
            Console.WriteLine("Name : " + name);
            Console.WriteLine("Price : " + price);
            Console.WriteLine("Processor : " + processor);
            Console.WriteLine("Ram : " + ram);
            Console.WriteLine("HDD : " + hdd);
        }
    }

    class LaptopBase
    {
        public const string i3 = "i3";
        public const string i5 = "i5";
        public const string i7 = "i7";
        public const string i9 = "i9";

        public const string Ram4GB = "4GB";
        public const string Ram6GB = "6GB";
        public const string Ram8GB = "8GB";
        public const string Ram16GB = "16GB";
        public const string Ram32GB = "32GB";

        public const string HD256GB = "256GB";
        public const string HD500GB = "500GB";
        public const string HD1TB = "1TB";

        public const string Price750 = "$750";
        public const string Price1450 = "$1450";
        public const string Price1950 = "$1950";
        public const string Price2500 = "$2500";

        public const string Lenove = "Lenovo";
        public const string Sony = "Sony";
        public const string Dell = "Dell";
        public const string Asus = "Asus";
    }
    class Laptopexample
    {
        public static void Main12(string[] args)
        {
            Laptop lp = new Laptop();

            lp.ShowDetails(Laptop.Lenove, Laptop.Price750, Laptop.i3, Laptop.Ram4GB, Laptop.HD256GB);
            Console.WriteLine("\n\n*************************************\n");

            lp.ShowDetails(Laptop.Dell, Laptop.Price1450, Laptop.i5, Laptop.Ram6GB, Laptop.HD500GB);
            Console.WriteLine("\n\n*************************************\n");

            lp.ShowDetails(Laptop.Sony, Laptop.Price1950, Laptop.i7, Laptop.Ram8GB, Laptop.HD1TB);
            Console.WriteLine("\n\n*************************************\n");

            lp.ShowDetails(Laptop.Asus, Laptop.Price2500, Laptop.i9, Laptop.Ram16GB, Laptop.HD1TB);
            Console.WriteLine("\n\n*************************************\n");

            Console.ReadKey();

        }
    }
}
