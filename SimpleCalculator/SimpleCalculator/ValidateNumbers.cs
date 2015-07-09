using System;

namespace SimpleCalculator
{
    public static class ValidateNumbers
    {
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
