using System;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("All Months:");
            string[,] months = { 
                { "1.January", "2.February", "3.March", "4.April", "5.May" ,"6.June" },
                { "7.July", "8.August","9.September", "10.Octomber", "11.November" , "12.December"}
            };
            foreach (string month in months) 
            {
                Console.WriteLine(month);
            }
            Console.WriteLine(" ");
            Console.Write("Enter year: ");
            int year = int.Parse(Console.ReadLine());

            //if(DateTime.IsLeapYear(year))
            if (year % 4 ==0)
            {
                Console.WriteLine("The year is leap!");
                Console.WriteLine(" ");
                string[,] daysLeapYear = {
               { "31 days in Jan", "29 days in Feb", "31 days in March", "30 in April", "31 days in May" ,"30 days in June" },
                { "31 days in July", "31 days in August","30 days in September", "31 days in Octomber", "30 days in November" , "31 days in December"}
            };
                foreach (string day in daysLeapYear)
                {
                    Console.WriteLine(day);
                }
            }
            else 
            {
                Console.WriteLine("The year is not leap!");
                Console.WriteLine(" ");

                string[,] daysNormal = {
               { "31 days in Jan", "28 days in Feb", "31 days in March", "30 in April", "31 days in May" ,"30 days in June" },
                { "31 days in July", "31 days in August","30 days in September", "31 days in Octomber", "30 days in November" , "31 days in December"}
            };
                foreach (string dayN in daysNormal)
                {
                    Console.WriteLine(dayN);
                }
            }
                
                    
               
                   
                   
            

            
        }
    }
}
