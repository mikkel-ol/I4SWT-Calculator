using System;

namespace Calculators
{
    public class CalculatorException : Exception
    {
        public double Number;
        public CalculatorException(double no) => Number(no);
    }
}