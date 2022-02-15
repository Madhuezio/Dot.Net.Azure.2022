using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace HandlingLibrabries
{
    class Xmlread
    {
        static void Main3(string[] args)
        {
            using (XmlReader reader = XmlReader.Create("D://.net//sample.xml"))
            {
                while (reader.Read())
                {
                    if (reader.IsStartElement())
                    {

                        Console.WriteLine(reader.ReadString());
                        Console.WriteLine(reader.Name.ToString());

                    }

                }
            }
        }
    }
}