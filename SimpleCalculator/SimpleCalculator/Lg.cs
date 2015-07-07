using System;
using SimpleCalculator;

namespace SimpleCalculator
{
    public class Lg : IOperationWithOneArgument
    {
        public double Calculate(double argument)
        {
            return Math.Log10(argument);
        }
    }
}
