namespace SimpleCalculator.TwoArguments
{
    /// <summary>
    /// Calculates substraction
    /// </summary>
    public class Substract : IOperationWithTwoArguments
    {
        /// <summary>
        /// Method that calculates substraction
        /// </summary>
        /// <param name="argument"></param>
        /// <returns></returns>
        public double Calculate(double firstArgument, double secondArgument)
        {
            return firstArgument - secondArgument;
        }
    }
}
