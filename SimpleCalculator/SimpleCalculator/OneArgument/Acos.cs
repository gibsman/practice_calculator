using System;

namespace SimpleCalculator
{
    public class Acos : IOperationWithOneArgument
    {
        public double Calculate(double argument)
        {

            if (argument > 1 || argument < -1)
            {
                throw new Exception("The area define");
            }
            else
            {
                return Math.Acos(argument);
            }
        }
    }
}