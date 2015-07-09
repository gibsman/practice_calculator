namespace SimpleCalculator.TwoArguments
{
    /// <summary>
    /// Calculates addition
    /// </summary>
    public class Add : IOperationWithTwoArguments
    {
        /// <summary>
        /// Method that calculates addition
        /// </summary>
        /// <param name="argument"></param>
        /// <returns></returns>
        public double Calculate(double firstArgument, double secondArgument)
        {
            return firstArgument+secondArgument;
        }
    }
}
