using System; //Se usa para ocupar de otros codigos
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

using static System.Console;   //Para no escribir todo eso, solo para las clases estaticas

namespace StackDev    //Es el apellido de la variable
{
    internal class Program
    {
        static void PrintStackStatus<T>(StaticStack<T> stack)
        {
            //#if DEBUG // -> "#algo" sirve para que el compilador haga algo si se cumple la condicion
           // WriteLine(stack.DataPeek()); // se ignora si no se cumple la condicion
           // #endif

            WriteLine($"Stack size: {stack.Size}");
            WriteLine($"Stack empty: {stack.Empty}");
            WriteLine($"Stack full: {stack.Full}\n");
            WriteLine();
        }
        static void Main(string[] args)
        {
            StaticStack<double> stack = new StaticStack<double>(5); // double = decimales
            PrintStackStatus(stack);

            stack.Push(-5);
            PrintStackStatus(stack);

            stack.Push(10);
            stack.Push(22);
            PrintStackStatus(stack);

            WriteLine($"Peek() => {stack.Peek()}");

            WriteLine($"Pop() => {stack.Pop()}\n");

            stack.Push(0);
            stack.Push(-1);
            stack.Push(55);
            PrintStackStatus(stack);
            WriteLine($"Stack full: {stack.Full}\n");

        }
    }
}