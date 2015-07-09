namespace SimpleCalculator.TwoArguments
{
    /// <summary>
    /// Calculates multiplication
    /// </summary>
    public class Multiply : IOperationWithTwoArguments
    {
        /// <summary>
        /// Method that calculates multiplication
        /// </summary>
        /// <param name="argument"></param>
        /// <returns></returns>
        public double Calculate(double firstArgument, double secondArgument)
        {
            return firstArgument * secondArgument;
        }
    }
}
