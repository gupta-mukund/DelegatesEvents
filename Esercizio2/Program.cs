using System;

namespace Esercizio2
{
    class Program
    {
        public delegate void FunctionDel(int n);
        static void Main(string[] args)
        {
            FunctionDel functions = new FunctionDel(NumberSquare);
            functions += NumberCube;
            functions.Invoke(2);
        }

        static public void NumberSquare(int n)
        {
            Console.WriteLine($"The square of {n} is {Math.Pow(n, 2)}");
        }

        static public void NumberCube(int n)
        {
            Console.WriteLine($"The cube of {n} is {Math.Pow(n, 3)}");
        }
    }
}
