using System;

namespace SimpleCalculator.OneArgument
{
    public class InverseValue : IOperationWithOneArgument
    {
        public double Calculate(double argument)
        {
            if (argument == 0)
            {
                throw new Exception("Division by zero");
            }
            else
            {
                return 1/argument;
            }
        }
    }
}