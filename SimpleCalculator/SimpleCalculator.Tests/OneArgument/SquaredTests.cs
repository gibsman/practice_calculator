using NUnit.Framework;
using SimpleCalculator.OneArgument;

namespace SimpleCalculator.Tests.OneArgument
{
    /// <summary>
    /// Tests squared
    /// </summary>
    [TestFixture]
    class SquaredTests
    {
        /// <summary>
        /// Method that tests squared
        /// </summary>
        /// <param name="input"></param>
        /// <param name="output"></param>
        [TestCase(10, 100)]
        [TestCase(-2, 4)]
        [TestCase(0, 0)]
        [TestCase(6, -36)]
        [TestCase(8, 64)]

        public void Calculate(double input, double output)
        {
            var calculator = new Squared();
            var testResult = calculator.Calculate(input);
            var result = output;
            Assert.AreEqual(testResult, result);
        }
    }
}
