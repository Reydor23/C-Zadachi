using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursovaRabota
{
    internal class CompanyET : Company , IProfit
    {
        private float calculatingProfit;
        public CompanyET(string ownerName, float firstCap, float actualCap)
             : base(ownerName, firstCap, actualCap)
        {
            OwnerName = ownerName;
            FirstCapital = firstCap;
            ActualCapital = actualCap;
        }
        public void Input()
        {
            Console.Write("Enter owner last name: ");
            ownerName = Console.ReadLine();
            Console.Write("Enter initial Capital: ");
            firstCapital = int.Parse(Console.ReadLine());
            Console.Write("Enter Actual Capital: ");
            actualCapital = int.Parse(Console.ReadLine());
            
            Console.WriteLine();
        }
      

        public double CalculateProfit()
        {
            return calculatingProfit = ActualCapital - FirstCapital;
        }

        public void Output()
        {
            
            Console.WriteLine($"Ower Name: {ownerName}\nInitial Capital: {firstCapital}\nActual Capital: {actualCapital}");
            Console.WriteLine($"Profit: {calculatingProfit}");
            Console.WriteLine();
        }
    }
}
