﻿using System;

namespace SimpleCalculator.OneArgument
{
    /// <summary>
    /// Calculates arccos
    /// </summary>
    public class Acos : IOperationWithOneArgument
    {
        /// <summary>
        /// Method that calculates arccos
        /// </summary>
        /// <param name="argument"></param>
        /// <returns></returns>
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