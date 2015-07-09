namespace SimpleCalculator.TwoArguments
{
    public class Substract : IOperationWithTwoArguments
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return firstArgument - secondArgument;
        }
    }
}
