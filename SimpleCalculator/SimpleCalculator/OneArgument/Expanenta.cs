using System;

namespace SimpleCalculator.OneArgument
{
    /// <summary>
    /// Calculates Exp
    /// </summary>
    public class Expanenta : IOperationWithOneArgument
    {
        /// <summary>
        /// Method that calculates Exp
        /// </summary>
        /// <param name="argument"></param>
        /// <returns></returns>
        public double Calculate(double argument)
        {
            return Math.Exp(argument);
        }
    }
}
