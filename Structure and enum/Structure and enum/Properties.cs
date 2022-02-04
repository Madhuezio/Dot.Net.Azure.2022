using System;
using System.Collections.Generic;
using System.Text;

namespace Structure_and_enum
{
    class Student1
    {
        private int rn = 5;
        private string name;

        public int RollNumber
        {
            get
            {
                return rn;
            }
            set
            {
                rn = value;
            }
        }
        public int Name { get; set; }
    }
    class Properties
    {
        public static void Main3(string[] args)
        {
            Student1 objStudent = new Student1();
            Console.WriteLine(objStudent.RollNumber);
        }

    }
}
