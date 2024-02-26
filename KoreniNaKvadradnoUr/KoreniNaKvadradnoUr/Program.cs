using System;

namespace KoreniNaKvadradnoUr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x1,x2;
            
            Console.Write("Enter value for A:");
            double aFirstNum = double.Parse(Console.ReadLine());
            Console.Write("Enter value for B:");
            double bSecondNum = double.Parse(Console.ReadLine());
            Console.Write("Enter value for C:");
            double cThirdNum = double.Parse(Console.ReadLine());

            double discriminanta = Math.Pow(bSecondNum, 2) - 4 * aFirstNum * cThirdNum;
            Console.WriteLine($"Discriminanta: {discriminanta}");


            if (discriminanta > 0)
            {
                x1 = (-bSecondNum + discriminanta) / 2 * aFirstNum;
                Console.WriteLine($"X1 = {x1}");
                x2 = (-bSecondNum - discriminanta) / 2 * aFirstNum;
                Console.WriteLine($"X1 = {x2}");
            }
            else if (discriminanta == 0)
            {
                x1 = -bSecondNum / 2 * aFirstNum;
                Console.WriteLine($"X= {x1}");
            }
            else
            {
                Console.WriteLine("Nqma realni koreni");
            }

            

        }
    }
}
