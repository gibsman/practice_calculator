using System;

namespace SimpleCalculator.OneArgument
{
    /// <summary>
    /// Calculates Sin
    /// </summary>
    public class Sin : IOperationWithOneArgument
    {
        /// <summary>
        /// Method that calculates Sin
        /// </summary>
        /// <param name="argument"></param>
        /// <returns></returns>
        public double Calculate(double argument)
        {
            return Math.Sin(argument);
        }
    }
}
