using System;
using NUnit.Framework;
using SimpleCalculator.OneArgument;

namespace SimpleCalculator.Tests.OneArgument
{
    [TestFixture]
    class LgTests
    {
        [TestCase(100, 2)]
        [TestCase(1, 0)]

        public void Calculate(double input, double output)
        {
            var calculator = new Lg();
            var testResult = calculator.Calculate(input);
            var result = output;
            Assert.AreEqual(testResult, result);
        }
        [Test]
        [ExpectedException(typeof(Exception))]
        public void NegativeLgTests()
        {
            var calculator = new Lg();
            var result = calculator.Calculate(-4);
        }
    }
}
