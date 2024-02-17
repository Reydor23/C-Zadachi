using System;
using System.Collections.Concurrent;
using System.Security.Cryptography;

namespace Zadacha2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double redRoses = 7.89;
            double tulips = 5.89;
            double orchid = 45.32;
            int arrangingaBouquet = 5;
            Console.WriteLine("Price of the flowers: ");
            Console.WriteLine($"1.Red Roses: {redRoses}lv\n2.Tulips: {tulips}lv\n3.Orchid: {orchid}lv");
            Console.WriteLine($"Arranging a Bouquet: {arrangingaBouquet}lv");
            
            Console.Write("How much Red Roses: ");
            int rosesCounter = int.Parse(Console.ReadLine());
            Console.Write("How much Tulips: ");
            int tulipsCounter = int.Parse(Console.ReadLine());
            Console.Write("How much Orchid: ");
            int orchidCounter = int.Parse(Console.ReadLine());

            Console.WriteLine("Choose season:\n1.Spring\n2.Summer");
            Console.Write("Choose Season: ");
            int season = int.Parse(Console.ReadLine());

            int totalFlowers = rosesCounter + tulipsCounter + orchidCounter;

            double total = 0;
            double valentineSale = 0.15;

            switch (season) 
            {
                case 1:
                    total = (rosesCounter * redRoses) + (tulipsCounter * tulips) + (orchidCounter * orchid) + arrangingaBouquet * valentineSale;
                    if (tulipsCounter >= 3)
                    {
                        total *= 0.95;
                    }            
                    Console.WriteLine($"Total amount during spring season: {total}");
                    break;
                    case 2:
                    total = (rosesCounter * redRoses) + (tulipsCounter * tulips) + (orchidCounter * orchid) + arrangingaBouquet * valentineSale;
                    if (rosesCounter >=12)
                    {
                        total *= 0.90;
                    }
                    Console.WriteLine($"Total amount during summer season: {total}");
                    break;

            }
            if (totalFlowers > 22)
            {
                total *= 0.77;
                string formattedNumber = total.ToString("0.00");
                Console.WriteLine($"Total amount: {formattedNumber}");
            }

        }
    }
}
