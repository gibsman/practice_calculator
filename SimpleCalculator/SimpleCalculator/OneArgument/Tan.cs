using System;

namespace SimpleCalculator.OneArgument
{
    /// <summary>
    /// Calculates Tan
    /// </summary>
    public class Tan : IOperationWithOneArgument
    {
        /// <summary>
        /// Method that calculates Tan
        /// </summary>
        /// <param name="argument"></param>
        /// <returns></returns>
        public double Calculate(double argument)
        {
            return Math.Tan(argument);
        }
    }
}
