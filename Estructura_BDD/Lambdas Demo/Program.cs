using System;
using System.Collections.Generic;


namespace LambdasDemo
{
    internal class Program
    {

        static double Suma(int a, int b)
        {
            return a + b;
        }

        static double Resta(int a, int b)
        {
            return a - b;
        }


        static void Main(string[] args)
        {

            int m = 10;
            int n = 43;

            Console.WriteLine($"m + n: {Suma(m, n)}");
            Console.WriteLine($"m - n: {Resta(m, n)}");

        }
    }
}