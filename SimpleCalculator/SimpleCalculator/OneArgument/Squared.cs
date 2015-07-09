using System;

namespace SimpleCalculator.OneArgument
{
    /// <summary>
    /// Calculates Squared
    /// </summary>
    public class Squared : IOperationWithOneArgument
    {
        /// <summary>
        /// Method that calculates Squared
        /// </summary>
        /// <param name="argument"></param>
        /// <returns></returns>
        public double Calculate(double argument)
        {
            return Math.Pow(argument, 2);
        }
    }
}
