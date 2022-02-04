using System;
using System.Collections.Generic;
using System.Text;

namespace Structure_and_enum
{
    class Customer2
    {
        partial class Customer
        {
            public void depositmoney(int amount)
            {
                Console.WriteLine("Amount to deposit" + amount);
            }
        }
    }
}
