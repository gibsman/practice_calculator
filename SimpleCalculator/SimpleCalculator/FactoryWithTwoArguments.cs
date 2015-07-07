using System;

namespace SimpleCalculator
{
    public static class FactoryWithTwoArguments
    {
        public static IOperationWithTwoArguments Calculate(string operation)
        {
            switch (operation)
            {
                case "Add": return new Add();
                case "Substract": return new Substract();
                case "Divide": return new Divide();
                case "Multiply": return new Multiply();
                default: throw new Exception("Unknow error!");
            }
        }

    }
}
