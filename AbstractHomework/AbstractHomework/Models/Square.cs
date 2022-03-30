using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractHomework.Models
{
    class Square : Figure
    {
        private int _side;
        public Square(int side)
        {
            Side = side;
        }
        public int Side
        {
            get { return _side; }
            set
            {
                if (value > 0)
                    _side = value;
            }
        }
        public override void CalcArea()
        {
            Console.WriteLine(Side + " square is = " + _side * _side);
        }
    }
}
