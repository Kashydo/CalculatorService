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
            int quotient = x / y;
            int reminder = x % y;
            return new DivideResult { Quotient = quotient, Reminder = reminder };
        }
    }
}
