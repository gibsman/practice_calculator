using System;

namespace SimpleCalculator
{
    public class Module : IOperationWithOneArgument
    {
        public double Calculate(double argument)
        {
            return Math.Abs(argument);
        }
    }
}