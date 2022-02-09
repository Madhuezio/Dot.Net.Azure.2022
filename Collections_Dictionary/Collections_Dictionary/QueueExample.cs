using System;
using System.Collections.Generic;
using System.Text;

namespace Collections_Dictionary
{
    public class Queue
    {
        private int[] queue;
        private int position;

        public Queue(int size)
        {
            position = -1;
            queue = new int[size];
        }

        public void Enqueue(int value)
        {
            position++;
            queue[position] = value;
        }

        public int Unequeue()
        {
            int aux = queue[0];

            for (int i = 0; i < position; i++)
            {
                queue[i] = queue[i + 1];
            }

            queue[position] = aux;
            position--;

            return queue[position + 1];
        }
    }
    class QueueExample
    {
        public static void Main8(string[] args)
        {
            int size = 2;
            Queue queue = new Queue(size);

            int val1 = 7,
                val2 = 1;

            queue.Enqueue(val1);
            queue.Enqueue(val2);

            val1 = queue.Unequeue();
            val2 = queue.Unequeue();

            Console.WriteLine(val1);
            Console.WriteLine(val2);
        }
    }
}
