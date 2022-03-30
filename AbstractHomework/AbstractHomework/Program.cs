using AbstractHomework.Models;
using System;

namespace AbstractHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            Square sq = new Square(3);
            Rectangular rt = new Rectangular(5, 6);
            Console.WriteLine("1. Square, 2.Rectangular, 0.Quit");
            int input = Convert.ToInt32(Console.ReadLine());
            if (input == 1)
            {
                sq.CalcArea();
            }
            else if (input == 2)
            {
                rt.CalcArea();
            }
            else if (input == 0)
                Console.WriteLine("Program is quitted");
        }
    }
}
