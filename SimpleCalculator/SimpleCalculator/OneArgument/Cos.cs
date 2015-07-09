using System;

namespace SimpleCalculator.OneArgument
{
    public class Cos : IOperationWithOneArgument
    {
        public double Calculate(double argument)
        {
            return Math.Cos(argument);
        }
    }
}
