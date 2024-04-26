using System;
using System.Collections;
using System.Collections.Generic;

namespace KursovaRabota
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Company company = new Company();
            company.Input();

            Console.Write("Enter owners name (enter done to stop): ");
            string input;

            List<string> list = new List<string>();

            do
            {
                input = Console.ReadLine();
                if (input.ToLower() != "done")
                {
                    list.Add(input);
                    Console.Write("New name: ");
                }
            }

            while (input.ToLower() != "done");
            Console.WriteLine("Names of the owners: ");

            foreach (string item in list)
            {
                Console.WriteLine(item);
            }

        }
    }
}
