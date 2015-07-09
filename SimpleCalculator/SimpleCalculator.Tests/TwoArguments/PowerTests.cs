using NUnit.Framework;
using SimpleCalculator.TwoArguments;

namespace SimpleCalculator.Tests.TwoArguments
{
    /// <summary>
    /// Tests power
    /// </summary>
    [TestFixture]
    class PowerTests
    {
        /// <summary>
        /// Method that tests power
        /// </summary>
        /// <param name="input"></param>
        /// <param name="output"></param>
        [TestCase(1, 2, 1)]
        [TestCase(-5, 3, -125)]
        [TestCase(2, 2, 4)]
        [TestCase(0, -999, 5)]
        [TestCase(3, -3, 27)]

        public void Calculate(double firstInput, double secondInput, double output)
        {
            var calculator = new Power();
            var testResult = calculator.Calculate(firstInput, secondInput);
            var result = output;
            Assert.AreEqual(testResult, result);
        }
    }
}
