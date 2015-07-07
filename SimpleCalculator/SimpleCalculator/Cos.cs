using System;

namespace SimpleCalculator
{
    public class Cos : IOperationWithOneArgument
    {
        public double Calculate(double argument)
        {
            return Math.Cos(argument);
        }
    }
}
