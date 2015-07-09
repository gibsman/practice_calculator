using System;
using SimpleCalculator.Sorters;

namespace SimpleCalculator
{
    /// <summary>
    /// Factory that sorts arrays
    /// </summary>
    public static class FactorySorters
    {
        /// <summary>
        /// Method that uses factory for sorting arrays
        /// </summary>
        /// <param name="operation"></param>
        /// <returns></returns>
        public static ISorters GetSorting(string operation)
        {
            switch (operation)
            {
                case "Bubble": 
                    return new Bubble();
                case "Selection":
                    return new Selection();
                case "Insertion":
                    return new Insertion();
                case "Bucket": 
                    return new Bucket();
                default: 
                    throw new Exception("Unknown error!");
            }
        }

    }
}