using System;
using System.Runtime.Serialization;

namespace Error404
{
    internal class Program
    {
        static void Main(string[] args)
        {
                Months selectMonths = new Months();

                Console.Write("Enter month: ");
                string month = Console.ReadLine();

                int monthNumber = selectMonths.MonthCon(month);

                Console.WriteLine($"The number of the month {month} is: {monthNumber}");
        }
    }
}
