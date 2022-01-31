using System;
using System.Collections.Generic;
using System.Text;

namespace OopsConcepts
{
    class Objectclass
    {
        static void Main3(string[] args)
        {
            //Equals
            //equals
            //finalize
            //gethashcode
            //gettype
            //tostring

            /*
            object sampleObj = new object();
            object sampleObj2 = new object();
            int i = 10;

            bool result = Equals(sampleObj, sampleObj2);
            Console.WriteLine(result);
            Type t1 = sampleObj.GetType();
            Type t2 = i.GetType();
            Console.WriteLine(t1.Name);
            Console.WriteLine(t1.Namespace);
            Console.WriteLine(t1.BaseType);
            Console.WriteLine(t2.Name);
            Console.WriteLine(t2.Namespace);
            Console.WriteLine(t2.BaseType);

            */

            //== and equals

            /*

            string name = "madhu";
            string Myname = name;

            var doubleeql = (name == Myname);//true
            var eql = name.Equals(Myname);//true
            Console.WriteLine(doubleeql);
            Console.WriteLine(eql);
            Console.WriteLine("====================================");
            object nameObj = "madhu";
            char[] values = { 'm', 'a', 'd', 'h', 'u' };
            object myName = new string(values);
            var doubleeql2 = (nameObj == myName);//false
            var eql2 = nameObj.Equals(myName);//true
            Console.WriteLine(doubleeql2);
            Console.WriteLine(eql2);


            */
        }
    }
}
