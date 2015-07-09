using System;

namespace SimpleCalculator.OneArgument
{
    /// <summary>
    /// Calculates Module
    /// </summary>
    public class Module : IOperationWithOneArgument
    {
        /// <summary>
        /// Method that calculates Module
        /// </summary>
        /// <param name="argument"></param>
        /// <returns></returns>
        public double Calculate(double argument)
        {
            return Math.Abs(argument);
        }
    }
}