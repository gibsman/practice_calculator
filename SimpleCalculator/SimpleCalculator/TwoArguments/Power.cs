using System;

namespace SimpleCalculator.TwoArguments
{
    public class Power : IOperationWithTwoArguments
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return Math.Pow(firstArgument, secondArgument);
        }
    }
}
