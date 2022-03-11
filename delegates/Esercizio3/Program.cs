using System;

namespace Esercizio3
{
    class Program
    {
        public delegate void FunctionDel(double a, double b);
        static void Main(string[] args)
        {
            FunctionDel functions = new FunctionDel(Sum);
            functions += Difference;
            functions += Multiplication;
            functions += Division;
            double a = 2.5;
            double b = 3.6;
            functions(a, b);            
        }

        static public void Sum(double a, double b)
        {
            Console.WriteLine($"{a}+{b}={a+b}");
        }

        static public void Difference(double a, double b)
        {
            Console.WriteLine($"{a}-{b}={a - b}");
        }
        static public void Multiplication(double a, double b)
        {
            Console.WriteLine($"{a}x{b}={a * b}");
        }
        static public void Division(double a, double b)
        {
            Console.WriteLine($"{a}/{b}={a / b}");
        }
    }
}
