using System;
using NUnit.Framework;
using SimpleCalculator.OneArgument;

namespace SimpleCalculator.Tests.OneArgument
{
    /// <summary>
    /// Tests arccos
    /// </summary>
    [TestFixture]
    class AcosTests
    {
        /// <summary>
        /// Method that tests arccos
        /// </summary>
        /// <param name="input"></param>
        /// <param name="output"></param>
        [TestCase(0.3, 1.26)]
        [TestCase(-0.9, 2.69)]

        public void Calculate(double input, double output)
        {
            var calculator = new Acos();
            var testResult = calculator.Calculate(input);
            var result = output;
            Assert.AreEqual(testResult, result, 0.01);
        }

        /// <summary>
        /// Method that elicits negative arguments and gives exception in return
        /// </summary>
        [Test]
        [ExpectedException(typeof(Exception))]
        public void NegativeLgTests()
        {
            var calculator = new Acos();
            var result = calculator.Calculate(10);
        }
    }
}