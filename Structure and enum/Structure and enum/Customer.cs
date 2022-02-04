using System;
using System.Collections.Generic;
using System.Text;

namespace Structure_and_enum
{
    partial class Customer
    {
        private int amount;
        public int Amount { get; set; }
        public void withdraw(int amount)
        {
            Console.WriteLine("Amount to be withdraw" + amount);
        }

        internal void depositmoney(int amount)
        {
            throw new NotImplementedException();
        }
    }
}
