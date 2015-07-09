using System;

namespace SimpleCalculator.OneArgument
{
    /// <summary>
    /// Calculates Ln
    /// </summary>
    public class Ln : IOperationWithOneArgument
    {
        /// <summary>
        /// Method that calculates Ln
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
                return Math.Log(argument);
            }
        }
    }
}