using StaticHomework.Models;
using System;

namespace StaticHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = Calculator.Multiply(2, 1);
            Console.WriteLine(num.Power(6)); 
        }
    }
}
