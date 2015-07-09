using System;

namespace SimpleCalculator.OneArgument
{
    public class Sin : IOperationWithOneArgument
    {
        public double Calculate(double argument)
        {
            return Math.Sin(argument);
        }
    }
}
