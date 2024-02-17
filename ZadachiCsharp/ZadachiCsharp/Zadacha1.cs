using System;
using System.Runtime.Serialization;

namespace ZadachiCsharp
{
    internal class Program
   {
      static void Main(string[] args)
       {
           double vipTickets = 497.54;
           double normalTickets = 245.80;
           Console.WriteLine($"The price of VIP tickets: {vipTickets}");
           Console.WriteLine($"The price of Normal tickets: {normalTickets}");

           Console.Write("Write your budged: ");
           double budged = double.Parse(Console.ReadLine());

           Console.Write("How many people are you going to: ");
           int people = int.Parse(Console.ReadLine());
           double budgedWithDiscount = 0;

           if (people >= 1 && people <= 4)
           {
               budgedWithDiscount = budged * 0.75;
           }
           else if (people >= 5 && people <= 9)
           {
               budgedWithDiscount = budged * 0.60;

           }
           else if (people >= 10 && people <= 24)
           {
               budgedWithDiscount = budged * 0.50;
           }
           else if (people >= 25 && people <= 49)
           {
               budgedWithDiscount = budged * 0.40;
           }
           else if (people >= 50)
           {
               budgedWithDiscount = budged * 0.25;
           }
           else
           {
               Console.WriteLine("There's no people!");
           }
           Console.WriteLine($"Your left budged: {budgedWithDiscount}");

           if (budgedWithDiscount > vipTickets)
           {
               Console.WriteLine("You can buy VIP tickets.");
           }
           if (budgedWithDiscount > normalTickets)
           {
               Console.WriteLine("You can buy Normal tickets.");
           }
       }
   }
}
