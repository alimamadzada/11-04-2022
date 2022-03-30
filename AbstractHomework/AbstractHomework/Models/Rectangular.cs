using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractHomework.Models
{
    class Rectangular : Figure
    {
        private int _width;
        private int _length;
        public Rectangular(int width, int length)
        {
            _width = width;
            _length = length;
        }
        public int Width
        {
            get { return _width; }
            set
            {
                if (value > 0)
                    _width = value;
            }
        }


        public int Length
        {
            get { return _length; }
            set
            {
                if (value > 0)
                    _length = value;
            }
        }

        public override void CalcArea()
        {
            Console.WriteLine("Rectangular area= " + Width * Length);
        }
    }
}
