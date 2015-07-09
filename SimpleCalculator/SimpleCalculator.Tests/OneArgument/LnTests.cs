using System;
using NUnit.Framework;
using SimpleCalculator.OneArgument;

namespace SimpleCalculator.Tests.OneArgument
{
    [TestFixture]
    class LnTests
    {
        [TestCase(0, 0)]
        [TestCase(1, 0)]
        [TestCase(2.71, 1)]
        [TestCase(2, -2.1)]

        public void Calculate(double input, double output)
        {
            var calculator = new Ln();
            var testResult = calculator.Calculate(input);
            var result = output;
            Assert.AreEqual(testResult, result, 0.1);
        }
        [Test]
        [ExpectedException(typeof(Exception))]
        public void NegativeLnTests()
        {
            var calculator = new Ln();
            var result = calculator.Calculate(-4);
        }
    }
}
