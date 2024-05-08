using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace KursovaRabota
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Company bulstatCompany = new Company("",2,3);
            Console.Write("Enter how many companies you want: ");
            int numberOfCompanies = int.Parse(Console.ReadLine());
            Company[] companies = new Company[numberOfCompanies];

            Console.WriteLine("Choose a Company\n1.CompanyET\n2.CompanyLLC");
            Console.Write("Choose: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice) 
            {
                case 1: CompanyET comEt = new CompanyET("", 5,3);
                    
                    for (int i = 0; i < numberOfCompanies; i++)
                    {
                        bulstatCompany.Input();
                        comEt.Input();                      
                        companies[i] = comEt;
                        comEt.CalculateProfit();
                        comEt.Output();                     
                    }
                    
                    break;
                case 2: CompanyOOD comLLC = new CompanyOOD("", 2,3);
                    for (int i = 0; i < numberOfCompanies; i++)
                    {
                        comLLC.Input();
                        companies[i] = comLLC;
                        comLLC.Output();
                    }
                    break;
            }

            
        }
    }
}
