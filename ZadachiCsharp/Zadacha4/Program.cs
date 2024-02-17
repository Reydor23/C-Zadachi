using System;
using System.Reflection;
using System.Transactions;

namespace Zadacha4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose Solution for calculation:");
            Console.WriteLine("1.y=1/1/x-1\n2.y=sqrt(x^2-5)*(x+3)\n3.y=(a+b)^2 - 4*a^3/sqrt(3|a|)+1\n4.y=1-(x^2-1)^5/sqrt(x^2+2x+1)" +
                "\n5.y=(5 -x^3) /3 -(x- 1) / (x + 3)\n6.y=|sqrt(2+x^5 / x^4 + 5x)\n");

            double unknownY = 0;
            
            Console.Write("Enter value for X = ");
            int setX = int.Parse(Console.ReadLine());

            Console.Write("Enter value for A = ");
            int setA = int.Parse(Console.ReadLine());

            Console.Write("Enter value for B = ");
            int setB = int.Parse(Console.ReadLine());

            //First solution
            Console.WriteLine("\n1.y=1/1/x-1");
            unknownY = 1 / 1 / setX - 1;          
            Console.WriteLine($"First result: {unknownY}");

            //Second solution
            Console.WriteLine("\n2.y=sqrt(x^2-5)*(x+3)");
            unknownY = Math.Sqrt(Math.Pow(setX, 2) - 5) * (setX + 3);        
            Console.WriteLine($"Second result: {unknownY}");

            //Third solution
            Console.WriteLine("\n3.y=(a+b)^2 - 4*a^3/sqrt(3|a|)+1");
            unknownY = Math.Pow(setA + setB , 2) - 4 * Math.Pow(setA,3) / Math.Sqrt(3 * setA + 1);
            Console.WriteLine($"Third result: {unknownY}");

            //Fourth solution
            Console.WriteLine("\n4.y=1-(x^2-1)^5/sqrt(x^2+2x+1)");
            unknownY = 1 - Math.Pow(Math.Pow(setX, 2 - 1), 5) / Math.Pow(setX, 2 + 2 * setX + 1);
            Console.WriteLine($"Fourth result: {unknownY}");

            //Fith solution
            Console.WriteLine("\n5.y=(5 -x^3) /3 -(x- 1) / (x + 3)");
            unknownY = (5 - Math.Pow(setX, 3)) / 3 - (setX - 1) / (setX + 3);
            Console.WriteLine($"Fith result: {unknownY}");

            //Sixth solution
            Console.WriteLine("\n6.y=sqrt(2+x^5 / x^4 + 5x)");
            unknownY = Math.Sqrt(2 + Math.Pow(setX,5)) / Math.Pow(setX,4) + 5 * setX;
            Console.WriteLine($"Sixth result: {unknownY}");
        }
    }
}
