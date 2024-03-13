using System;

namespace Meterologiya
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] namesOftheStations = { "Novo Selo", "Vidin", "Lom", "Oryahovo", "Montana", "Vraca", "Kneja", "Lovech", "Pleven" };
            int[] temperatures = { 8, 8, 8, 8, 15, 14, 8, 10, 13 };
            Console.WriteLine("All Stations: ");
            for (int i = 0; i < namesOftheStations.Length; i++)
            {
                Console.WriteLine($"{namesOftheStations[i]} : {temperatures[i]}T°C");

            }

            for (int i = 0; i < temperatures.Length; i++)
            {
                if (i >= 8 || i >= 15)
                {
                    Console.WriteLine($"Nai-malka stoinost: {i}");
                    
                }       
            }
            
            
        }
    }
}
