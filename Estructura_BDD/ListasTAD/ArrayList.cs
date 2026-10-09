using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListsDev
{
    internal class ArrayList<T> : IList<T>
    {

        public const int INITIAL_CAPACITY =10;
        private T[] data;
        public int Capacity { get; private set; }

        public ArrayList(int capacity)
        {
            Capacity = capacity < INITIAL_CAPACITY ? INITIAL_CAPACITY : capacity;
            data = new T[Capacity];
            index = -1;
        }

        public ArrayLists() : this(INITIAL_CAPACITY) { }

        public T Get(int index) => data[index];

        public void Set(int index, T element) => data[index] = element;


        public void Add(T element)
        {
            if(Size == Capacity)
            {
                Capacity *= 2;
                Array.Resize(ref data, Capacity);
            }


            data[++index] = element;
        }


         public T this[int index] 
         { get => data[index]; 
           set => data[index] = value; 
        }


        public IEnumerator<T> GetEnumerator()
        {
            for (int i  = 0; i < Size; i++){
                yield return data [i];
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void AddAll(T first, params T[] elements)
        {
            Add(first);

            foreach (T e in elements){
                Add(e);
            }
        }

        public void Insert(int index, T element)
        {
           if(index < 0 || index >= Size)
           {
            throw new IndexOutOfRangeException("Index");
           }

           if(Size == Capacity)
            {
                Capacity *= 2;
                Array.Resize(ref data, Capacity);
            }

            int indexToCopy = this.index +1;
            while(indexToCopy > index)
            {
                data[indexToCopy] = data[indexToCopy - 1];
                indexToCopy--;
            }

            data[index] = element;

        
        }

        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            index = -1;
        }








        public int Size => throw new NotImplementedException();

        public bool Empty => throw new NotImplementedException();



        public bool All(Predicate<T> condition)
        {
            throw new NotImplementedException();
        }

        public bool Any(Predicate<T> condition)
        {
            throw new NotImplementedException();
        }


        public bool Contains(T element)
        {
            throw new NotImplementedException();
        }

        public bool Count(Predicate<T> condition)
        {
            throw new NotImplementedException();
        }

        public T Find(Predicate<T> match)
        {
            throw new NotImplementedException();
        }

        public IList<T> FindAll(Predicate<T> match)
        {
            throw new NotImplementedException();
        }

        public void ForEach(Action<T> action)
        {
            throw new NotImplementedException();
        }




    }
}