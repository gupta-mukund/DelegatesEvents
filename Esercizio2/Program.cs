using System;

namespace Esercizio2
{
    class Program
    {
        public delegate int FunctionDel(int n);
        static void Main(string[] args)
        {
            FunctionDel functions = new FunctionDel(NumberSquare);
            functions += NumberCube;
            Console.Write("Inserisci un numero: ");
            if (Int32.TryParse(Console.ReadLine(), out int num))
            {
                foreach (var item in functions.GetInvocationList())
                {
                    var f = (FunctionDel)item;
                    num = f(num);
                }
            } 
            
            
        }

        static public int NumberSquare(int n)
        {
            double square = Math.Pow(n, 2);
            Console.WriteLine($"The square of {n} is {square}");
            return (int)square;
        }

        static public int NumberCube(int n)
        {
            double cube = Math.Pow(n, 3);
            Console.WriteLine($"The cube of {n} is {cube}");
            return (int)cube;
        }
    }
}
