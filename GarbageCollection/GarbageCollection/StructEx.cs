using System;
using System.Collections.Generic;
using System.Text;

namespace GarbageCollection
{
    struct Car
    {
        public string Model;
        public int YearOfProduction;
    }
    class StructEx
    {
        static void Main5(string[] args)
        {
            int total = 3;
            Car[] cars = new Car[total];

            for (int i = 0; i < total; i++)
            {
                cars[i] = new Car()
                {
                    Model = Console.ReadLine(),
                    YearOfProduction = int.Parse(Console.ReadLine())
                };
            }

            // Sort
            for (int i = 0; i < total - 1; i++)
            {
                for (int j = i + 1; j < total; j++)
                {
                    if (cars[i].YearOfProduction > cars[j].YearOfProduction)
                    {
                        var car = cars[i];

                        cars[i] = cars[j];
                        cars[j] = car;
                    }
                }
            }

            // Show
            for (int i = 0; i < total; i++)
            {
                var car = cars[i];
                Console.WriteLine("Model: " + car.Model + ", " +
                    "Year of production: " + car.YearOfProduction);
            }
        }
    }
}
