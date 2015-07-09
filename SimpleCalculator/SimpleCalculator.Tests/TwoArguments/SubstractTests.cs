using NUnit.Framework;
using SimpleCalculator.TwoArguments;

namespace SimpleCalculator.Tests.TwoArguments
{
    /// <summary>
    /// Tests substraction
    /// </summary>
    [TestFixture]
    class SubstractTests
    {
        /// <summary>
        /// Method that tests substraction
        /// </summary>
        /// <param name="input"></param>
        /// <param name="output"></param>
        [TestCase(40, 10, 30)]
        [TestCase(-10, 10, -20)]
        [TestCase(-5, -45, -50)]
        [TestCase(-25, -10, -15)]

        public void Calculate(double firstInput, double secondInput, double output)
        {
            var calculator = new Substract();
            var testResult = calculator.Calculate(firstInput, secondInput);
            var result = output;
            Assert.AreEqual(testResult, result);
        }
    }
}
