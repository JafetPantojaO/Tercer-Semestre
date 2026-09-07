using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackDev
{
    internal class StaticStack<T> : IStack<T>
    {
        //datos
        private T[] data;
        private int index;

        public int Size => index + 1;

        public bool Empty => index == -1;

        public bool Full => index == data.Length - 1;

        //constructor
        public StaticStack(int capacity)
        {
            data = new T[capacity]; //Crea un arreglo de el tamaño dado
            index = -1; //Inicializa el indice en -1, indicando que la pila está vacía
        }



        //metodos
        public T Peek()
        {
            if(Empty)
            {
                throw new IndexOutOfRangeException("Stack is empty");
            }
            return data[index];
        }
        public T Pop()
        {
            if (Empty)
            {
                throw new IndexOutOfRangeException("Stack is empty");
            }
            return data[index--];
        }

        public void Push(T e)
        {
            if (Full)
            {
                throw new IndexOutOfRangeException("Stack is full");
            }

            data[++index] = e; //Incrementa el índice y agrega el elemento en la posición correspondiente]
        }

        #if DEBUG // -> "#algo" sirve para que el compilador haga algo si se cumple la condicion
        public string DataPeek()
        {
            string aux = "[";

            for (int i = 0; i <= Size; i++)
            {
                aux += $" {data[i]}";
            }

            aux += " ]";

            return aux;
        }
        #endif
    }
}