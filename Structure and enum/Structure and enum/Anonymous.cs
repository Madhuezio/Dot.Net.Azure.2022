using System;
using System.Collections.Generic;
using System.Text;

namespace Structure_and_enum
{
    class anonymous
    {
        static public void sampleMethod(dynamic val)
        {
            Console.WriteLine(val.s_id);
            Console.WriteLine(val.S_name);
            Console.WriteLine(val.langauge);
            Console.WriteLine(val.nested_ob.email);
        }
        public static void Main6()
        {

            var anony_Object = new
            {
                s_id = 123,
                S_name = "Vikash verma",
                langauge = "English",
                nested_ob = new { email = "Sample@yahoo.com" }
            };
            sampleMethod(anony_Object);
        }
    }
}
