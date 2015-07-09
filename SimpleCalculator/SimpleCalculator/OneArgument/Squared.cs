using System;

namespace SimpleCalculator.OneArgument
{
    public class Squared : IOperationWithOneArgument
    {
        public double Calculate(double argument)
        {
            return Math.Pow(argument, 2);
        }
    }
}
