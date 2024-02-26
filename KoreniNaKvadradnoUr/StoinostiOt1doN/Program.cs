using System;

namespace StoinostiOt1doN
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Array Length: ");
            int userNums = int.Parse(Console.ReadLine());
            int[] mNums = new int[userNums];

            Console.WriteLine("Want to enter numbers? Y/N");
            char choice = char.Parse(Console.ReadLine());
            while (choice != 'n')
            {
                for (int i = 0; i < userNums; i++)
                {
                    Console.Write("New numbers: ");
                    mNums[i] = int.Parse(Console.ReadLine());
                    Console.WriteLine("Want to enter more? Y/N");
                    choice = char.Parse(Console.ReadLine());

                }
                if (choice == 'n')
                {
                    Console.Write("Array in reverse order: ");
                    for (int i = userNums- 1; i < userNums; i--)
                    {
                        Console.Write(mNums[i] + " ");
                        
                    }                  
                }
               

               

            }
        


            /*Console.WriteLine("Wanna enter more? ");
            char choice = char.Parse(Console.ReadLine());
            while (choice == 'y')
            {
                Console.Write("Enter new number: ");
                userNums = int.Parse(Console.ReadLine());
                Console.WriteLine("Wanna enter more? ");
                choice = char.Parse(Console.ReadLine());

                if (choice == 'n') 
                {
                    for (int i = 0; i < userNums; i++)
                    {            
                        Console.WriteLine($"Your numbers: {mNums[i]}");
                    }
                }
            }*/



        }
    }
}
