using System;

namespace SimpleCalculator.OneArgument
{
    /// <summary>
    /// Calculates Lg
    /// </summary>
    public class Lg : IOperationWithOneArgument
    {
        /// <summary>
        /// Method that calculates Lg
        /// </summary>
        /// <param name="argument"></param>
        /// <returns></returns>
        public double Calculate(double argument)
        {
            if (argument <= 0)
            {
                throw new Exception("Argument must be more or equal than 0");
            }
            else
            {
                return Math.Log10(argument);
            }
        }
    }
}
