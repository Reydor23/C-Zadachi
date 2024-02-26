using System;

namespace Factoriel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            int a = int.Parse(Console.ReadLine());
            int fact = 1;
            for (int x = 1; x <= a; x++)
            {
                fact *= x;
            }
            Console.WriteLine($"Factoriel: {fact}");
            
        }
    }
}

