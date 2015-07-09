using System;

namespace SimpleCalculator.OneArgument
{
        /// <summary>
        /// Calculates InverseValue
        /// </summary>
    public class InverseValue : IOperationWithOneArgument
    {
            /// <summary>
            /// Method that calculates InverseValue
            /// </summary>
            /// <param name="argument"></param>
            /// <returns></returns>
        public double Calculate(double argument)
        {
            if (argument == 0)
            {
                throw new Exception("Division by zero");
            }
            else
            {
                return 1/argument;
            }
        }
    }
}