namespace SimpleCalculator.TwoArguments
{
    public class Multiply : IOperationWithTwoArguments
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return firstArgument * secondArgument;
        }
    }
}
