using System;
using NUnit.Framework;
using SimpleCalculator.TwoArguments;

namespace SimpleCalculator.Tests.TwoArguments
{
    /// <summary>
    /// Tests divivsion
    /// </summary>
    [TestFixture]
    class DivisionTests
    {
        /// <summary>
        /// Method that tests divivsion
        /// </summary>
        /// <param name="input"></param>
        /// <param name="output"></param>
        [TestCase(100,10, 10)]
        [TestCase(-5,10, 0.5)]
        [TestCase(256,16, 15)]
        [TestCase(-15,-5,3)]
        [TestCase(1, 2, 0.5)]

        public void Calculate(double firstInput, double secondInput, double output)
        {
            var calculator = new Divide();
            var testResult = calculator.Calculate(firstInput, secondInput);
            var result = output;
            Assert.AreEqual(testResult, result);
        }
        /// <summary>
        /// Method that elicits negative arguments and gives exception in return
        /// </summary>

        [Test]
        [ExpectedException(typeof(Exception))]
        public void DivisionByZeroTests()
        {
            var calculator = new Divide();
            var result = calculator.Calculate(4, 0);
        }
    }
}
