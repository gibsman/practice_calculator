using System;

namespace SimpleCalculator.OneArgument
{
    public class Module : IOperationWithOneArgument
    {
        public double Calculate(double argument)
        {
            return Math.Abs(argument);
        }
    }
}