using System;

namespace SimpleCalculator.OneArgument
{
    /// <summary>
    /// Calculates Sqrt
    /// </summary>
    public class Sqrt : IOperationWithOneArgument
    {
        /// <summary>
        /// Method that calculates Sqrt
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
                return Math.Sqrt(argument);
            }
        }
    }
}
