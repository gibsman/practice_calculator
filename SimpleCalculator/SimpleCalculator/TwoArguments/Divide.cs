using System;

namespace SimpleCalculator.TwoArguments
{
    /// <summary>
    /// Calculates division
    /// </summary>
    public class Divide : IOperationWithTwoArguments
    {
        /// <summary>
        /// Method that calculates division
        /// </summary>
        /// <param name="argument"></param>
        /// <returns></returns>
        public double Calculate(double firstArgument, double secondArgument)
        {
            if (secondArgument == 0)
            {
                throw new Exception("Division by zero");
            }
            else
            {
                return firstArgument / secondArgument;
            }
        }
    }
}
