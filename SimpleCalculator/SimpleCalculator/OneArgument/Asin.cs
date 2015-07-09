using System;

namespace SimpleCalculator.OneArgument
{
    /// <summary>
    /// Calculates arcsin
    /// </summary>
    public class Asin : IOperationWithOneArgument
    {
        /// <summary>
        /// Method that calculates arcsin
        /// </summary>
        /// <param name="argument"></param>
        /// <returns></returns>
        public double Calculate(double argument)
        {

            if (argument >1 || argument < -1)
            {
                throw new Exception("The area define");
            }
            else
            {
                return Math.Asin(argument);
            }
        }
    }
}