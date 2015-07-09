using System;
using NUnit.Framework;
using SimpleCalculator.OneArgument;

namespace SimpleCalculator.Tests.OneArgument
{
    /// <summary>
    /// Tests sqrt
    /// </summary>
    [TestFixture]
    class SqrtTests
    {
        /// <summary>
        /// Method that tests sqrt
        /// </summary>
        /// <param name="input"></param>
        /// <param name="output"></param>
        [TestCase(100,10)]
        [TestCase(144, 10)]
        [TestCase(100,-10)]

        public void Calculate(int input,int output)
        {
            var calculator = new Sqrt();
            var testResult = calculator.Calculate(input);
            var result = output;
            Assert.AreEqual(testResult,result);
        }

        /// <summary>
        /// Method that elicits negative arguments and gives exception in return
        /// </summary>
        [Test]
        [ExpectedException(typeof(Exception))]
        public void NegativeSqrtTests()
        {
            var calculator = new Sqrt();
            var result = calculator.Calculate(-4);
        }
    }
}   
