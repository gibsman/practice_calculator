using System;

namespace SimpleCalculator
{
    /// <summary>
    /// Validation of input text and converting that text into numbers
    /// </summary>
    public static class ValidateNumbers
    {
        /// <summary>
        /// Method that validates text and converts it into numbers
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static double ValidateAndConvert(string input)
        {
            double output;
            if (double.TryParse(input, out output)==false)
            {
                throw new Exception("Unexpected symbol in input area");
            }
            return output;
        }
    }
}
