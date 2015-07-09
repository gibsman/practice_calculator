using System;
using SimpleCalculator.TwoArguments;

namespace SimpleCalculator
{
    /// <summary>
    /// Factory that calculates operations with two arguments
    /// </summary>
    public static class FactoryWithTwoArguments
    {
        /// <summary>
        /// Method that uses factory for calculations with two arguments
        /// </summary>
        /// <param name="operation"></param>
        /// <returns></returns>
        public static IOperationWithTwoArguments GetCalculator(string operation)
        {
            switch (operation)
            {
                case "Addition": 
                    return new Add();
                case "Substraction": 
                    return new Substract();
                case "Division": 
                    return new Divide();
                case "Multiplication":
                    return new Multiply();
                case "Power": 
                    return new Power();
                default: 
                    throw new Exception("Unknown error!");
            }
        }

    }
}
