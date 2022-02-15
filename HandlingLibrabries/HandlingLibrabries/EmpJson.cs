using System;
using System.IO;
using Calculator;
using Newtonsoft.Json;
using System.Text.Json.Serialization;


namespace HandlingLibrabries
{
    class EmpJson
    {
        static void Main4(string[] args)
        {
            //Calculate cal = new Calculate();

            using (StreamReader r = new StreamReader("D://.net//emp.json"))
            {
                string json = r.ReadToEnd();
                Employe items = JsonConvert.DeserializeObject<Employe>(json);
                Console.WriteLine(items.EmpId);
                Console.WriteLine(items.EmpName);
                Console.WriteLine(items.EmpAddress);
                Console.WriteLine(items.EmpSalary);

            }
        }
    }
}
