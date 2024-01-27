using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class CalcularoService
    {
        internal DivideResult Divide(int x, int y)
        {
            if (y == 0)
            {
                throw new ArgumentException("Can't divide by 0");
            }
            int quotient = x / y;
            int reminder = x % y;
            DivideResult result = new DivideResult { Quotient = quotient, Reminder = reminder };
            return result;
        }
    }
}
