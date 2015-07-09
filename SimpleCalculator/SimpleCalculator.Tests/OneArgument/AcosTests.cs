using System;
using NUnit.Framework;
using SimpleCalculator.OneArgument;

namespace SimpleCalculator.Tests.OneArgument
{
    [TestFixture]
    class AcosTests
    {
        [TestCase(0.3, 1.26)]
        [TestCase(-0.9, 2.69)]

        public void Calculate(double input, double output)
        {
            var calculator = new Acos();
            var testResult = calculator.Calculate(input);
            var result = output;
            Assert.AreEqual(testResult, result, 0.01);
        }
        [Test]
        [ExpectedException(typeof(Exception))]
        public void NegativeLgTests()
        {
            var calculator = new Acos();
            var result = calculator.Calculate(10);
        }
    }
}