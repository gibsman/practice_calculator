using System;

namespace SimpleCalculator.OneArgument
{
    public class Expanenta : IOperationWithOneArgument
    {
        public double Calculate(double argument)
        {
            return Math.Exp(argument);
        }
    }
}
