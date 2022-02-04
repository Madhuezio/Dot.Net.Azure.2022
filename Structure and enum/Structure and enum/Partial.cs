using System;
using System.Collections.Generic;
using System.Text;

namespace Structure_and_enum
{
    class Partial
    {
        public static void Main8()
        {
            //SeleadClass.SampleDemo1.Class1 sample = new SeleadClass.SampleDemo1.Class1();
            //SeleadClass.SampleDemo2.Class1 sample2 = new SeleadClass.SampleDemo2.Class1();


            Customer customer = new Customer();
            customer.Amount = 2000;
            customer.depositmoney(customer.Amount);
            customer.withdraw(customer.Amount);
        }
    }
}
