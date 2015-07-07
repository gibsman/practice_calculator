using System;

namespace SimpleCalculator
{
    public static class FactoryWithTwoArguments
    {
        public static IOperationWithTwoArguments GetCalculator(string operation)
        {
            switch (operation)
            {
                case "Addition": return new Add();
                case "Substraction": return new Substract();
                case "Division": return new Divide();
                case "Multiplication": return new Multiply();
                case "Power": return new Power();
                default: throw new Exception("Unknown error!");
            }
        }

    }
}
