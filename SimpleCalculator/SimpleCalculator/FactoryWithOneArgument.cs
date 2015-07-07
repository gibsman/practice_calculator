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
                default:throw new Exception("Unknow error!");
            }
        }

    }
}
