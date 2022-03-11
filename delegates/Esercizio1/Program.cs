using System;

namespace Esercizio1
{
    class Program
    {
        static void Main(string[] args)
        {
            RunCallback(new int[] { 2, 4, 5, 6, 0, 0, -2, -8 }, CheckNumbers);
        }
        static void RunCallback(int[] numbers, Action<int[]> functionDel)
        {
            functionDel(numbers);
        }
        static void CheckNumbers(int[] numbers)
        {
            foreach (int n in numbers)
            {
                if (n < 0) Console.WriteLine($"{n} < di zero");
                else if (n > 0) Console.WriteLine($"{n} > di zero");
                else Console.WriteLine($"{n} uguale a zero");
            }
        }
    }
}
