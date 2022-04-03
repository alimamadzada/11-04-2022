using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionHomework
{
    class NotFoundException : Exception
    {
        public NotFoundException() : base()
        {
            Console.WriteLine("not found any Exception");
        }
        public NotFoundException(string message) : base(message)
        {

        }
    }
}
