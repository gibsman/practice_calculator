namespace SimpleCalculator.TwoArguments
{
    public class Add : IOperationWithTwoArguments
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return firstArgument+secondArgument;
        }
    }
}
