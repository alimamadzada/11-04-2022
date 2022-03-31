using System;
using System.Collections.Generic;
using System.Text;

namespace StaticHomework.Models
{
    static class Calculator
    {
        static public int Sum(int a, int b)
        {
            return a + b;
        }
        static public int Subtract(int a, int b)
        {
            return a - b;
        }
        static public int Multiply(int a, int b)
        {
            return a * b;
        }
        static public int Divide(int a, int b)
        {
            return a / b;
        }
        public static int Power(this int a, int b)
        {
            return (int)Math.Pow(a, b);
        }
    }
}
