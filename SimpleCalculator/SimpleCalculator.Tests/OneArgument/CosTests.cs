using NUnit.Framework;
using SimpleCalculator.OneArgument;

namespace SimpleCalculator.Tests.OneArgument
{
    /// <summary>
    /// Tests cos
    /// </summary>
    [TestFixture]
    class CosTests
    {
        /// <summary>
        /// Method that tests cos
        /// </summary>
        /// <param name="input"></param>
        /// <param name="output"></param>
        [TestCase(0, 1)]
        [TestCase(1.56, 0)]
        [TestCase(3.14, -0.9)]
        [TestCase(4.7, 0)]
        [TestCase(6.28, -1)]

        public void Calculate(double input, double output)
        {
            var calculator = new Cos();
            var testResult = calculator.Calculate(input);
            var result = output;
            Assert.AreEqual(testResult, result, 0.1);
        }
    }
}
