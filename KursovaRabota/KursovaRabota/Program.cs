using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace KursovaRabota
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Company bulstatCompany = new Company("",0,0);
            Console.Write("Enter how many companies you want: ");
            int companyChoice = int.Parse(Console.ReadLine());
            Company[] companies = new Company[companyChoice];
            
            Console.WriteLine("Choose a Company\n1.CompanyET\n2.CompanyLLC");
            Console.Write("Choose: ");
            int choice = int.Parse(Console.ReadLine());
            do
            {
                Console.Write("Try again!\nChoose: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice) 
            {
                case 1:                  
                    for (int i = 0; i < companyChoice; i++)
                    {
                        CompanyET comEt = new CompanyET("", 0, 0);
                        bulstatCompany.Input();
                        comEt.Input();                      
                        comEt.CalculateProfit();
                        companies[i] = comEt;                    
                    }
                    Console.WriteLine("All Firms info:");
                    foreach (CompanyET comsEt in companies)
                    {
                       comsEt.Output();
                    }
                    break;

                case 2: 
                    for (int i = 0; i < 2; i++)
                    {
                        CompanyOOD comLLC = new CompanyOOD("", 0, 0);
                        bulstatCompany.Input();
                        comLLC.Input();
                        comLLC.CalculateProfit();                       
                        companies[i] = comLLC;                        
                    }
                    Console.WriteLine("All Firms info:");
                    foreach (CompanyOOD comsEt in companies)
                    {
                        comsEt.Output();
                    }
                    break;
                       
                    default:                        
                     Console.WriteLine("Invalid choice!");
                    break;
            }
            } while (choice != 1 && choice != 2);



        }
    }
}
