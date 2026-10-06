using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace EnumerableDemo
{
    class Demo<T> : IEnumerable<T>
    {
        // Enumerador de la clase Demo
        // Objeto que se encarga de enumerar la secuencia de elementos
        public class DemoEnumerator<T> : IEnumerator<T>
        {
            private Demo<T> demoRef;
            private int index;

            public DemoEnumerator(Demo<T> demo)
            {
                demoRef = demo; // Crea un respaldo interno
                index = -1; // Si yo pienso enumerar algo es por que tengo una posición asignada a los elementos
            }

            public T Current
            {
                get
                {
                    switch (index)
                    {
                        case 0:
                            return demoRef.x;
                        case 1:
                            return demoRef.y;
                        case 2:
                            return demoRef.z;
                    }

                    throw new InvalidOperationException();
                }
            }

            public bool MoveNext()
            {
                throw new NotImplementedException();
            }

            public void Reset()
            {
                index = -1;
            }




            object IEnumerator.Current => Current;
            
            public void Dispose()
            {
                throw new NotImplementedException();
            }

        }

       private T y = 25;  // 1
       private T z = -64; // 2
       private T x = 10;  // 0


        public IEnumerator<T> GetEnumerator()
        {
            //return new DemoEnumerator<T>(this);
            yield return x;
            yield return y;
            yield return z;
            
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Demo<int> demo = new Demo<int>();

            /*
            foreach (int e in demo)
            {
                WriteLine($"{e} ");
            }
            */

            // Cuando yo escribo un foreach esto es lo que realmente el lenguaje compila
            // Para cada elemento e en demo , haz lo siguiente
            // Lo primero que hace es pedirle su enumerador y lo guarda, le hace una referencia a su enumerador
            // Luego en el ciclo le dice "Enumerador, muévete al siguiente", cuando le digo move next por primera vez
            // se coloca en el primer elemento

            IEnumerator<int> enumerator = demo.GetEnumerator();

            while (enumerator.MoveNext())
            {
                int e = enumerator.Current;
                Write($"{e} ");
            }
        }
    }
}