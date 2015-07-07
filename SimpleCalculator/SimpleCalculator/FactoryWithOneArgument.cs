using System;

namespace SimpleCalculator
{
    public  static class FactoryWithOneArgument
    {
        public static IOperationWithOneArgument Calculate(string operation)
        {
            switch (operation)
            {
                case "Sin": return new Sin();
                case "Squared": return new Squared();
                case "Lg":return new Lg();
                case "Ln":return new Ln();
                case "Cos":return new Cos();
                case "Sqrt":return new Sqrt();
                default:throw new Exception("Unknown error!");
            }
        }

    }
}
