using System;

namespace Zadacha3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose what figure you want to calculate:");
            Console.WriteLine("1.Circle\n2.Parallelogram\n3.Square\n4.Triangle\n5.Trapezoid");
            Console.Write("Choose: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice) 
            {
                case 1:
                    Console.WriteLine("Circle face");
                    Console.Write("R= ");
                    double radious = int.Parse(Console.ReadLine());
                    double circleFace = CircleFace(radious);
                    string CirclefaceFormat = circleFace.ToString("0.00");
                    Console.WriteLine($"Circle face: {CirclefaceFormat}");
                    break;

                case 2:
                    Console.WriteLine("Parallelogram Face");
                    Console.Write("A= ");
                    int aStrana = int.Parse(Console.ReadLine());
                    Console.Write("Ha= ");
                    int hAstrana= int.Parse(Console.ReadLine());
                    int parallelFace = ParallelFace(aStrana, hAstrana);
                    Console.WriteLine($"Parallelogram face: {parallelFace}");
                    break ; 

                case 3:
                    Console.WriteLine("Squere Face");
                    Console.Write("A= ");
                    int a = int.Parse(Console.ReadLine());                 
                    int squereFace =SquereFace(a);
                    Console.WriteLine($"Circle face: {squereFace}");
                    break;

                case 4:
                    Console.WriteLine("Triangle Face");
                    Console.Write("A= ");
                    int tringleAstrana = int.Parse(Console.ReadLine());
                    Console.Write("B= ");
                    int triangleBstrana = int.Parse(Console.ReadLine());
                    int triangleFace = TriangleFace(tringleAstrana, triangleBstrana);
                    Console.WriteLine($"Circle face: {triangleFace}");
                    break;

                case 5:
                    Console.WriteLine("Trapezoid Face");
                    Console.Write("A= ");
                    int trapezoidAstrana = int.Parse(Console.ReadLine());
                    Console.Write("B= ");
                    int trapezoidBstrana = int.Parse(Console.ReadLine());
                    Console.Write("H= ");
                    int trapezoidH = int.Parse(Console.ReadLine());
                    int trapezoidFace = TrapezoidFace(trapezoidAstrana, trapezoidBstrana, trapezoidH);
                    Console.WriteLine($"Circle face: {trapezoidFace}");
                    break;
            }

        }

        public static double CircleFace(double radious)
        {
            return Math.PI * radious;
        }

        public static int ParallelFace(int aStrana, int hAstrana)
        {

           return aStrana * hAstrana;
        }

        public static int SquereFace(int stranaA)
        {
            return stranaA * stranaA;
        }

        public static int TriangleFace(int tringleAstrana, int triangleBstrana)
        {
            return (tringleAstrana * triangleBstrana) / 2;

        }

        public static int TrapezoidFace(int trapezoidAstrana, int trapezoidBstrana, int trapezoidH)
        {
            return (trapezoidAstrana + trapezoidBstrana) * trapezoidH / 2;

        }
 
    }
}
