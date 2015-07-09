using System;
using NUnit.Framework;
using SimpleCalculator.OneArgument;

namespace SimpleCalculator.Tests.OneArgument
{
    /// <summary>
    /// Tests sin
    /// </summary>
    [TestFixture]
    class AsinTests
    {
        /// <summary>
        /// Method that tests sin
        /// </summary>
        /// <param name="input"></param>
        /// <param name="output"></param>
        [TestCase(0.5, 0.52)]
        [TestCase(-0.7, -0.77)]

        public void Calculate(double input, double output)
        {
            var calculator = new Asin();
            var testResult = calculator.Calculate(input);
            var result = output;
            Assert.AreEqual(testResult, result,0.01);
        }
        /// <summary>
        /// Method that elicits negative arguments and gives exception in return
        /// </summary>
        [Test]
        [ExpectedException(typeof(Exception))]
        public void NegativeLgTests()
        {
            var calculator = new Asin();
            var result = calculator.Calculate(-2);
        }
    }
}