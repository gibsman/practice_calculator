using System;

namespace SimpleCalculator.OneArgument
{
    public class Sqrt : IOperationWithOneArgument
    {
        public double Calculate(double argument)
        {
            if (argument <= 0)
            {
                throw new Exception("Argument must be more or equal than 0");
            }
            else
            {
                return Math.Sqrt(argument);
            }
        }
    }
}
