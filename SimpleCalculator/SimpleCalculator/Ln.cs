using System;

namespace SimpleCalculator
{
    public class Ln : IOperationWithOneArgument
    {
        public double Calculate(double argument)
        {
            return Math.Log(argument);
        }
    }
}
