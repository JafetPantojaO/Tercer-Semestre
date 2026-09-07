using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueDev
{
    internal class ArrayQueue<T> : IQueue<T>
    {
        private int INITIAL_CAPACITY = 10;
        private T[] data;
        private int index;
        public int Size => index + 1;
        public bool Empty => index == -1;
        public bool Full => index == data.Length - 1;
        public int Capacity { get ; private set; }


        public ArrayQueue()
        {
            Capacity = INITIAL_CAPACITY;
            data = new T[Capacity];
            index = -1;
        }

        public ArrayQueue(int capacity)
        {
            Capacity = capacity < INITIAL_CAPACITY ? INITIAL_CAPACITY : capacity;
            data = new T[Capacity];
            index = -1;
        }

        public ArrayQueue(ArrayQueue<T> other)
        {

        }




    }
}