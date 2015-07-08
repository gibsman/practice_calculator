using System;

namespace SimpleCalculator
{
    public class Expanenta : IOperationWithOneArgument
    {
        public double Calculate(double argument)
        {
            return Math.Exp(argument);
        }
    }
}
