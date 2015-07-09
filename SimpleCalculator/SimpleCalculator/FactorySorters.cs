using System;
using SimpleCalculator.Sorters;

namespace SimpleCalculator
{
    public static class FactorySorters
    {
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