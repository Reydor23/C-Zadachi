using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursovaRabota
{
    internal class Company
    {
        private string nameCompany, companyBulstat;
        private DateTime dateOfCompanyCreation;

        protected string nameOfOwner;
        protected float firstCapital, actualCapital;

       
        public string NameCompany 
        { 
            get { return nameCompany; } 
            set { nameCompany = value; } 
        }
        public DateTime DateOfCompanyCreation
        {
            get { return DateOfCompanyCreation; }
            set { DateOfCompanyCreation = value; }
        }     

        public string CompanyBulstat
        { 
            get { return companyBulstat; } 
            set {

                if (value.Length <= 10) 
                { 
                    companyBulstat = value;
                    Console.WriteLine("Succesfull Bulstat!");
                }
                else
                {
                    throw new ArgumentException("Bulstat must be 10 characters!");
                   
                }
            
            }                 
        }
        public void Input()
        {
            Console.WriteLine("Enter bulstat: ");
            string buls = Console.ReadLine();

            try
            {
                CompanyBulstat = buls;
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine();
                throw;
            }          

        }


    }
}
