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
                default: throw new Exception("Unknown error!");
            }
        }

    }
}
