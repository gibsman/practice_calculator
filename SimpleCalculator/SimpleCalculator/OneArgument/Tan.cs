using System;

namespace SimpleCalculator.OneArgument
{
    public class Tan : IOperationWithOneArgument
    {
        public double Calculate(double argument)
        {
            return Math.Tan(argument);
        }
    }
}
