using System;
using NUnit.Framework;

namespace SimpleCalculator.Tests
{
    [TestFixture]
    class AsinTests
    {
        [TestCase(0.5, 0.52)]
        [TestCase(-0.7, -0.77)]

        public void Calculate(double input, double output)
        {
            var calculator = new SimpleCalculator.Asin();
            var testResult = calculator.Calculate(input);
            var result = output;
            Assert.AreEqual(testResult, result,0.01);
        }
        [Test]
        [ExpectedException(typeof(Exception))]
        public void NegativeLgTests()
        {
            var calculator = new Asin();
            var result = calculator.Calculate(-2);
        }
    }
}