using System;
using System.IO;
using Calculator;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace HandlingLibrabries
{
    class Program1
    {
        static void Main2(string[] args)
        {
            //Calculate cal = new Calculate();

            using (StreamReader r = new StreamReader("D://.net//sample.json"))
            {
                string json = r.ReadToEnd();
                Book items = JsonConvert.DeserializeObject<Book>(json);
                Console.WriteLine(items.BookAuthor);
                Console.WriteLine(items.BookName);
            }

            //Book book = new Book();
            //book.BookName = "Hello";
            //book.BookAuthor = "Hi";
            //string json1 = JsonConvert.SerializeObject(book);
            //System.IO.File.WriteAllText("D://.net//new.json", json1);
        }
    }
}