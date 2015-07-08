using System;

namespace SimpleCalculator
{
    public  static class FactoryWithOneArgument
    {
        public static IOperationWithOneArgument GetCalculator(string operation)
        {
            switch (operation)
            {
                case "Sin": 
                    return new Sin();
                case "Squared": 
                    return new Squared();
                case "Lg":
                    return new Lg();
                case "Ln":
                    return new Ln();
                case "Cos":
                    return new Cos();
                case "Sqrt":
                    return new Sqrt();
                case "Tan":
                    return new Tan();
                case "InverseValue":
                    return new InverseValue();
                case "Expanenta":
                    return new Expanenta();
                case "Module":
                    return new Module();
                case "Asin":
                    return new Asin();
                case "Acos":
                    return new Acos();
                default:throw new Exception("Unknown error!");
            }
        }

    }
}
