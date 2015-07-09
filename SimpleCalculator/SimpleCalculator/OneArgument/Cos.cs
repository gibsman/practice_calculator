using System;

namespace SimpleCalculator.OneArgument
{
    /// <summary>
    /// Calculates cos
    /// </summary>
    public class Cos : IOperationWithOneArgument
    { 
        /// <summary>
        /// Method that calculates cos
        /// </summary>
        /// <param name="argument"></param>
        /// <returns></returns>
        public double Calculate(double argument)
        {
            return Math.Cos(argument);
        }
    }
}
