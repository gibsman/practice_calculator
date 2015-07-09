using System;

namespace SimpleCalculator.TwoArguments
{
    /// <summary>
    /// Calculates power
    /// </summary>
    public class Power : IOperationWithTwoArguments
    {
        /// <summary>
        /// Method that calculates power
        /// </summary>
        /// <param name="argument"></param>
        /// <returns></returns>
        public double Calculate(double firstArgument, double secondArgument)
        {
            return Math.Pow(firstArgument, secondArgument);
        }
    }
}
