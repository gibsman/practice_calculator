using System;

namespace SimpleCalculator
{
    public class Ln : IOperationWithOneArgument
    {
        public double Calculate(double argument)
        {
            if (argument <= 0)
            {
                throw new Exception("Argument must be more or equal than 0");
            }
            else
            {
                return Math.Log(argument);
            }
        }
    }
}
