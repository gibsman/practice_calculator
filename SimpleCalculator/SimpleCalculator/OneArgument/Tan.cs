using System;

namespace SimpleCalculator
{
    public class Tan : IOperationWithOneArgument
    {
        public double Calculate(double argument)
        {
            return Math.Tan(argument);
        }
    }
}
