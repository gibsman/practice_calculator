using System;

namespace SimpleCalculator
{
    public class Sin : IOperationWithOneArgument
    {
        public double Calculate(double argument)
        {
            return Math.Sin(argument);
        }
    }
}
