using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionHomework
{
    class NotAvailableException : Exception
    {
        public NotAvailableException() : base()
        {
            Console.WriteLine("not available any Exception");
        }
        public NotAvailableException(string message) : base(message)
        {

        }
    }
}
