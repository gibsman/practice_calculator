using System;
using NUnit.Framework;
using SimpleCalculator.OneArgument;

namespace SimpleCalculator.Tests.OneArgument
{
    /// <summary>
    /// Tests lg
    /// </summary>
    [TestFixture]
    class LgTests
    {
        /// <summary>
        /// Method that tests lg
        /// </summary>
        /// <param name="input"></param>
        /// <param name="output"></param>
        [TestCase(100, 2)]
        [TestCase(1, 0)]

        public void Calculate(double input, double output)
        {
            var calculator = new Lg();
            var testResult = calculator.Calculate(input);
            var result = output;
            Assert.AreEqual(testResult, result);
        }

        /// <summary>
        /// Method that elicits negative arguments and gives exception in return
        /// </summary>
        [Test]
        [ExpectedException(typeof(Exception))]
        public void NegativeLgTests()
        {
            var calculator = new Lg();
            var result = calculator.Calculate(-4);
        }
    }
}
