using System;
using NUnit.Framework;
using SimpleCalculator.OneArgument;

namespace SimpleCalculator.Tests.OneArgument
{
    [TestFixture]
    class InverseValueTests
    {
        [TestCase(10, 0.1)]
        [TestCase(-5, -0.2)]
        [TestCase(256, 16)]
        [TestCase(50, 0.02)]

        public void Calculate(double input, double output)
        {
            var calculator = new InverseValue();
            var testResult = calculator.Calculate(input);
            var result = output;
            Assert.AreEqual(testResult, result);
        }

        [Test]
        [ExpectedException(typeof(Exception))]
        public void DivisionByZeroTests()
        {
            var calculator = new InverseValue();
            var result = calculator.Calculate(0);
        }
    }
}
